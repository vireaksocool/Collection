using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Dictionary<string, Image> dictionary = new Dictionary<string, Image>();
        private void Form2_Load(object sender, EventArgs e)
        {
            string fruit_folder = $".\\friut";
            string[] friut_files = System.IO.Directory.GetFiles(fruit_folder);
            foreach(string fruit in friut_files)
            {
                string fruit_name = System.IO.Path.GetFileNameWithoutExtension(fruit);
                Image fruit_image = Image.FromFile(fruit);
                dictionary.Add(fruit_name, fruit_image);

                txtsearch.AutoCompleteCustomSource.Add(fruit_name);
                listBox1.Items.Add(fruit_name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fruit_name = listBox1.SelectedItem.ToString();
            pictureBox1.Image = dictionary[fruit_name];
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (dictionary.ContainsKey(txtsearch.Text.Trim()))
                pictureBox1.Image = dictionary[txtsearch.Text.Trim()];
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(KeyValuePair<string, Image> item in dictionary)
            {
                if (item.Key.ToLower().StartsWith(txtsearch.Text.Trim()))
                    listBox1.Items.Add(item.Key);
            }
            // var result = dictionary.Where(item => item.Key.Contains(txtsearch.Text.Trim())).Select(item=>item.Key);
            //listBox1.Items.AddRange(result.ToArray());
        }
    }
}
