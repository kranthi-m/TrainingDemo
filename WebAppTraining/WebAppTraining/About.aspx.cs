using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTraining
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "Hello " + txtName.Text;
            Session["UName"] = txtName.Text; // storing txt val in sesssion 
            Response.Redirect("Contact.aspx"); // moving to contact page
        }
    }
}