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
    public partial class OptionsWindow : Form
    {
        int commNewVal = 0;
        int rareNewVal = 0;
        int epicNewVal = 0;
        int legendNewVal = 0;

        public OptionsWindow()
        {
            InitializeComponent();
        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {
            lblComVal.Text = Form1.commonMods.ToString();
            lblRareVal.Text = Form1.rareMods.ToString();
            lblEpicVal.Text = Form1.epicMods.ToString();
            lblLegendVal.Text = Form1.legendMods.ToString();
        }

        private void btnOptBegin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // On save button press if a new value is added for the cards, then they will be saves while program is run
        private void btnOptSave_Click(object sender, EventArgs e)
        {
            //to change the value for common cards to someting greater than -1 and different from previously
            if (!string.IsNullOrWhiteSpace(txtComNewVal.Text))
            {
                 if (Int32.TryParse(txtComNewVal.Text, out commNewVal))
                {
                    if (commNewVal >= 0 || commNewVal != Form1.commonMods)
                        Form1.commonMods = commNewVal;  
                }
            }

            //to change the value for rare cards to someting greater than -1 and different from previously
            if (!string.IsNullOrWhiteSpace(txtRareNewVal.Text))
            {
                if (Int32.TryParse(txtRareNewVal.Text, out rareNewVal))
                {
                    if (rareNewVal > 0 || rareNewVal != Form1.rareMods)
                        Form1.rareMods = rareNewVal;
                }
            }

            //to change the value for epic cards to someting greater than -1 and different from previously
            if (!string.IsNullOrWhiteSpace(txtEpicNewVal.Text))
            {
                if (Int32.TryParse(txtEpicNewVal.Text, out epicNewVal))
                {
                    if (epicNewVal > 0 || epicNewVal != Form1.epicMods)
                        Form1.epicMods = epicNewVal;
                }
            }

            //to change the value for legendary cards to someting greater than -1 and different from previously
            if (!string.IsNullOrWhiteSpace(txtLegendNewVal.Text))
            {
                if (Int32.TryParse(txtLegendNewVal.Text, out legendNewVal))
                {
                    if (legendNewVal > 0 || legendNewVal != Form1.legendMods)
                        Form1.legendMods = legendNewVal;
                }
            }

            //changes the current value labes
            lblComVal.Text = Form1.commonMods.ToString();
            lblRareVal.Text = Form1.rareMods.ToString();
            lblEpicVal.Text = Form1.epicMods.ToString();
            lblLegendVal.Text = Form1.legendMods.ToString();

            //clears the textboxes
            txtComNewVal.Clear();
            txtRareNewVal.Clear();
            txtEpicNewVal.Clear();
            txtLegendNewVal.Clear();

        }

    }
}
