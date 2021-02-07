using ExtractWebContent.BLL;
using ExtractWebContent.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HtmlAgilityPack.HtmlWeb;

namespace ExtractWebContent
{
    public partial class Form1 : Form
    {
        private static HtmlWeb Web = new HtmlWeb();

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //var htmlDoc = Web.Load("https://www.cars.bg/");

            //Task t = TUVarnaExtractStudents();
            //await t;
            //EmagExtractProducts();

            string inv = string.Join("\',N\'", ModelConstants.queries.Select(s => s.abr).ToArray());

            Dictionary<string, string> values = new Dictionary<string, string>
            {
                { "stat", "действащи" },
                { "spec", "162" },
                { "oks", "2" },
                { "fob", "1" },
                { "kurs", "1" },
                { "grupa", "1" },
            };
            int count = ModelConstants.queries.Count * (ModelConstants.form.Count * ModelConstants.kurs.Count * ModelConstants.grupa.Count);
            int index = 0;
            List<StudentAccaumt> studentAccaumts = new List<StudentAccaumt>();

            foreach (var spec in ModelConstants.queries)
            {
                values["stat"] = spec.state;
                values["spec"] = spec.code.ToString();
                values["oks"] = spec.type.ToString();
                foreach (var form in ModelConstants.form)
                {
                    values["fob"] = form.ToString();
                    foreach (var kurs in ModelConstants.kurs)
                    {
                        values["kurs"] = kurs.ToString();
                        foreach (var group in ModelConstants.grupa)
                        {
                            values["grupa"] = group.ToString();

                            bool exit = false;
                            do
                            {
                                exit = false;
                                try
                                {
                                    string html = await new GetStudentsFromTUVarna().GetContentAsync("http://www2.tu-varna.bg/prep/index.php/stud/stgroup", values);
                                    //_ = Task.Run(() =>
                                    //  {

                                    HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                                    htmlDoc.LoadHtml(html);
                                    HtmlNodeCollection students = htmlDoc.DocumentNode.SelectNodes("//table[@id='stgroup']");
                                    //List<StudentAccaumt> studentAccaumts = new List<StudentAccaumt>();

                                    string faculty = "(Факултет Трябва да се попълни)";
                                    string department = "(Катедра Трябва да се попълни)";
                                    string specialty = spec.abr;
                                    //string group = "1";
                                    string yearOfAcceptance = string.Empty;
                                    int formOfEducation = ModelConstants.formOfEducationCode[spec.type];
                                    int formCode = ModelConstants.formCode[form];

                                    if (students != null)
                                    {
                                        foreach (var nod in students)
                                        {
                                            foreach (var child in nod.ChildNodes.Skip(2))
                                            {
                                                //foreach (var c in child.ChildNodes.Skip(1)) 
                                                //{
                                                if (yearOfAcceptance.Equals(string.Empty))
                                                {
                                                    var y = child.ChildNodes[1].InnerText.Substring(0, 2);
                                                    var iy = Convert.ToInt32(y);
                                                    var ny = 2000 + iy;

                                                    yearOfAcceptance = (ny).ToString();
                                                }

                                                string[] name = child.ChildNodes[2].InnerText.Split(' ');
                                                studentAccaumts.Add(new StudentAccaumt(child.ChildNodes[1].InnerText, name[0], name[1], name[2], kurs, group, yearOfAcceptance, formCode, formOfEducation, specialty, spec.name));
                                                //}
                                            }
                                        }
                                    }

                                    /*if (studentAccaumts.Any())
                                    {
                                        SaveCsv(studentAccaumts, $"{faculty}_{department}_{specialty}_{group}_{yearOfAcceptance}_{formCode}_{formOfEducation}.csv");
                                        //SaveProducts(studentAccaumts, $"{faculty}_{department}_{specialty}_{group}_{yearOfAcceptance}_{formOfEducation}.csv");
                                    }*/

                                    textBox2.AppendText($"{string.Join(";", values.Select(x => x.Key + "=" + x.Value).ToArray())}\n");
                                    index++;
                                    label2.Text = $"{index} / {count} -> {count - index}";

                                    // });
                                }
                                catch (Exception)
                                {
                                    Thread.Sleep(500);
                                    exit = true;
                                }

                            } while (exit);

                            Thread.Sleep(300);
                        }
                    }
                }
            }

            if (studentAccaumts.Any())
            {
                SaveCsv(studentAccaumts, $"import.csv");
                //SaveProducts(studentAccaumts, $"{faculty}_{department}_{specialty}_{group}_{yearOfAcceptance}_{formOfEducation}.csv");
            }
        }
        private static void SaveCsv(IEnumerable<ICsvItem> items, string filename)
        {
            //MessageBox.Show("Save in file!");
            string strFilePath = filename;
            //string strSeperator = ";";
            StringBuilder sbOutput = new StringBuilder();

            foreach (var item in items)
            {
                sbOutput.AppendLine(item.ToString());
            }

            // Create and write the csv file
            File.WriteAllText(strFilePath, sbOutput.ToString(), Encoding.UTF8);

            // To append more lines to the csv file
            //File.AppendAllText(strFilePath, sbOutput.ToString());
        }
    }
}
