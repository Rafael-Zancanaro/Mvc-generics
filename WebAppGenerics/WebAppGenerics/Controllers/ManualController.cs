using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGenerics.Models;
using WebAppGenerics.Models.Repository;

namespace WebAppGenerics.Controllers
{
    public class ManualController : BaseController<Manual,ManualRepository>
    {
        public ManualController() : base(new ManualRepository())
        {

        }
    }
}