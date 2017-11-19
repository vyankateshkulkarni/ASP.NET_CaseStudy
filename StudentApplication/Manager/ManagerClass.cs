using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingApplication.BusinessEntity;
using TestingApplication.BusinessLayer;

namespace TestingApplication.Manager
{
    public class ManagerClass
    {
        public ManagerClass()
        {

        }
        public bool createStudent(StudentInfo studInfo)
        {
            StudentBC sbc = new StudentBC();
            return sbc.createStudent(studInfo);
        }
    }
}