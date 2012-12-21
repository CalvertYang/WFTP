﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataProvider;
using WFTP.Helper;

namespace WFTP.Pages
{
    /// <summary>
    /// Manage.xaml 的互動邏輯
    /// </summary>
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
        }

        // 如果該欄位不須更新就留 "" 或 -1  ID為null是新增 有ID就是update
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            CLv1Classify.InsertOrUpdate(null, "PPP", "PPP");
        }

        private void btnLv2_Click(object sender, RoutedEventArgs e)
        {
            CLv2Customer.InsertOrUpdate(null, "TESTCompany", "TSTC", 1);
            CLv2Customer.InsertOrUpdate(null, "TTTTT", "TTTTT", CLv1Classify.GetClassifyIdByName("PP"));
        }

        private void btnLv3_Click(object sender, RoutedEventArgs e)
        {
            CLv3CustomerBranch.InsertOrUpdate(null, "Taiwan", "台灣TEST", 6);
        }

        private void btnLv4_Click(object sender, RoutedEventArgs e)
        {
            CLv4Line.InsertOrUpdate(null, "3", "三號TEST", 191);
        }

        private void btnCategory_Click(object sender, RoutedEventArgs e)
        {
            CFileCategory.InsertOrUpdate(null, "TESTFileCategory", "檔案分類");
        }

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            CFile.InsertOrUpdate(null,2,2,"OriginFileName","RenameFileName",false,GlobalHelper.LoginUserID,"hash example");

        }

        private void btnDeleteLv1_Click(object sender, RoutedEventArgs e)
        {
            CLv1Classify.Delete(24, GlobalHelper.LoginUserID);
        }

        private void btnDeleteLv2_Click(object sender, RoutedEventArgs e)
        {
            CLv2Customer.Delete(207, GlobalHelper.LoginUserID);
        }

        private void btnDeleteCLv3_Click(object sender, RoutedEventArgs e)
        {
             CLv3CustomerBranch.Delete(191, GlobalHelper.LoginUserID);
        }

        private void btnDeleteLv4_Click(object sender, RoutedEventArgs e)
        {
            CLv4Line.Delete(1, GlobalHelper.LoginUserID);
        }

        private void btnLv5File_Click(object sender, RoutedEventArgs e)
        {
            CFileCategory.Delete(13, GlobalHelper.LoginUserID);
        }

        private void btnDeleteFile_Click(object sender, RoutedEventArgs e)
        {
            CFile.Delete(100, GlobalHelper.LoginUserID);
        }


    }
}
