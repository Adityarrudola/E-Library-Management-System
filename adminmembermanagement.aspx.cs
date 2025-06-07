using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class adminmembermanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //                           show details button
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            showMemberDetails();
        }

        void showMemberDetails()
        {
            if (TextBox1.Text.Equals(""))
            {
                Response.Write("<script>alert('Member Id can not be blank');</script>");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("select * from member_master_tbl where " +
                        "member_id='" + TextBox1.Text.Trim() + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count >= 1)
                    {
                        TextBox2.Text = dt.Rows[0][0].ToString();
                        TextBox7.Text = dt.Rows[0][10].ToString();
                        TextBox8.Text = dt.Rows[0][1].ToString();
                        TextBox3.Text = dt.Rows[0][2].ToString();
                        TextBox4.Text = dt.Rows[0][3].ToString();
                        TextBox9.Text = dt.Rows[0][4].ToString();
                        TextBox10.Text = dt.Rows[0][5].ToString();
                        TextBox11.Text = dt.Rows[0][6].ToString();
                        TextBox6.Text = dt.Rows[0][7].ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('no member exist with this id')</script>");
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
            }
        }
        //                      status active button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateStatus("active");
        }
        //                      status pending button
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateStatus("pending");
        }
        //                      status de active button
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateStatus("deactive");
        }
        void updateStatus(string status)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("update member_master_tbl set account_status='" + status + "' where member_id='" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("select * from member_master_tbl", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    TextBox7.Text = dt.Rows[0][10].ToString();
                }
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        //                          member delete button
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteMember();
        }
        void deleteMember()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE from member_master_tbl where " +
                    "member_id = '" + TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                clearForm();
                Response.Write("<script>alert('member deleted successfuly');</script>");
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
        }
    }
}