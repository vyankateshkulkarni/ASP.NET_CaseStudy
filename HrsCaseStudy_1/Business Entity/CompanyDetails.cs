using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace HrsCaseStudy_1.Business_Entity
{
    public class CompanyDetails
    {
        private int employeeId;
        public int EmployeeId { get; set; }
        private int createdBy;
        public int CreatedBy { get; set; }
        private int lastModifiedBy;
        public int LastModifiedBy { get; set; }
        private DateTime createDate;
        public DateTime CreateDate { get; set; }
        private DateTime lastModifiedDate;
        public DateTime LastModifiedDate { get; set; }
        private string status;
        public string Status { get; set; }
        private string serviceLine;
        public string ServiceLine { get; set; }
        private string workGroup;
        public string WorkGroup { get; set; }
        private int speciality;
        public int Speciality { get; set; }
        private DateTime dateHired;
        public DateTime DateHired { get; set; }
        private string gmu;
        public string Gmu { get; set; }
        private string lmu;
        public string Lmu { get; set; }
        private int level;
        public int Level { get; set; }
        private string enterpriseId;
        public string EnterpriseId { get; set; }
        private string email;
        public string Email { get; set; }

    
    
    }
}