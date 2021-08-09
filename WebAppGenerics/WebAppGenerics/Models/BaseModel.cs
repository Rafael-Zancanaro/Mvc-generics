using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppGenerics.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public int Produção { get; set; }
    }
}