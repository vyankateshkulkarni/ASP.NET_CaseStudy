using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingApplication.BusinessEntity;
using TestingApplication.DAO;

namespace TestingApplication.BusinessLayer
{
    public class StudentBC
    {
        public StudentBC()
        {

        }
        public bool createStudent(StudentInfo studInfo)
        {
            StudentDAO sd = new StudentDAO();
            return sd.createStudent(studInfo);
        }
    }
}