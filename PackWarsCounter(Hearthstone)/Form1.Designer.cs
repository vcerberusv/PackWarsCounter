namespace PackWarsCounter_Hearthstone_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSetup = new System.Windows.Forms.Button();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.lblSubHeading = new System.Windows.Forms.Label();
            this.lblInstructionHeading = new System.Windows.Forms.Label();
            this.txtPacks = new System.Windows.Forms.TextBox();
            this.lblCreditations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetup
            // 
            this.btnSetup.Enabled = false;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.Location = new System.Drawing.Point(303, 385);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(191, 97);
            this.btnSetup.TabIndex = 0;
            this.btnSetup.Text = "Setup and Begin";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(80, 31);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(633, 42);
            this.lblMainHeading.TabIndex = 2;
            this.lblMainHeading.Text = "Pack Wars Counter (for Hearthstone)";
            // 
            // lblSubHeading
            // 
            this.lblSubHeading.AutoSize = true;
            this.lblSubHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubHeading.Location = new System.Drawing.Point(95, 117);
            this.lblSubHeading.Name = "lblSubHeading";
            this.lblSubHeading.Size = new System.Drawing.Size(606, 62);
            this.lblSubHeading.TabIndex = 3;
            this.lblSubHeading.Text = "Compete with your friends by opening packs and \r\n              collecting points " +
    "per card obtained.";
            // 
            // lblInstructionHeading
            // 
            this.lblInstructionHeading.AutoSize = true;
            this.lblInstructionHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructionHeading.Location = new System.Drawing.Point(195, 212);
            this.lblInstructionHeading.Name = "lblInstructionHeading";
            this.lblInstructionHeading.Size = new System.Drawing.Size(386, 37);
            this.lblInstructionHeading.TabIndex = 4;
            this.lblInstructionHeading.Text = "Number of packs to open:";
            // 
            // txtPacks
            // 
            this.txtPacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacks.Location = new System.Drawing.Point(365, 301);
            this.txtPacks.MaxLength = 4;
            this.txtPacks.Name = "txtPacks";
            this.txtPacks.Size = new System.Drawing.Size(71, 38);
            this.txtPacks.TabIndex = 5;
            this.txtPacks.Text = "0";
            this.txtPacks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPacks.TextChanged += new System.EventHandler(this.txtPacks_TextChanged);
            // 
            // lblCreditations
            // 
            this.lblCreditations.AutoSize = true;
            this.lblCreditations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditations.Location = new System.Drawing.Point(450, 533);
            this.lblCreditations.Name = "lblCreditations";
            this.lblCreditations.Size = new System.Drawing.Size(322, 20);
            this.lblCreditations.TabIndex = 6;
            this.lblCreditations.Text = "Pack Wars Counter, By James Barnes, 2016";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblCreditations);
            this.Controls.Add(this.txtPacks);
            this.Controls.Add(this.lblInstructionHeading);
            this.Controls.Add(this.lblSubHeading);
            this.Controls.Add(this.lblMainHeading);
            this.Controls.Add(this.btnSetup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Pack Wars Counter (for Hearthstone)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Label lblSubHeading;
        private System.Windows.Forms.Label lblInstructionHeading;
        private System.Windows.Forms.TextBox txtPacks;
        private System.Windows.Forms.Label lblCreditations;
    }
}

