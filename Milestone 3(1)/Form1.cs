using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);

            listView1.Items.Add(lvi);

            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Green;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
           
            cmb_items.Items.Add("Sweets Item 1");
            cmb_items.Items.Add("Sweets Item 2");
            cmb_items.Items.Add("Sweets Item 3");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Green;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("Mix Item 1");
            cmb_items.Items.Add("Mix Item 2");
            cmb_items.Items.Add("Mix Item 3");





        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            


            if(cmb_items.SelectedItem.ToString() == "Sweets Item 1")
            { 
                txt_price.Text = "50"; 
            }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 2")
            {
                txt_price.Text = "100"; 
            }
            else if (cmb_items.SelectedItem.ToString() == "Sweets Item 3")
            {
                txt_price.Text = "150"; }
            else if (cmb_items.SelectedItem.ToString() == "Mix Item 2")
            { txt_price.Text = "200";
            }
            else if (cmb_items.SelectedItem.ToString() == "Mix Item 3")
            { 
                txt_price.Text = "250"; 
            }
            else if (cmb_items.SelectedItem.ToString() == "Mix Item 3")
            {
                txt_price.Text = "300";
            }
            else
            { 
                txt_price.Text = "0"; 
            }

            txt_total.Text = "";
            txt_qty.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {


                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            if(txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }
        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if(listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }
            }
        }
    }
}
