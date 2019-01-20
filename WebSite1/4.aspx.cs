using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class _4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MYsqlcommand2 y = new MYsqlcommand2();
        MySqlDataAdapter ad= y.grid();
        DataTable ds = new DataTable();
        ad.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("5.aspx");
    }
}