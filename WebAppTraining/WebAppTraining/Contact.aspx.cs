using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTraining
{
    public partial class Contact : Page
    { //Client Side -> Hidden, View State, QueryString , cookies and ControlState
        //Server Side -> Session and Application
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UName"] != null)
            {
                string Uname = Session["UName"].ToString();
                lblUser.Text = Uname;
                ViewState["UserName"] = Uname;
                hdnField.Value = Uname;
                Response.Cookies["myCookie"].Value = "Test Cookies";
                Application["WelcomeMsg"] = "Test Welcome";
            }
        }
    }
}