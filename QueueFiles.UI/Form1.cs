using QueueFiles.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueueFiles.MODEL;

namespace QueueFiles.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            MainManager.Instance.MyQueue.Push(new Item() { UserText = input.Text });
            input.Text = "";
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            Item item = null;

            item = MainManager.Instance.MyQueue.Pop();

            if(item != null)
            {
                output.Text = item.UserText;
            }
        }

        private void rndNum_Click(object sender, EventArgs e)
        {
            textBox1.Text =  MainManager.Instance.randomNum(Convert.ToInt32(input.Text), Convert.ToInt32(output.Text)).ToString();
            input.Text = "";
            output.Text = "";
        }
    }
}
