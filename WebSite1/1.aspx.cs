using System;
//using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


public partial class _1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MYsqlcommand2 y = new MYsqlcommand2();
        MySqlConnection c = new MySqlConnection();

        c.ConnectionString = y.constr();
        c.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = c;
        cmd.CommandText= "SELECT tax_percent FROM tax_db.tax_table where min_salary>='"+TextBox1.Text+"' or max_salary>='"+ TextBox1.Text + "' ;";
        MySqlDataReader Reader = cmd.ExecuteReader();
        Reader.Read();
        string str = Reader.GetString(0);
        double pay = (double.Parse(str)*0.01)*double.Parse(TextBox1.Text) ;
        Label1.Text = "need yo pay: " +pay+ "₪";
        c.Close();

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("2.aspx");
    }
}