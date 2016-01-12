using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PackWarsCounter_Hearthstone_
{
    
    public partial class Form1 : Form
    {
        //global variables
        public static int commonVal = 0;
        public static int commonMods { get { return commonVal; } set { commonVal = value; } }

        public static int rareVal = 1;
        public static int rareMods { get { return rareVal; } set { rareVal = value; } }

        public static int epicVal = 2;
        public static int epicMods { get { return epicVal; } set { epicVal = value; } }

        public static int legendVal = 5;
        public static int legendMods { get { return legendVal; } set { legendVal = value; } }


        int numPacks = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnBegin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPacks_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPacks.Text))
            {
                btnBegin.Enabled = false;
            }
            if (Int32.TryParse(txtPacks.Text, out numPacks))
            {
                if (numPacks > 0)
                {
                    btnBegin.Enabled = true;
                }
            }
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OptionsWindow optionsForm = new OptionsWindow();
            optionsForm.Show();
        }
    }

}
