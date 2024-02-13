using System;

namespace api.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string EMP_ID { get; set; } = string.Empty;
        public string FIRST_NAME { get; set;} = string.Empty;
        public string LAST_NAME { get; set;} = string.Empty;
        public string GENDER { get; set;} = string.Empty;
        public string EMP_ADDRESS { get; set;} = string.Empty;
        public string PHONE_NO { get; set;} = string.Empty;
        public string EMAIL_ID { get; set;} = string.Empty;
        public DateTime DATEOFBIRTH { get; set;} // Change to DateTime
        public DateTime DATEOFJOINING { get; set;} // Change to DateTime
        public string PHOTO { get; set;} = string.Empty;
        public int DEPT_ID { get; set;}
    }
}
