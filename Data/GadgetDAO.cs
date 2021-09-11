using BondGadgetCollection.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BondGadgetCollection.Data
{
    internal class GadgetDAO
    {
        internal List<GadgetModel> FetchAll()
        {
            List<GadgetModel> ReturnList = new List<GadgetModel>();

            string connectionString = @"Data Source=DESKTOP-1IIFCOO\SQLEXPRESS;Initial Catalog=BondGadget;Integrated Security=True";
            
            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                string query = "select * from dbo.gadget";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        GadgetModel gad = new GadgetModel();
                        gad.Id = reader.GetInt32(0);
                        gad.Name = reader.GetString(1);
                        gad.Description = reader.GetString(2);
                        gad.ApperasIn = reader.GetString(3);
                        gad.WithThisActor = reader.GetString(4);

                        ReturnList.Add(gad);
                    }
                }
            }

            return ReturnList;
        }

        internal GadgetModel FetchOne(int id)
        {
            string connectionString=@"Data Source=DESKTOP-1IIFCOO\SQLEXPRESS;Initial Catalog=BondGadget;Integrated Security=True";

            using(SqlConnection connection=new SqlConnection(connectionString))
            {
                string query1="select * from dbo.Gadget where Id=@id";
                SqlCommand command=new SqlCommand(query1,connection);
                command.Parameters.Add("@id",System.Data.SqlDbType.Int).Value=id;


                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                GadgetModel gad=new GadgetModel();

                if(reader.HasRows)
                {
                    reader.Read();

                    
                    gad.Id=reader.GetInt32(0);
                    gad.Name=reader.GetString(1);
                    gad.Description=reader.GetString(2);
                    gad.ApperasIn=reader.GetString(3);
                    gad.WithThisActor=reader.GetString(4);

                }
                return gad;
            }
        }
    }
}