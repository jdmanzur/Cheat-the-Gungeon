using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatEnterTheGungeon
{
    public partial class healfForm : Form
    {

        public static Mem m = new Mem();


        public healfForm(Mem mem)
        {
            InitializeComponent();
            m = mem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lifeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            
            if(lifeCheckBox.Checked)    
            {
              m.WriteMemory("base+00FAF7B0,c,1c,38,48,c,28,94", "float", "3.0");

            }
                        
        }
    }
}
