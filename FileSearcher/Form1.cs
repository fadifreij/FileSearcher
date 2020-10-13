using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSearcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = new List<string>();
            SearchManager sm = new FolderToProcess(result, txt_FolderName.Text, txt_wordToSearch.Text);

            sm.DoSearch();
            result = sm.GetResult();
            var sb = new StringBuilder();

            if (result.Count != 0)
            {
                foreach (var line in result)
                {
                    sb.Append(line + "\r\n");
                }
            }
            else
            {
                sb.Append("No match found !");
            }

           
            txt_ResutBox.Text = sb.ToString();
        }

       
    }
}
