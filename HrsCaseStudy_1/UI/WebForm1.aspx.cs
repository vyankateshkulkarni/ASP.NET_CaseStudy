using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HrsCaseStudy_1.Business_Entity;
using HrsCaseStudy_1.Controller;
using Microsoft.ApplicationBlocks.Data;
namespace HrsCaseStudy_1.UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeController ec=new EmployeeController();
           ec.createEmployee(txt_firstName.Text, txt_middleName.Text, txt_lastName.Text,
            cal_birthDate.SelectedDate,Convert.ToInt32(txt_age),ddl_gender.Text,Convert.ToInt32(ddl_status), txt_citizenship.Text,
            txt_religion.Text, txt_sssNo.Text, TextBox7.Text, txt_emailAddr.Text, TextBox13.Text,
            txt_homeNo.Text, txt_street1.Text,txt_street2.Text , txt_city.Text, txt_state.Text,
            txt_zipCode.Text,txt_country.Text, txt_enterpriseId.Text, ddl_level.Text, txt_lmu.Text, txt_gmu.Text,
            cal_dateHired.SelectedDate, TextBox17.Text, Convert.ToInt32(ddl_speciality), txt_serviceLine.Text, txt_status.Text, txt_proProfile.Text
            , txt_skillProfile.Text, txt_eduBackground.Text,
            txt_certificate.Text,Convert.ToInt32(txt_createdBy.Text));

           Response.Redirect("Page.aspx");
            
        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox17_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

       
    }
}