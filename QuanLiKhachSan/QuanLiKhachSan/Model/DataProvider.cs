﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan.Model
{
    public class DataProvider
    {
        private static DataProvider _ISCreated;
        public static DataProvider ISCreated
        {
            get
            {
                if (_ISCreated == null)
                    _ISCreated = new DataProvider();
                return _ISCreated;
            }
            set
            {
                _ISCreated = value;
            }
        }
        public QLKHACHSANEntities DB { get; set; }
        private DataProvider()
        {
            DB = new QLKHACHSANEntities();
        }
    }
}
