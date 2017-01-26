using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ChatBots
{
    /// <summary>
    /// SOURCE CODE BY YUSRIL TAKEUCHI
    /// </summary>
    public partial class Form1 : Form
    {
        public string pesan;
        public Form1()
        {
            InitializeComponent();
        }
        public string[] input = new string[5];
        public string[] output = new string[5];
        public string pertanyaans;

        private void button1_Click(object sender, EventArgs e)
        {
            pertanyaans = pertanyaan.Text;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == null)
                {
                    if (output[i] == null)
                    {
                        input[i] = pertanyaan.Text;
                        output[i] = jawaban.Text;
                        MessageBox.Show("Menambahkan kata baru..." + "\n" + "Pertanyaan: " + input[i] + "\n" + "Jawaban: " + output[i], "New Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }
                    

                }
                else
                {
                    if (input[i].ToLower().Contains(pertanyaans.ToLower()))
                    {
                        output[i] = output[i] + " " + jawaban.Text;
                        MessageBox.Show("Menambahkan kata baru..." + "\n" + "Pertanyaan: " + input[i] + "\n" + "Jawaban: " + output[i], "New Word", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            pesan = kolomChat.Text;
            if (kolomChat.Text != string.Empty)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    
                    if (input[i] != null)
                    {
                        if (output[i] != null)
                        {
                            if (input[i].ToLower().Contains(pesan.ToLower()))
                            {
                                richChat.Items.Add("Kamu: " + kolomChat.Text);
                                kolomChat.Text = string.Empty;
                                richChat.Items.Add("Bot: " + output[i]);
                                break;
                            }
                        }

                    }
                    else
                    {
                        break;
                    }
                }



            }
        }
        private void kolomChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void kolomChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick();
            }
        }
    }
}
