using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex_polymorfism
{
    public partial class rbCreate : Form
    {
        public rbCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            A obj;
            if (rbnA.Checked)
            {
                obj = new A();
            }
            else
            {
                obj = new B();
            }

            if (obj is B)
            {
                B bobj = (obj as B);
                textBox1.Text = bobj.Description();
            }
            else
            {
                textBox1.Text = obj.Description();
            }
        }
    }
}
