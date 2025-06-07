using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class adminpublishermanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        //                          add button
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkPublisherExist())
            {
                Response.Write("<script>alert('Publisher already exist with this id')");
            }
            else
            {
                addPublisher();
            }
        }
        bool checkPublisherExist()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from publisher_master_tbl where " +
                "publisher_id='" + TextBox1.Text.Trim() + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void addPublisher()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into publisher_master_tbl " +
                "(publisher_id,publisher_name)values(@publisher_id,@publisher_name)", con);
            cmd.Parameters.AddWithValue("@publisher_id", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@publisher_name", TextBox2.Text.Trim());
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('publisher added succesfuly')</script>");
            clearForm();
            GridView1.DataBind();
        }
        //                          update button
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkPublisherExist())
            {
                updatePublisher();
            }
            else
            {
                Response.Write("<script>alert('publisher with this is doesnot exist')</script>");
            }
        }
        void updatePublisher()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("update publisher_master_tbl set " +
                "publisher_name = '" + TextBox2.Text.Trim() + "' where publisher_id='" + TextBox1.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('publisher updated successfuly');</script>");
            clearForm();
            GridView1.DataBind();
        }
        //                           delete button
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkPublisherExist())
            {
                deletePublisher();
            }
            else
            {
                Response.Write("<script>alert('publisher with this is doesnot exist')</script>");
            }
        }
        void deletePublisher()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delete from publisher_master_tbl where publisher_id='" + TextBox1.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('publisher deleted successfuly');</script>");
            clearForm();
            GridView1.DataBind();
        }
        //                            go button
        protected void Button1_Click(object sender, EventArgs e)
        {
            showDetails();
        }
        void showDetails()
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("select * from publisher_master_tbl where " +
                "publisher_id='" + TextBox1.Text.Trim() + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                TextBox2.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                Response.Write("<script>alert('invalid author id');</script>");
            }
            cmd.ExecuteNonQuery();
        }

        void clearForm()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}