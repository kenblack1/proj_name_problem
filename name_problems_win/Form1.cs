using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace name_problems_win
{
    public partial class frmNames : Form
    {
        List<string> listName;
        public frmNames()
        {
            InitializeComponent();
        }

        private void btnLoadNames_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName;
                filePath = filePath + "/data/names.txt";
                string contents = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(contents) == false)
                {
                    listName = contents.Split(',').ToList();
                    listName.Sort();
                    BindList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BindList()
        {
            if (listName == null || listName.Count() == 0)
            {
                MessageBox.Show("List is empty");
            }
            lvNames.Items.Clear();
            foreach (var x in listName)
            {
                var item = new ListViewItem(x);
                lvNames.Items.Add(x);
            }
        }

        private void btnCalculateScore_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
