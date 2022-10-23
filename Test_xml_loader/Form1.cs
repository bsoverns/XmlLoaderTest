using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Timers;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Linq;

namespace Test_xml_loader
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string stockCode;
        
        private void btnLoadDataGrid_Click(object sender, EventArgs e)
        {
            try
            {
                string serverUrl = @"http://in.finance.yahoo.com/d/quotes.csv?s=FB" +
                    //"&f=sl1d1t1c1ohgvj1pp2owern&e=.csv"; //original line
                        //"&f=sl1d1t1c1ohgvj1pp2owerk1&e=.csv"; //original line
                        "&f=aa2a5bb2b3b4b6cc1c3c6c8dd1d2ee1e7e8e9f6gg1g3g4g5g6hii5jj1j3j4j5j6kk1k2k3k4k5ll1l2l3mm2m3m4m5m6m7m8nn4opp1p2p5p6qrr1r2r5r6r7ss1s7t1t6t7t8vv1v7ww1w4xy&e=.csv"; //original line

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(serverUrl);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                StreamReader reader = new StreamReader(response.GetResponseStream(),
                    Encoding.ASCII);

                string stockDataString = reader.ReadLine();
                //string[] stockDataContents = stockDataString.Split(',');

                string[] stockDataContents = stockDataString.Split(',');
                
                var items = from item in stockDataContents
                                        select item;

                foreach (string s in items)
                {
                    MessageBox.Show(s);
                }

                //for (int i = 0; i <= 1; i++)
                //{
                //    MessageBox.Show(stockDataContents[i].ToString());
                //}

                //[stockDataContents.Rows.Count, stockDataContents.Columns.Count];

                response.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("An Error Occurred\nException Message: " + ee.Message);
            }
        }
    }
}
