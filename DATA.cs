using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace job_provider
{
    public class Organisation
    {
        public string Organisation_Name { get; set; } = default!;
        public string Organisation_Address { get; set; } = default!;

        public string Organistion_Postcode { get; set; } = default!;
        public string Recruitment_Name { get; set; } = default!;
        public string Recruitment_Number { get; set; } = default!;
        public string Recruitment_Address { get; set; } = default!;
    }


    public class Client
    {
        public string Client_Name { get; set; } = default!;
        public string Client_Address { get; set; } = default!;

        public string Client_Phone { get; set; } = default!;

        public string Work { get; set; } = default!;

        public string Client_Email { get; set; } = default!;
        public bool DrivingLicense { get; set; } = default!;
        public int Max_Distance { get; set; } = default!;
        public string CV { get; set; } = default!;
    }


    public class vacancy
    {
        public string StartDate { get; set; } = default!;
        public string Salary { get; set; } = default!;

        public string Max_Qualification { get; set; } = default!;

        public string Experience { get; set; } = default!;

        public string Type_of_Work { get; set; } = default!;
        public bool DrivingLicense { get; set; } = default!;
        public bool Criminal_Conviction { get; set; } = default!;

        public override string ToString()
        {
            return StartDate + ":          " + Type_of_Work;
        }


    }
}
