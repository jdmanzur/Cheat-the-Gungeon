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
    public partial class blanksForm : Form
    {
        public static Mem m = new Mem();

        public blanksForm(Mem mem)
        {
            InitializeComponent();
            m = mem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBlanks_Click(object sender, EventArgs e)
        {
            if (blanksTextBox.Text != " ")
                m.WriteMemory("base+00FB95AC,24,10,4,20,14,48,294", "int", blanksTextBox.Text);

            blanksTextBox.Text = " ";
        }
    }
}
