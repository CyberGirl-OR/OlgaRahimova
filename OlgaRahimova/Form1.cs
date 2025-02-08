using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlgaRahimova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Проверяем состояние CheckBox
            if (checkBox1.Checked) // Если CheckBox включен
            {
                pictureBox2.Visible = true; // Показываем PictureBox с гифкой
            }
            else // Если CheckBox выключен
            {
                pictureBox2.Visible = false; // Скрываем PictureBox
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
