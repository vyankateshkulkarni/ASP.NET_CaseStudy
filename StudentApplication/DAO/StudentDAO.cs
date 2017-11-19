using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingApplication.BusinessEntity;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;


namespace TestingApplication.DAO
{
    public class StudentDAO
    {
        public StudentDAO()
        {

        }
        //public StudentDAO(int studId)
        //{

        //}
        string constr = "Data Source=.;Initial Catalog=StudentDatabase;Integrated Security=True";
        public bool createStudent(StudentInfo studInfo)
        {
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@studId", SqlDbType.Int);
            param[0].Value = studInfo.StudId;
            param[1] = new SqlParameter("@studName", SqlDbType.VarChar);
            param[1].Value = studInfo.StudName;
            param[2] = new SqlParameter("@studMarks", SqlDbType.Int);
            param[2].Value = studInfo.StudMarks;
            int i = SqlHelper.ExecuteNonQuery(constr, CommandType.StoredProcedure, "insertStudent", param);
            if (i>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }      
    }
}