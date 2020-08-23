﻿using QuanLiKhachSan.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuanLiKhachSan.View
{
    /// <summary>
    /// Interaction logic for LeTan_ChiTietHoaDon.xaml
    /// </summary>
    public partial class LeTan_ChiTietHoaDon : Window
    {
        public LeTan_ChiTietHoaDon()
        {
            InitializeComponent();
        }
        public LeTan_ChiTietHoaDon(int maHD)
        {
            InitializeComponent();
            this.DataContext = new LeTanChiTietHoaDonViewModel(maHD);
            ((LeTanChiTietHoaDonViewModel)DataContext).MaHoaDon = maHD;

        }
    }

}
