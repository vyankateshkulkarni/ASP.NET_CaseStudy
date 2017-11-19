using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingApplication.BusinessEntity;
using TestingApplication.Manager;
using TestingApplication.DAO;

namespace TestingApplication.Controller
{
    public class StudController
    {
        public StudController()
        {

        }
        public bool createStudent(int studentId,string studentName,int studentMarks)
        {
            StudentInfo sInfo = new StudentInfo();
            sInfo.StudId = studentId;
            sInfo.StudName = studentName;
            sInfo.StudMarks = studentMarks;

            ManagerClass mgr = new ManagerClass();
            return mgr.createStudent(sInfo);
        
        }
    }
}