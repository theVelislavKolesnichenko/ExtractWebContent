using System.Text.RegularExpressions;

namespace ExtractWebContent.Models
{
    public class StudentAccaumt : ICsvItem
    {
        private string FacultyNumber { get; set; }
        private string FirstName { get; set; }
        private string SecondName { get; set; }
        private string LastName { get; set; }
        public int Course { get; set; }
        public int Group { get; set; }
        public string Start { get; set; }
        public int Form { get; set; }
        public int Type { get; set; }
        public string Abr { get; set; }
        public string SpName { get; set; }

        public StudentAccaumt(string facultyNumber, string firstName, string secondName, string lastName, int course, int group, string start, int form, int type, string abr, string spName)
        {
            FacultyNumber = facultyNumber;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Course = course;
            Group = group;
            Start = start;
            Form = form;
            Type = type;
            Abr = abr;
            SpName = spName;
        }

        public override string ToString()
        {
            //return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14}",
            //    UserPrincipalName, FirstName, LastName, DisplayName, Title, Department, Password, Office, StreetAddress, City, State, PostalCode, Country, LicenseAssignment, UsageLocation);
            return $"(N'{FirstName}',N'{SecondName}',N'{LastName}',N'',N'',N'{Course}',N'{Group}',N'{FacultyNumber}',N'{Start}',{Form},{Type},N'{Abr}',N'{SpName}'),";
        }
    }
}
