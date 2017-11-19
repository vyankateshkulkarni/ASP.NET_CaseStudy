using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingApplication.BusinessEntity
{
    public class StudentInfo
    {
        private int studId;

        public int StudId
        {
            get { return studId; }
            set { studId = value; }
        }
        private string studName;

        public string StudName
        {
            get { return studName; }
            set { studName = value; }
        }
        private int studMarks;

        public int StudMarks
        {
            get { return studMarks; }
            set { studMarks = value; }
        }
        private int courseId;

        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        
        
        
        
    }
}