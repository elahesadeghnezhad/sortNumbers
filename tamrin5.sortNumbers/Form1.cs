using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamrin5.sortNumbers
{
    public partial class Form1 : Form
    {
        string fn; //name and path of file
        Boolean saveflag; //save check
        int lines; //the number of lines
        public Form1()
        {
            InitializeComponent();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fn == null)
            {
                DialogResult x;
                saveFileDialog1.DefaultExt = "txt";
                x = saveFileDialog1.ShowDialog();
                if (x == DialogResult.Cancel)
                    return;
                fn = saveFileDialog1.FileName;
            }
            System.IO.File.WriteAllText(fn, txtnumbers.Text);
            saveflag = true;
            this.Text = fn;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveflag != true)
            {
                DialogResult r;
                r = MessageBox.Show("Do you want to save?", "save", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                    saveToolStripMenuItem_Click(null, null);
            }
            txtnumbers.Text = "";
            txtresult.Text = "";
            this.Name = "Sorting";
            saveflag = true;
            fn = null;
            rdoasc.Checked = rdodesc.Checked = false;
        }

        private void txtnumbers_TextChanged(object sender, EventArgs e)
        {
            saveflag = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            saveflag = false;
            MessageBox.Show("separate the numbers with enter", "guide");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
            openFileDialog1.Filter = "text file|*txt|document file|*.doc|allfile|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            fn = openFileDialog1.FileName;
            txtnumbers.Text = System.IO.File.ReadAllText(fn);
            saveflag = true;
            this.Text = fn;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fn = null;
            saveToolStripMenuItem_Click(null, null);
        }
        /// <summary>
        /// Gets the number of each line and puts it in an array
        /// </summary>
        /// <param name="s">the text that goes to array</param>
        private void get(string s)
        {
            lines = Convert.ToInt32(txtnumbers.Lines.Count());
            int[] a = new int[lines];
            int i = 0;
            int j = 0;
            int k = 0;
            while (j < lines)
            {
                txtnumbers.SelectionStart = k;
                i = txtnumbers.Text.IndexOf("\r\n", txtnumbers.GetFirstCharIndexFromLine(j));
               
                if (i != -1)
                {
                    txtnumbers.SelectionLength = i - k;
                    a[j] = Convert.ToInt32(txtnumbers.SelectedText);
                    k = i;
                }
                j++;   
            }
            txtnumbers.SelectionStart = k;
            txtnumbers.SelectionLength = k - i;
            a[lines-1] = Convert.ToInt32(txtnumbers.SelectedText);
            sort(a, lines);
            print(a, rdoasc.Checked);
        }
        private void rdoasc_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            get(txtnumbers.Text);
        }
        /// <summary>
        /// sort the arry
        /// </summary>
        /// <param name="a">arry</param>
        /// <param name="lines">array length</param>
        private void sort(int[] a, int lines)
        {
            for (int e = 0; e < lines - 1; e++)
            {
                for (int k = 0; k < lines - 1; k++)
                {
                    if (a[k] > a[k + 1])
                    {
                        int t = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = t;
                    }
                }
            }
        }
        /// <summary>
        /// print an arry
        /// </summary>
        /// <param name="a">arry</param>
        /// <param name="upordown">direction of array</param>
        private void print(int[] a, Boolean upordown)
        {
            if (upordown == true)
            {
             for (int q=0; q <lines; q++)
                {
                    txtresult.Text += a[q] + "\r\n";
                }
            }
            else
            {
                for (int q=lines-1; q>=0; q--)
                {
                    txtresult.Text += a[q] + "\r\n";
                }
            }
        }

        private void rdodesc_Click(object sender, EventArgs e)
        {
            txtresult.Text = "";
            get(txtnumbers.Text);
        }
    }
}
