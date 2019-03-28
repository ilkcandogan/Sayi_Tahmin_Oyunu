﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int random;
        byte deneme = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            random = rnd.Next(0,11);
            button1.Enabled = true;
            textBox1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
            try
            {
                deneme++;
                if (deneme == 3)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    MessageBox.Show("deneme hakkınız bitti");
                }
                else
                {
                    int sayi = Convert.ToInt32(textBox1.Text);
                    if (sayi == random)
                    {
                        MessageBox.Show("Bildiniz. Lütfen oyunu yeniden başlatın");
                        button1.Enabled = false;
                        textBox1.Enabled = false;

                    }
                    else if (sayi < random)
                    {
                        MessageBox.Show("Arttır");
                    }
                    else
                    {
                        MessageBox.Show("Azalt");
                    }
                }

               


            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen sayı girin");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox1.Enabled = false;

        }
    }
}
