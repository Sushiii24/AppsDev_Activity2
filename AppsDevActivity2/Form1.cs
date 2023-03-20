using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishList.Text;
        }

        private void sort_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void fill_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("Keyboard Piano");
            wishList.Items.Add("Electric Guitar");
            wishList.Items.Add("Acoustic Drums");
            wishList.Items.Add("Gaming PC");
            wishList.Items.Add("1 Million Dollars");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear(); 
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishList.Items.Count);
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
