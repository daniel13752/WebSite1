using System;
//using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Unit4.CollectionsLib;


public partial class _3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MYsqlcommand2 y = new MYsqlcommand2();
        y.newrowprline(TextBox1.Text, TextBox2.Text);
        TextBox1.Text = "";
        TextBox2.Text = "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("4.aspx");
    }
    
}