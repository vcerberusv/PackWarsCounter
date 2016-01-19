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
        //global variables with get and set functions attached
        //for common cards
        public static int commonVal = 0;
        public static int commonMods { get { return commonVal; } set { commonVal = value; } }
        //for rares
        public static int rareVal = 1;
        public static int rareMods { get { return rareVal; } set { rareVal = value; } }
        //for epics
        public static int epicVal = 2;
        public static int epicMods { get { return epicVal; } set { epicVal = value; } }
        //for legendaries
        public static int legendVal = 5;
        public static int legendMods { get { return legendVal; } set { legendVal = value; } }
        //number of packs to be opened
        public static int numPacks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //after the number of packs has been entered the player hits this to possibly change settings to their preference
        private void btnSetup_Click(object sender, EventArgs e)
        {
            //opens the options menu as a dialog and allows for the back window to stay up until this one closes
            OptionsWindow setupForm = new OptionsWindow();
            setupForm.ShowDialog();
            //after the options window closes hide the main window and show the main calculator screen         
            this.Hide();
            MainWindow mainForm = new MainWindow();
            mainForm.Show();
     
        }
        //this stops the player from entering the calculator if there are no packs or if the textbox is null or has an invalid character
        private void txtPacks_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPacks.Text))
            {
                btnSetup.Enabled = false;
            }
            if (Int32.TryParse(txtPacks.Text, out numPacks))
            {
                if (numPacks > 0)
                {
                    btnSetup.Enabled = true;
                }
            }
            else
            {
                btnSetup.Enabled = false;
            }
        }

     
    }

}
