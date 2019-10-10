﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Web_API_Demo
{
    /// <summary>
    /// Summary description for WebService_Demo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService_Demo : System.Web.Services.WebService
    {

        [WebMethod]
        public int Sumation_Test(int x, int y)
        {
            return x + y;
        }

        // This for get data from database
        [WebMethod]
        public int Get(int x, int y)
        {
            return x + y;
        }


    }
}