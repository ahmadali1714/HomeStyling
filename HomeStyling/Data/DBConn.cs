﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace HomeStyling.Data
{
    public class DBConn
    {
        //string s = ConfigurationManager.AppSettings["DBConnection"].ToString();


        public SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["DBConnection"].ToString());


    }
}
