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
    public partial class MainWindow : Form
    {
        
        int totalCards, cardsLeft;                                                          //number of cards, number of cards left to use
        int comms, rares, epics, legends, gComms, gRares, gEpics, gLegends = 0;             //number of different crads collected
        int total = 0;                                                                      //starting total

        public MainWindow()
        {
            InitializeComponent();
        }

        //sets up the different labels with the correct values that were specified by the user
        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblNumPacks.Text = Form1.numPacks.ToString();
            totalCards = Form1.numPacks * 5;
            lblTotalCards.Text = totalCards.ToString();
            cardsLeft = totalCards;
            lblCardsLeft.Text = cardsLeft.ToString();

            lblComScoreMult.Text = "x" + Form1.commonMods;
            lblRareScoreMult.Text = "x" + Form1.rareMods;
            lblEpicScoreMult.Text = "x" + Form1.epicMods;
            lblLegScoreMult.Text = "x" + Form1.legendMods;

            if (Form1.commonMods == 0)
                lblGComScoreMult.Text = "x1";
            else
                lblGComScoreMult.Text = "x" + (Form1.commonMods * 2);
           
            lblGRareScoreMult.Text = "x" + Form1.rareMods * 2;
            lblGEpicScoreMult.Text = "x" + Form1.epicMods * 2;
            lblGLegScoreMult.Text = "x" + Form1.legendMods * 2;

        }
        
        //normal card incrementation
        //commons
        private void btnComInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                comms++;
                cardsLeft--;
            }

            txtComCount.Text = comms.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //rares
        private void btnRareInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                rares++;
                cardsLeft--;
            }

            txtRareCount.Text = rares.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //epics
        private void btnEpicInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                epics++;
                cardsLeft--;
            }

            txtEpicCount.Text = epics.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //legendaries
        private void btnLegInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                legends++;
                cardsLeft--;
            }

            txtLegCount.Text = legends.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        
        //normal card decrementation
        //commons
        private void btnComDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && comms > 0)
            {
                comms--;
                cardsLeft++;
            }

            txtComCount.Text = comms.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //rares
        private void btnRareDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && rares > 0)
            {
                rares--;
                cardsLeft++;
            }

            txtRareCount.Text = rares.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //epics
        private void btnEpicDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && epics > 0)
            {
                epics--;
                cardsLeft++;
            }

            txtEpicCount.Text = epics.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //legendaries
        private void btnLegDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && legends > 0)
            {
                legends--;
                cardsLeft++;
            }

            txtLegCount.Text = legends.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
       
        //gold card incrementation
        //commons
        private void btnGComInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                gComms++;
                cardsLeft--;
            }

            txtGComCount.Text = gComms.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //rares
        private void btnGRareInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                gRares++;
                cardsLeft--;
            }

            txtGRareCount.Text = gRares.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //epics
        private void btnGEpicInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                gEpics++;
                cardsLeft--;
            }

            txtGEpicCount.Text = gEpics.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //legendaries
        private void btnGLegInc_Click(object sender, EventArgs e)
        {
            if (cardsLeft > 0 && cardsLeft <= totalCards)
            {
                gLegends++;
                cardsLeft--;
            }

            txtGLegCount.Text = gLegends.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        
        //gold card decrementation
        //commons
        private void btnGComDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && gComms > 0)
            {
                gComms--;
                cardsLeft++;
            }

            txtGComCount.Text = gComms.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //rares
        private void btnGRareDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && gRares > 0)
            {
                gRares--;
                cardsLeft++;
            }

            txtGRareCount.Text = gRares.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //epics
        private void btnGEpicDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && gEpics > 0)
            {
                gEpics--;
                cardsLeft++;
            }

            txtGEpicCount.Text = gEpics.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //legendaries
        private void btnGLegDec_Click(object sender, EventArgs e)
        {
            if (cardsLeft >= 0 && cardsLeft < totalCards && gLegends > 0)
            {
                gLegends--;
                cardsLeft++;
            }

            txtGLegCount.Text = gLegends.ToString();

            lblCardsLeft.Text = cardsLeft.ToString();
        }
        //button event to calculate the total 
        private void btnCalculateTot_Click(object sender, EventArgs e)
        {
            //because the gold commons are finniky add the gold commons in first
            if (Form1.commonMods == 0)
                total = gComms;
            else
                total = gComms * Form1.commonMods * 2;
            
            //add the rest of the cards times by their multipliers to the total
            total += (comms * Form1.commonMods) + (rares * Form1.rareMods) + (epics * Form1.epicMods) + (legends * Form1.legendMods) + (gRares * Form1.rareMods * 2) + (gEpics * Form1.epicMods * 2) + (gLegends * Form1.legendMods * 2);

            txtFinalScore.Text = total.ToString();

        }
        //closes the entire program
        private void btnCLose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
