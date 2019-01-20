using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!IsPostBack)
        {
            createse();
            Random r = new Random();
              int a = r.Next(0, 100);
            creatran(a);
        }
       
    }
    protected void createse()
    {
        Session["cou"] = 0;
    }
    protected void creatran(int a)
    {
        Session["ran"] = a;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
       
        if (Session["ran"].ToString()==TextBox1.Text)
        {
            Label1.Text = "true";
            Label2.Text = Session["cou"].ToString();
        }
        else
        {
            Label1.Text = "false";
            Session["cou"] = (int)Session["cou"] + 1;
        }
          



    }

    protected void Button2_Click(object sender, EventArgs e)
    {
Response.Redirect("3.aspx");
    }
    
}