using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITMO.ASP.NET.MyApp.Models;
using System.Text;

namespace ITMO.ASP.NET.MyApp.Forms
{
    public partial class BestBadStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected string GetFiveBad()
        {
            StringBuilder html = new StringBuilder();
            ResultSelect studentSelect = new ResultSelect();
            int count = 0;

            List<ResultSelect> listStudent = studentSelect.GetResultSelect();
            
            foreach (var student in listStudent)
            {
                html.Append(String.Format("<li>{0} {1}</li>", student.Name, student.LastName));
                count += 1;
                if (count == 5) break;
            }
            return html.ToString();
        }
        protected string GetFiveBest()
        {
            StringBuilder html = new StringBuilder();
            ResultSelect studentSelect = new ResultSelect();
            int count = 0;

            List<ResultSelect> listStudent = studentSelect.GetResultSelect();
            listStudent.Reverse();

            foreach (var student in listStudent)
            {
                html.Append(String.Format("<li>{0} {1}</li>", student.Name, student.LastName));
                count += 1;
                if (count == 5) break;
            }

            return html.ToString();
        }
    }
}