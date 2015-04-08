namespace StudentClass
{
    using System;
    using System.Text;

    public class StudentInfo
    {

        public StudentInfo(string permanentAddress, string mobilePhone, string email)
        {
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
        }

        public StudentInfo(StudentInfo studentInfo)
            : this(studentInfo.PermanentAddress, studentInfo.MobilePhone, studentInfo.Email)
        {

        }

        public StudentInfo()
        {

        }

        public string PermanentAddress { get; private set; }
        public string MobilePhone { get; private set; }
        public string Email { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("Permanent Address: {0}; Mobile phone: {1}; E-mail: {2};", this.PermanentAddress, this.MobilePhone, this.Email);
            return result.ToString();
        }
    }
}
