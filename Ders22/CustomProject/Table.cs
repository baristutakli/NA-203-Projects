﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{

    // Table 'ı  attribute olrak tanımladık
    public class Table:Attribute
    {
        public string TableName { get; set; }
        public string PrimaryColumn { get; set; }

    }
}