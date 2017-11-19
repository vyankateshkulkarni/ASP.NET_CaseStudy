using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HrsCaseStudy_1.Business_Layer;
using HrsCaseStudy_1.Business_Entity;
using HrsCaseStudy_1.DAO;
using HrsCaseStudy_1.Manager;
using Microsoft.ApplicationBlocks.Data;

namespace HrsCaseStudy_1.Controller
{
    public class EmployeeController
    {

        public bool createEmployee(string empFirstName, string empMiddleName, string empLastName,
            DateTime empDateOfBirth, int empAge, string empGender,int empCivilStatus, string empCitizenship,
            string empReligion, string empSSNo, string empTinNo, string empEmail, string empMobileNo,
            string empHomePhoneNo, string empStreet1, string empStreet2, string empCity, string empState,
            string empZipCode, string empCountry, string enterpriseId, string level, string lmu, string gmu,
            DateTime dateHired, string workGroup, int specialty, string serviceLine, string status,
            string empProjectProfile, string empSkillProfile, string empEducationalAttainment,
            string empRecognitions, int empCreatedBy)
        {

            Employee eInfo = new Employee();
            eInfo.FirstName = empFirstName;
            eInfo.LastName = empLastName;
            eInfo.MiddleName = empMiddleName;
            eInfo.AccObj.CreatedBy = empCreatedBy;
            eInfo.AccObj.DateHired = dateHired;
           eInfo.AccObj.ServiceLine = serviceLine;
           eInfo.AccObj.Speciality = specialty;
          eInfo.AccObj.Status = status;
           eInfo.AccObj.WorkGroup = workGroup;
           eInfo.AccObj.Email = empEmail;
           eInfo.AccObj.EnterpriseId = enterpriseId;
           eInfo.AccObj.Gmu = gmu;
           eInfo.AccObj.Lmu = lmu;  
            eInfo.Age = empAge;
            eInfo.EducBackground = empEducationalAttainment;
            eInfo.Citizenship = empCitizenship;
            eInfo.City = empCity;
            eInfo.CivilStatus = empCivilStatus;
            eInfo.Country = empCountry;
            eInfo.BirthDate = empDateOfBirth;
            eInfo.FirstName = empFirstName;
            eInfo.Gender = empGender;
            eInfo.HomePhoneNo = empHomePhoneNo;
            eInfo.MobileNo = empMobileNo;
            eInfo.ProjectProfile = empProjectProfile;
            eInfo.Recognitions = empRecognitions;
            eInfo.Religion = empReligion;
            eInfo.SkillProfile = empSkillProfile;
            eInfo.SsNo = empSSNo;
            eInfo.State = empState;
            eInfo.Street1 = empStreet1;
            eInfo.Street2 = empStreet2;
            eInfo.TinNo = empTinNo;
            eInfo.ZipCode = empZipCode;
            ManagerClass mgr = new ManagerClass(); 
            return mgr.createEmployee(eInfo);

        }
    }
}