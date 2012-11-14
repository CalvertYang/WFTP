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
using MahApps.Metro.Controls;

namespace WFTP
{
    /// <summary>
    /// Main.xaml 的互動邏輯
    /// </summary>
    public partial class Query : UserControl, ISwitchable
    {
        public Query()
        {
            InitializeComponent();
            GetClassify();
        }

        private void GetClassify()
        {
            lvwClassify.Items.Clear();

            WFTPDbContext db = new WFTPDbContext();

            var lv1Classify = db.Lv1Classify;
            
            foreach (var classifyItem in lv1Classify)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Content = classifyItem.NickName;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(@"pack://application:,,,/WFTP;component/Icons/folder.ico");
                bitmap.EndInit();

                Image img = new Image();
                img.Width = 60;
                img.Height = 60;
                img.Source = bitmap;

                Tile tile = new Tile();
                tile.Title = classifyItem.NickName;
                tile.FontFamily = new FontFamily("Microsoft JhengHei");
                tile.Width = 120;
                tile.Height = 120;
                tile.Count = "?";
                tile.Margin = new Thickness(5, 5, 5, 5);
                tile.Content = img;

                lvwClassify.Items.Add(tile);
            }
        }

        #region ISwitchable Members

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
