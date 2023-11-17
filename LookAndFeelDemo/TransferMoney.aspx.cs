using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace LookAndFeelDemo
{
    public partial class TransferMoney : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = Session["custid"].ToString();
        }

        protected void btntransfer_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection("server=Sulakshana\\sqlexpress;database=SomeBank;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("[dbo].[sp_TransferMoney]", cn);
            cn.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_custidFrom", Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@p_custidTo",Convert.ToInt32(txtToAccountNo.Text));
            cmd.Parameters.AddWithValue("@p_amt", Convert.ToDouble(txtamount.Text));
           
               

            cmd.ExecuteNonQuery();


            Response.Write("<script>alert('transaction completed sucessfully...');</script>");
            cn.Close();
        }
    }
}