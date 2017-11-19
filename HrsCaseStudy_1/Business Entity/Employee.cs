using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace HrsCaseStudy_1.Business_Entity
{
    public class Employee
    {
        private string firstName;
        public string FirstName { get; set; }
        private string middleName;
        public string MiddleName { get; set; }
        private int employeeId;
        public int EmployeeId { get; set; }
        private string lastName;
        public string LastName { get; set; }
        private DateTime birthDate;
        public DateTime BirthDate { get; set; }
        private int age;
        public int Age { get; set; }
        private string gender;
        public string Gender { get; set; }
        private int civilStatus;
        public int CivilStatus { get; set; }
        private string religion;
        public string Religion { get; set; }
        private string ssNo;
        public string SsNo { get; set; }
        private string tinNo;
        public string TinNo { get; set; }
        private string citizenship;
        public string Citizenship { get; set; }
        private string mobileNo;
        public string MobileNo { get; set; }
        private string homePhoneNo;
        public string HomePhoneNo { get; set; }
        private string street1;
        public string Street1 { get; set; }
        private string street2;
        public string Street2 { get; set; }
        private string city;
        public string City { get; set; }
        private string state;
        public string State { get; set; }
        private string zipCode;
        public string ZipCode { get; set; }
        private string country;
        public string Country { get; set; }
        private string projectProfile;
        public string ProjectProfile { get; set; }
        private string skillProfile;
        public string SkillProfile { get; set; }
        private string educBackground;
        public string EducBackground { get; set; }
        private string recognitions;
        public string Recognitions { get; set; }
        private int createdBy;
        public int CreatedBy { get; set; }
        private int lastModifiedBy;
        public int LastModifiedBy { get; set; }
        private DateTime createDate;
        public DateTime CreateDate { get; set; }
        private DateTime lastModifiedDate;
        public DateTime LastModifiedDate { get; set; }
        private CompanyDetails accObj;
        public CompanyDetails AccObj { get; set; }
    }
}