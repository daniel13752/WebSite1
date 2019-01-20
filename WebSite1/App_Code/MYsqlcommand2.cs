using System;
//using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Unit4.CollectionsLib;


public class MYsqlcommand2
{
    public MYsqlcommand2()
    {
       
    }
    public string constr()
    {
        string str = "server = localhost; user id = root; persistsecurityinfo = True; database = tax_db; password=josh17rog";
        return str;
    }

   public void newrowprline(string productLine,string textDescription)
    {
        MYsqlcommand2 com = new MYsqlcommand2();
        MySqlConnection c = new MySqlConnection();
        c.ConnectionString = com.constr();
        c.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = c;
        cmd.CommandText = "INSERT INTO `classicmodels`.`productlines` (`productLine`, `textDescription`) VALUES ('"+productLine+"', '"+ textDescription + "')";
        cmd.ExecuteReader();
    }
    public MySqlDataAdapter grid()
    {
        MYsqlcommand2 com = new MYsqlcommand2();
        MySqlConnection c = new MySqlConnection();
        c.ConnectionString = com.constr();
        c.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = c;
        cmd.CommandText = "SELECT customerName FROM classicmodels.customers;";
        MySqlDataAdapter sqlA = new MySqlDataAdapter(cmd.CommandText, c);
        return sqlA;
    }
    public MySqlDataReader prname()
    {
        MYsqlcommand2 com = new MYsqlcommand2();
        MySqlConnection c = new MySqlConnection();
        c.ConnectionString = com.constr();
        c.Open();
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = c;
        cmd.CommandText = "SELECT productName FROM classicmodels.products;";
        return cmd.ExecuteReader();
    }
}