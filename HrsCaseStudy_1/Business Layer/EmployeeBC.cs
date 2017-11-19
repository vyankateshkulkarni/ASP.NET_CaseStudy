using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HrsCaseStudy_1.Business_Entity;
using HrsCaseStudy_1.DAO;
namespace HrsCaseStudy_1.Business_Layer
{
    public class EmployeeBC
    {
        public bool createEmployee(Employee empInfo)
        {
            EmployeeDAO ed = new EmployeeDAO();
            return ed.createEmployee(empInfo);
        }
    }
}