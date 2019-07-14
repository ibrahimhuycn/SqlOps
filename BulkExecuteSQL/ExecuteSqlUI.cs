using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkExecuteSQL
{
    public partial class ExecuteSqlUI : Form
    {
        public ExecuteSqlUI()
        {
            InitializeComponent();
        }

        public string FilePath { get => FilePath; set => FilePath = value; }

        private void ButtonSelectFile_Click(object sender, EventArgs e)
        {
            var Path = GetFilePath();
            if ( Path != "" )
            {
                FilePath = Path;
                Debug.WriteLine("Complete file path: " + FilePath);
            }
            else
            {
                Debug.WriteLine("Complete file path: " + FilePath);
            }
        }

        private string GetFilePath()
        {
            string Path="";
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Open an SQL File",
                Filter = "SQL Files (*.sql) | *.sql "
            };

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Path = ofd.FileName;
            }

            return Path;
        }
    }
}
