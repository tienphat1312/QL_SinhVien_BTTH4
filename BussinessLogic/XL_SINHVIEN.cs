﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BussinessLogic
{
    public class XL_SINHVIEN : XL_BANG
    {
        public XL_SINHVIEN() : base("SINHVIEN") { }
        public XL_SINHVIEN(string chuoiSQL) : base("SINHVIEN", chuoiSQL) { }
    }
}
