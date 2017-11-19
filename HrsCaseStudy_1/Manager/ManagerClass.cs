using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HrsCaseStudy_1.Business_Entity;
using HrsCaseStudy_1.Business_Layer;

namespace HrsCaseStudy_1.Manager
{
    public class ManagerClass
    {
        public bool createEmployee(Employee empInfo)
        {
            EmployeeBC ebc = new EmployeeBC();
            return ebc.createEmployee(empInfo);

        }
    }
}