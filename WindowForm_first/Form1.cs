using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForm_first
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void dovrler ()
        {
               foreach(Control item in this.Controls)
                {
                if (checkClick==true) item.BackColor = Color.Red;
                else item.BackColor = Color.White;

            }
        }
        public void action ()
        {
            if (checkClick == true)
            {
                dovrler();

                checkClick = false;
            }
            else
            {
                dovrler();
                checkClick = true;
            }

        }


        bool checkClick = true;
        private void Button1_Click(object sender, EventArgs e)
        {

            action();
            }
        }
}
