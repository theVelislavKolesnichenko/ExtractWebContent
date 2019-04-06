﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;
using ExtractWebContent.Models;

namespace ExtractWebContent
{
    public partial class Form1 : Form
    {
        private static HtmlWeb Web = new HtmlWeb();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBox1.Text;
                var appSettings = ConfigurationManager.AppSettings;
                string siteName = string.Empty, domain = string.Empty;
                bool hasError = false;
                if (appSettings.Count == 0)
                {
                    MessageBox.Show("AppSettings is empty.");
                    hasError = true;
                }
                else
                {
                    siteName = appSettings["siteName"];
                    if (string.IsNullOrEmpty(siteName))
                    {
                        MessageBox.Show("Missing AppSetting siteName.");
                        hasError = true;
                    }
                    domain = appSettings["domain"];
                    if (string.IsNullOrEmpty(domain))
                    {
                        MessageBox.Show("Missing AppSetting domain.");
                        hasError = true;
                    }
                }

                if (string.IsNullOrEmpty(url) || !url.Contains(siteName))
                {
                    MessageBox.Show("Wrong site name");
                    hasError = true;
                }

                if (!hasError)
                {
                    ExtractProducts(url, domain);
                }
            }
            catch (Exception ex)
            {
                string exeptionMessage = "Unidentified Error";
                do
                {
                    exeptionMessage = ex.Message;
                    ex = ex.InnerException;
                }
                while (ex.InnerException != null);
                MessageBox.Show(exeptionMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ExtractProducts(string url, string domain)
        {
           // HtmlWeb web = new HtmlWeb();

            var htmlDoc = Web.Load(url);

            var categories = htmlDoc.DocumentNode.SelectNodes("//div[@class='category-item']/a");
            //js-change-page hidden-xs hidden-sm

            foreach (var category in categories)
            {
                MessageBox.Show("Node Name: " + category.Name + "\n" + category.InnerText + "\n" + category.Attributes["href"].Value);

                var categoryUrl = category.Attributes["href"].Value;

                HtmlNodeCollection categoryPages = null;
                do {

                    var categoryHtmlDoc = Web.Load($"{domain}{categoryUrl}");


                    SaveProducts(categoryHtmlDoc);

                    categoryPages = categoryHtmlDoc.DocumentNode.SelectNodes("//a[@aria-label='Next']");
                    var nexButton = categoryHtmlDoc.DocumentNode.SelectNodes("//a[@href='javascript:void(0)']");
                    if (categoryPages != null && (nexButton == null || !nexButton.Any(e => e.InnerText == "Напред")))
                    {
                        categoryUrl = categoryPages.Last().Attributes["href"].Value;
                    }
                    else
                    {
                        categoryUrl = null;
                    }
                } while (categoryUrl != null);
            }
        }

        private static void SaveProducts(HtmlAgilityPack.HtmlDocument categoryHtmlDoc)
        {
            HtmlNodeCollection categoryItems = categoryHtmlDoc.DocumentNode.SelectNodes("//div[@class='card-heading']/a");
            var categoryItemsLinks = categoryItems.SelectMany(ci => ci.Attributes.Where(an => an.Name == "href").Select(av => av.Value));
            var csvItems = new List<CsvItem>();

            foreach (var link in categoryItemsLinks)
            {
                //todo: add check
                csvItems.Add(GetCsvItem(link));
            }


            MessageBox.Show("Save in file!");
        }

        private static CsvItem GetCsvItem(string link)
        {
            var page = Web.Load(link);

            var title = page.DocumentNode.SelectNodes("//h1[@class ='page-title']").Select(e => e.InnerText).FirstOrDefault();
            var imageLinks = page.DocumentNode.SelectNodes("//a[@class ='thumbnail product-gallery-image gtm_rp125918']").SelectMany(e => e.Attributes.Where(a => a.Name == "href").Select(v => v.Value));
            //var description = page.DocumentNode.SelectNodes("//div[@id ='description-body']").Select(i => i.InnerText.Trim().Replace("\n", string.Empty).Replace("\t", string.Empty));
            //var regTest = Regex.Replace(string.Join("", description), @"([\t]+)", "");

            IEnumerable<string> description = new List<string>();
            var descriptionNode = page.DocumentNode.SelectNodes("//div[@id ='description-body']");
            if (descriptionNode != null)
            {
                description = descriptionNode.Select(i => i.InnerText.Trim().Replace("\n", string.Empty).Replace("\t", string.Empty));
            }

            CsvItem csvItem = new CsvItem
            {
                Title = title,
                Description = string.Join("", description),
                ImageLinks = imageLinks
            };

            return csvItem;
        }

        private static void Example(string pageingUrl, string domain)
        {
            for (int i = 1; i <= 1334; i++)
            {
                var html = pageingUrl;

                HtmlWeb web = new HtmlWeb();

                var htmlDoc = web.Load(html);

                var nodes = htmlDoc.DocumentNode.SelectNodes("//div[@class='product-img-wrap text-center']/a");

                foreach (var node in nodes)
                {
                    MessageBox.Show("Node Name: " + node.Name + "\n" + node.Attributes["href"].Value);


                    var bookHtml = $"{domain}{node.Attributes["href"].Value}";

                    var bookHtmlDoc = web.Load(bookHtml);

                    var img = bookHtmlDoc.DocumentNode.SelectSingleNode("//a[@class='popup-gallery-image']/img");
                    MessageBox.Show("Node Name: " + img.Name + "\n" + img.Attributes["src"].Value);

                    var title = bookHtmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[6]/div[1]/div[1]/div/div[2]/div/h3");
                    MessageBox.Show("Node Name: " + title.Name + "\n" + title.InnerText);

                    //Автор:
                    var author = bookHtmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[6]/div[1]/div[1]/div/div[2]/div/h5/a");
                    MessageBox.Show("Node Name: " + author.Name + "\n" + author.InnerText);

                    /////html/body/div[1]/div[6]/div[1]/div[1]/div/div[2]/div/table/tbody/tr[1]/td[1]
                    var attributes = bookHtmlDoc.DocumentNode.SelectNodes("//td");

                    var att = attributes.Select(s => s.InnerText).ToArray();

                    string[] category = new string[] { };
                    Dictionary<string, string> attributesByValue = new Dictionary<string, string>();
                    for (int j = 0; j < att.Length; j += 2)
                    {
                        if (att[j] == "Категории")
                        {
                            category = att[j + 1].Split(new char[] { ',' }, options: StringSplitOptions.RemoveEmptyEntries);
                            break;
                        }

                        attributesByValue.Add(att[j], att[j + 1]);
                    }

                    //foreach (var attribute in attributes)
                    //{
                    //    MessageBox.Show("Node Name: " + attribute.Name + "\n" + attribute.InnerText);
                    //}

                    //<p class="product-page-price">Цена: 17.95 лв.</p>
                    var price = bookHtmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[6]/div[1]/div[2]/div[1]/div/p[2]");
                    MessageBox.Show("Node Name: " + price.Name + "\n" + price.InnerText);

                    //<div class="tab-pane fade in active"
                    var description = bookHtmlDoc.DocumentNode.SelectSingleNode("/html/body/div[1]/div[6]/div[2]/div[1]/div/div[1]/p"); 
                    MessageBox.Show("Node Name: " + description.Name + "\n" + description.InnerText);  
                }
            }
        }
    }
}
