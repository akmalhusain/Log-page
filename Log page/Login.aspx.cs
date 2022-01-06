using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace Log_page
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=VMDESKTOP-X6232\\MSSQLSERVER01;Initial Catalog=akmal;Integrated Security=True");
        protected void btn1_Click(object sender, EventArgs e)
        {
           
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into akmal2 values('" + txtuser.Text + "','" + txtpass.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btn2_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("update akmal2 set username='" + txtuser.Text + "', pass='" + txtpass.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btn3_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("delete akmal2 where username='" + txtuser.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select username,pass from akmal2 where username='" + txtuser.Text + "' and pass='" + txtpass.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Response.Write("data match");
            }
            else
            {
                Response.Write("data not match");
            }
            con.Close();
        }
    }
}