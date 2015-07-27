using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DT.Models;
using System.Data;

namespace DT.ViewModels
{
    public class DongtanViewModels
    {
        private DataTable dtdongtan = new DataTable();

        public DataTable Dtdongtan
        {
            get { return dtdongtan; }
            set { dtdongtan = value; }
        }
    }
}