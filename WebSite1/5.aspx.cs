using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class _5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MYsqlcommand2 y = new MYsqlcommand2();
        MySqlDataReader dr = y.prname();
        while (dr.Read())
        {
            DropDownList1.Items.Add(dr.GetString(0));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MYsqlcommand2 com = new MYsqlcommand2();
        MySqlConnection c = new MySqlConnection();
        c.ConnectionString = com.constr();
        c.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = c;
        cmd.CommandText = "SELECT * FROM classicmodels.products where productName='"+DropDownList1.Text+"';";
        MySqlDataAdapter sqlA = new MySqlDataAdapter(cmd.CommandText, c);
        DataTable ds = new DataTable();
        sqlA.Fill(ds);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("6.aspx");
    }
}