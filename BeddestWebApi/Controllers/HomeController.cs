﻿using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BeddestWebApi.Controllers
{
    [EnableCors("*", "*", "*")]
    public class HomeController : ApiController
    {
        [HttpGet]
        public string Index()
        {
            CtrlToDal.StartReceiving();
            return "qwer";
        }
    }
}
