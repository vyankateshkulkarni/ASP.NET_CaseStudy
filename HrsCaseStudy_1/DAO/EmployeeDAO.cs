using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HrsCaseStudy_1.Business_Entity;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;
namespace HrsCaseStudy_1.DAO
{
    public class EmployeeDAO
    {
        string constr = "Data Source=.;Initial Catalog=CASESTUDY;Integrated Security=True";
        public bool createEmployee(Employee empInfo)
        {
            SqlParameter[] param = new SqlParameter[29];
            param[0] = new SqlParameter("@FirstName",SqlDbType.VarChar);
            param[0].Value = empInfo.FirstName;
            param[1] = new SqlParameter("@MiddleName", SqlDbType.VarChar);
            param[1].Value = empInfo.MiddleName;
            param[2] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[2].Value = empInfo.@LastName;
            param[3] = new SqlParameter("@BirthDate", SqlDbType.DateTime);
            param[3].Value = empInfo.BirthDate;
            
            param[4] = new SqlParameter("@Gender", SqlDbType.VarChar);
            param[4].Value = empInfo.Gender;
            param[5] = new SqlParameter("@CivilStatus", SqlDbType.Int);
            param[5].Value = empInfo.CivilStatus;
            param[6] = new SqlParameter("@SSNo", SqlDbType.VarChar);
            param[6].Value = empInfo.SsNo;
            param[7] = new SqlParameter("@TinNo", SqlDbType.VarChar);
            param[7].Value = empInfo.TinNo;
            param[8] = new SqlParameter("@Citizenship", SqlDbType.VarChar);
            param[8].Value = empInfo.Citizenship;
            param[9] = new SqlParameter("@MobileNo", SqlDbType.VarChar);
            param[9].Value = empInfo.MobileNo;
            param[10] = new SqlParameter("@HomePhoneNo", SqlDbType.VarChar);
            param[10].Value = empInfo.HomePhoneNo;
            param[11] = new SqlParameter("@Street1", SqlDbType.VarChar);
            param[11].Value = empInfo.Street1;
            param[12] = new SqlParameter("@Street2", SqlDbType.VarChar);
            param[12].Value = empInfo.Street2;
            param[13] = new SqlParameter("@City", SqlDbType.VarChar);
            param[13].Value = empInfo.City;
            param[14] = new SqlParameter("@State", SqlDbType.VarChar);
            param[14].Value = empInfo.State;
            param[15] = new SqlParameter("@Country", SqlDbType.VarChar);
            param[15].Value = empInfo.Country;
            param[16] = new SqlParameter("@EducBackGround", SqlDbType.VarChar);
            param[16].Value = empInfo.EducBackground;
            param[17] = new SqlParameter("@Recognitions", SqlDbType.VarChar);
            param[17].Value = empInfo.Recognitions;
            param[18] = new SqlParameter("@Email", SqlDbType.VarChar);
            param[18].Value = empInfo.AccObj.Email;
            param[19] = new SqlParameter("@EnterpriseId", SqlDbType.VarChar);
            param[19].Value = empInfo.AccObj.EnterpriseId;
            param[20] = new SqlParameter("@Level", SqlDbType.Int);
            param[20].Value = empInfo.AccObj.Level;
            param[21] = new SqlParameter("@LMU", SqlDbType.VarChar);
            param[21].Value = empInfo.AccObj.Lmu;
            param[22] = new SqlParameter("@GMU", SqlDbType.VarChar);
            param[22].Value = empInfo.AccObj.Gmu;
            param[23] = new SqlParameter("@DateHired", SqlDbType.DateTime);
            param[23].Value = empInfo.AccObj.Gmu;
            param[24] = new SqlParameter("@WorkGroup", SqlDbType.VarChar);
            param[24].Value = empInfo.AccObj.WorkGroup;
            param[25] = new SqlParameter("@Specialty", SqlDbType.Int);
            param[25].Value = empInfo.AccObj.Speciality;
            param[26] = new SqlParameter("@ServiceLine", SqlDbType.VarChar);
            param[26].Value = empInfo.AccObj.ServiceLine;
            param[27] = new SqlParameter("@Status", SqlDbType.VarChar);
            param[27].Value = empInfo.AccObj.Status;
            param[28] = new SqlParameter("@CreatedBy", SqlDbType.Int);
            param[28].Value = empInfo.AccObj.CreatedBy ;
            int rowsAffected = SqlHelper.ExecuteNonQuery(constr, CommandType.StoredProcedure, "spCreateEmployee", param);

            if (rowsAffected == 1)
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