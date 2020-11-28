using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace CheatEnterTheGungeon
{
    public partial class moneyForm : Form
    {

        public static Mem m = new Mem();

        public moneyForm(Mem mem)
        {
            InitializeComponent();
            m = mem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (moneyTextBox.Text != " ")
                m.WriteMemory("base+00FAF7B0,c,1c,38,40,18,f8,14", "int", moneyTextBox.Text);

            moneyTextBox.Text = " ";
        }
    }
}
