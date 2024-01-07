﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OkulApp.DAL
{
    public class Helper :IDisposable
    {

        private SqlConnection cn= null;
        private SqlCommand cmd = null;

        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p=null) 
        {
            using(cn=new SqlConnection(cstr))
            {
                using (cmd=new SqlCommand(cmdtext, cn)) 
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        
        }

        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null)
        {
            cn = new SqlConnection(cstr);
            cmd = new SqlCommand(cmdtext, cn);
            if (p != null)
            {
               cmd.Parameters.AddRange(p);
            }
            cn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public void Dispose()
        {
           
        }
    }
}
