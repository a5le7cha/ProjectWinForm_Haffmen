using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string text = null;
        StringBuilder haffCode = new StringBuilder();
        Dictionary<char, string> codes;
        Dictionary<char, int> dict;
        public Form1()
        {
            InitializeComponent();
        }

        private void ChoseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            if (dig.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(dig.FileName))
                {
                    text = sr.ReadToEnd();
                }
                textBox1.Text = text;
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

        }

        private void DictBtn_Click(object sender, EventArgs e)
        {
            if (text == null)
            {
                MessageBox.Show("Choose the text,please");
            }
            else
            {
                dict = new Dictionary<char, int>();
                foreach (char c in text)
                {
                    if (!dict.ContainsKey(c))
                    {
                        dict.Add(c, 1);
                    }
                    else
                    {
                        dict[c]++;
                    }
                }
                textBox1.Text = "";                
                foreach (KeyValuePair<char, int> pair in dict)
                {
                    textBox1.Text += '"' + pair.Key.ToString() + '"' + " - " + pair.Value.ToString() + '\r' + '\n';
                }
            }

        }

        private void CodeBtn_Click(object sender, EventArgs e)
        {
            if (text == null)
            {
                MessageBox.Show("Choose the text,please");
            }
            else
            {
                var frequencies = new Dictionary<char, int>();
                frequencies = dict;

                var tree = new HuffmanTree(dict);
                codes = tree.GetCodes();

                textBox1.Text = "";
                foreach (KeyValuePair<char, string> pair in codes)
                {
                    textBox1.Text += '"' + pair.Key.ToString() + '"' + " - " + pair.Value + '\r'+'\n';
                }
            }
        }
        public class HuffmanNode
        {
            public char Symbol { get; set; }
            public int Frequency { get; set; }
            public HuffmanNode Left { get; set; }
            public HuffmanNode Right { get; set; }
        }

        public class HuffmanTree
        {
            private HuffmanNode root;

            public HuffmanTree(Dictionary<char, int> frequencies)
            {
                var nodes = new List<HuffmanNode>();
                foreach (var kvp in frequencies)
                {
                    nodes.Add(new HuffmanNode { Symbol = kvp.Key, Frequency = kvp.Value });
                }

                while (nodes.Count > 1)
                {
                    nodes.Sort((x, y) => x.Frequency.CompareTo(y.Frequency));

                    var left = nodes[0];
                    var right = nodes[1];
                    var parent = new HuffmanNode { Frequency = left.Frequency + right.Frequency, Left = left, Right = right };

                    nodes.Remove(left);
                    nodes.Remove(right);
                    nodes.Add(parent);
                }

                root = nodes[0];
            }

            public Dictionary<char, string> GetCodes()
            {
                var codes = new Dictionary<char, string>();
                Transition(root, "", codes);
                return codes;
            }

            private void Transition(HuffmanNode node, string code, Dictionary<char, string> codes)
            {
                if (node == null)
                {
                    return;
                }

                if (node.Symbol != '\0')
                {
                    codes[node.Symbol] = code;
                }

                Transition(node.Left, code + "0", codes);
                Transition(node.Right, code + "1", codes);
            }
        }

        private void DecodeBtn_Click(object sender, EventArgs e)
        {

        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("code.txt"))
                foreach (var item in text)
                {
                    haffCode.Append(codes[item]);
                    sw.Write(codes[item]);
                }
            DecodeBtn.BackColor = Color.Green;
        }
    }
}
