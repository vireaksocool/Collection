using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Collection
{
    public partial class Form3 : Form
    {
        List<ArrayList> product = new List<ArrayList>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ////Generate auto Add id
            //string prefix = "PRO";
            //int length = 3;
            //int id;
            //if (product.Count == 0)
            //    id = 1;
            //else
            //{

            //    id = int.Parse(product.Last()[0].ToString().Replace(prefix, ""));// Replace ជំនួស
            //    id++;// Last()[0] return item​​ ចុងខាងក្រោយ 
            //}
            //string new_id = $"{prefix}{id.ToString().PadLeft(length, '0')}";// PadLeft បញ្ចូលទិន្នន័យនៅខាងឆ្វេង
            //txtid.Text = new_id;
            txtid.Text = GenerateNewAutoID("PRO", 3);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ArrayList product_data = new ArrayList();
            product_data.Add(txtid.Text.Trim());
            product_data.Add(txtname.Text.Trim());
            product_data.Add(int.Parse(txtqty.Text.Trim()));
            product_data.Add(double.Parse(txtprice.Text.Trim()));
            product.Add(product_data);
            foreach(Control item in this.Controls)
            {
                switch (item)
                {
                    case TextBox txt:
                        txt.Clear();
                        break;
                }
            }
            txtname.Focus();

            //Generate auto Add id
            //string prefix = "PRO";
            //int length = 3;
            //int id;
            //if (product.Count == 0)
            //    id = 1;
            //else
            //{

            //    id = int.Parse(product.Last()[0].ToString().Replace(prefix, ""));// Replace ជំនួស
            //    id++;// Last()[0] return item​​ ចុងខាងក្រោយ 
            //}
            //string new_id = $"{prefix}{id.ToString().PadLeft(length, '0')}";// PadLeft បញ្ចូលទិន្នន័យនៅខាងឆ្វេង
            //txtid.Text = new_id;
            txtid.Text = GenerateNewAutoID("PRO", 3);
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (ArrayList items in product)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = items[0].ToString();
                listItem.SubItems.Add(items[1].ToString());
                listItem.SubItems.Add(items[2].ToString());
                listItem.SubItems.Add(items[3].ToString());
                listItem.SubItems.Add(((int)items[2] * (double)items[3]).ToString());

                listView1.Items.Add(listItem);
            }
        }
        string GenerateNewAutoID(string prefix, int length)
        {
            int id;
            if (product.Count == 0)
                id = 1;
            else
            {

                id = int.Parse(product.Last()[0].ToString().Replace(prefix, ""));// Replace ជំនួស
                id++;// Last()[0] return item​​ ចុងខាងក្រោយ 
            }
            string new_id = $"{prefix}{id.ToString().PadLeft(length, '0')}";// PadLeft បញ្ចូលទិន្នន័យនៅខាងឆ្វេង
            return new_id;
        }
    }
}
