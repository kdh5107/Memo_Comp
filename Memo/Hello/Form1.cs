using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hello

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        string filename = "";

        private void Open_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            openFileDialog1.ShowDialog();

            filename = openFileDialog1.FileName;

            string Data=System.IO.File.ReadAllText(filename);

            tbContents.Text = Data;
        }

        private void Reset_Click_1(object sender, EventArgs e)
        {
            tbContents.Text = "";
        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            if (filename == "")
            {
                saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
                saveFileDialog1.ShowDialog();

                System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
            }
            else
            {
                System.IO.File.WriteAllText(filename, tbContents.Text);

                filename = saveFileDialog1.FileName;
            }
        }

        private void Save_dif_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든파일|*.*";
            saveFileDialog1.ShowDialog();

            System.IO.File.WriteAllText(saveFileDialog1.FileName, tbContents.Text);
        }

        private void autoLineChange_Click(object sender, EventArgs e)
        {
            tbContents.WordWrap = !tbContents.WordWrap;
        }

        private void Font_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            tbContents.Font = fontDialog1.Font;
        }

        private void End_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Status_Click_1(object sender, EventArgs e)
        {
            StatusStrip1.Visible = Status.Checked;
        }

        private void help_Click(object sender, EventArgs e)
        {
            info f = new info();
            f.Show();
        }
    }
}
