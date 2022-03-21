using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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