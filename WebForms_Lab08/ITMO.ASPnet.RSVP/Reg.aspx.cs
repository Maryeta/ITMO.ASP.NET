﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASPnet.RSVP.Code;
using System.Data.Entity;

namespace ITMO.ASPnet.RSVP
{
    public partial class Reg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) 
            {
                Page.Validate(); 
                if (!Page.IsValid) 
                return;

                GuestResponse rsvp = new GuestResponse(name.Text, email.Text, phone.Text, CheckBoxYN.Checked);
                ResponseRepository.GetRepository().AddResponse(rsvp);

                if (CheckBoxYN.Checked)
                {
                    Report report1 = new Report(TextBoxTitle.Text, TextBoxTextAnnot.Text);
                    rsvp.Reports.Add(report1);
                    if (TextBoxTitle2.Text != "" || TextBoxTextAnnot2.Text != "")
                    {
                        Report report2 = new Report(TextBoxTitle2.Text, TextBoxTextAnnot2.Text);
                        rsvp.Reports.Add(report2);
                    }
                }
                SampleContext context = new SampleContext();
                context.GuestResponses.Add(rsvp);
                context.SaveChanges();
                //try
                //{

                //}
                //catch (Exception ex)
                //{
                //    Response.Redirect("Ошибка " + ex.Message);
                //}

                if (rsvp.WillAttend.HasValue && rsvp.WillAttend.Value) 
                {
                    Response.Redirect("html_answer\\seeyouthere.html");
                }
                else 
                {
                    Response.Redirect("html_answer\\sorryyoucantcome.html"); 
                }

            }
        }
    }
}