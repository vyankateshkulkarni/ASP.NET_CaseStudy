﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestingApplication.BusinessEntity;
using TestingApplication.Controller;
namespace TestingApplication.UI
{
    public partial class CreateStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Insert_Click(object sender, EventArgs e)
        {
            StudController sc = new StudController();
            sc.createStudent(Convert.ToInt32(txt_StudId.Text), txt_StudName.Text, Convert.ToInt32(txt_StudMarks.Text));
        }
    }
}