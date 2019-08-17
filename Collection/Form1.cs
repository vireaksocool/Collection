using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;// add using System for Collection
namespace Collection
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

        private void btnarraylist_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add('A');
            al.Add(7.8);
            al.Add("Hello");
            string[] name = { "Dara", "Nita", "Sok" };
            //string[] name = { "Dara", "Nita", "Sok" };
            //string[] name = { "Dara", "Nita", "Sok" };
            //string[] name = { "Dara", "Nita", "Sok" };
            //string[] name = { "Dara", "Nita", "Sok" };
            al.Add(name);
            MessageBox.Show(al[1].ToString());
            al.RemoveAt(1);//
            al.Remove(7.8);
            al.RemoveRange(index: 2, count: 2);
            al.Insert(index: 0, value: "Sok San");
            if (!al.Contains("hello"))
            {
                MessageBox.Show("\"hello\"is not found");
            }
            string ms = string.Empty;// 
            for(int i = 0; i < al.Count; i++)
            {
                ms += $"{al[i]}\n";
            }
            MessageBox.Show(ms);

            string ms1 = string.Empty;
            foreach(var item in al)
            {
                ms1 += $"{item}\n";
            }
            MessageBox.Show(ms1);
        }

        private void btnqueue_Click(object sender, EventArgs e)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            MessageBox.Show(q.Dequeue().ToString());
            MessageBox.Show(q.Dequeue().ToString());
            MessageBox.Show($"Cout = {q.Count}");
            string ms = string.Empty;
            foreach(var item in q)
            {
                ms += $"{item}\n";
            }
            string ms1 = string.Empty;
            while(q.Count > 0)
            {
                ms1 += $"{q.Dequeue()}\n";
            }
        }

        private void btnstack_Click(object sender, EventArgs e)
        {
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            MessageBox.Show(s.Pop().ToString());
            MessageBox.Show(s.Pop().ToString());
            MessageBox.Show($"Count = {s.Count}");
            string ms = string.Empty;
            foreach(var item in s)
            {
                ms += $"{item}\n";
            }
            MessageBox.Show(ms);
            string ms1 = string.Empty;// string ms1 = string.Empty;
            while(s.Count > 0)
            {
                ms1 += $"{s.Pop()}\n";
            }
        }

        private void btnhashtable_Click(object sender, EventArgs e)
        {
            Hashtable h = new Hashtable();
            h.Add("a", "apple"); // KEy  Value
            h.Add("b", "Book");
            h.Add("c", "Cat");
            h.Add("d", "Dog");
            if(h.Contains("a"))
                MessageBox.Show(h["a"].ToString());

            string ms = string.Empty;
            foreach(var key in h.Keys) // (var item in h.key) h.key ker loop tv kan ta key
            {
                ms += $"Key : {key}, Value : {h[key]}\n";
            }
            MessageBox.Show(ms);
            if (h.Contains("c"))
                h.Remove("c");
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            List<string> phone = new List<string>();
            phone.Add("011 11 11 11");
            phone.Add("097 33 11 33");
            phone.Add("094 88 00 88");
            phone.Add("012 45 67 89");
            phone.Add("015 55 55 55");

            string[] a = { "010 99 88 34", "070 70 70 70" };
            phone.AddRange(a);

            phone.Insert(index: 1, item: "087 87 87 87");

            if (phone.Contains("011 11 11 11"))
                phone.Remove("011 11 11 11");

            phone.RemoveAt(0);// index

            string mn = string.Empty;
            foreach(string item in phone)
            {
                mn += $"{item}\n";
            }
            MessageBox.Show(mn);
            mn = string.Empty;
            for(int i = 0; i < phone.Count; i++)
            {
                mn += $"{phone[i]}\n";
            }
            MessageBox.Show(mn);
        }

        private void btndictionary_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("One", 1);// Key Value
            d.Add("Two", 2);
            d.Add("Three", 3);
            d.Add("Four", 4);
            if (d.ContainsKey("two"))
                d.Remove("two");

            string ms = string.Empty;
            foreach(KeyValuePair<string, int> item in d) //KeyValuePair = 
            {
                ms += $"Key : {item.Key}, Value : {item.Value}";
            }
            MessageBox.Show(ms);
        }
    }
}
