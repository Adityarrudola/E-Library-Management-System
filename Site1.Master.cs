using System;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                //if (Session["role"] != null && Session["role"].ToString() == "")
                if (Session["role"] != null && Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;       //user login button
                    LinkButton2.Visible = true;       //signup button

                    LinkButton3.Visible = false;      //logout button 
                    LinkButton7.Visible = false;      //hello user

                    LinkButton6.Visible = true;       //admin login
                    LinkButton11.Visible = false;     //author management 
                    LinkButton12.Visible = false;     //publisher management
                    LinkButton8.Visible = false;      //book inventory 
                    LinkButton9.Visible = false;      //book issuing
                    LinkButton10.Visible = false;     //member management
                }
                else if (Session["role"] != null && Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;       //user login button
                    LinkButton2.Visible = false;       //signup button

                    LinkButton3.Visible = true;      //logout button 
                    LinkButton7.Visible = true;      //hello user
                    LinkButton7.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = true;       //admin login
                    LinkButton11.Visible = false;     //author management 
                    LinkButton12.Visible = false;     //publisher management
                    LinkButton8.Visible = false;      //book inventory 
                    LinkButton9.Visible = false;      //book issuing
                    LinkButton10.Visible = false;     //member management
                }
                else if (Session["role"] != null && Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;       //user login button
                    LinkButton2.Visible = false;       //signup button

                    LinkButton3.Visible = true;      //logout button 
                    LinkButton7.Visible = true;      //hello user
                    LinkButton7.Text = "Hello " + Session["username"].ToString();

                    LinkButton6.Visible = false;       //admin login
                    LinkButton11.Visible = true;     //author management 
                    LinkButton12.Visible = true;     //publisher management
                    LinkButton8.Visible = true;      //book inventory 
                    LinkButton9.Visible = true;      //book issuing
                    LinkButton10.Visible = true;     //member management
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbooks.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["full_name"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true;       //user login button
            LinkButton2.Visible = true;       //signup button

            LinkButton3.Visible = false;      //logout button 
            LinkButton7.Visible = false;      //hello user

            LinkButton6.Visible = true;       //admin login
            LinkButton11.Visible = false;     //author management 
            LinkButton12.Visible = false;     //publisher management
            LinkButton8.Visible = false;      //book inventory 
            LinkButton9.Visible = false;      //book issuing
            LinkButton10.Visible = false;     //member management

            Response.Redirect("homepage.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userprofile.aspx");
        }
    }
}