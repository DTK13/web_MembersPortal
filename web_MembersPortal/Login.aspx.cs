using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_MembersPortal
{

    public partial class Login : System.Web.UI.Page
    {
        private string username;
        private string password;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;

            if (txtUsername.Text == "DTK13" && txtPassword.Text == "RK34")
            {
                Response.Redirect("http://localhost:58891/UserPages/?" + txtUsername.Text);
            }

            else if (txtUsername.Text == "JMax23" && txtPassword.Text == "JM23")
            {
                Response.Redirect("http://localhost:58891/UserPages/?" + txtUsername.Text);
            }

            else if (txtUsername.Text == "EP432" && txtPassword.Text == "EP23")
            {
                Response.Redirect("http://localhost:58891/UserPages/?" + txtUsername.Text);
            }
            else
            {
               
                txtResponse.Visible = true;
                txtResponse.Text = "Please Enter Valid Credentials";
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:58891/Login");
        }
    }
}
