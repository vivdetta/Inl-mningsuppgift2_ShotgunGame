namespace Inlämningsuppgift2_ShotgunGame
{
    partial class frmShotgunGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShotgunGame));
            labelRound1 = new Label();
            buttonExit = new Button();
            labelOpponentName = new Label();
            labelOpponentInfo = new Label();
            labelComputerAmmo = new Label();
            labelChooseMove = new Label();
            buttonShoot = new Button();
            buttonLoad = new Button();
            buttonShield = new Button();
            buttonSHOTFUN = new Button();
            labelPlayerName = new Label();
            labelPlayerAmmo = new Label();
            pageSetupDialog1 = new PageSetupDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelRound1
            // 
            labelRound1.AutoSize = true;
            labelRound1.BackColor = Color.Transparent;
            labelRound1.FlatStyle = FlatStyle.Flat;
            labelRound1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRound1.ForeColor = Color.White;
            labelRound1.Location = new Point(524, 118);
            labelRound1.Name = "labelRound1";
            labelRound1.Size = new Size(355, 65);
            labelRound1.TabIndex = 0;
            labelRound1.Text = "Lets SHOTGUN";
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(1274, 35);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(112, 34);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelOpponentName
            // 
            labelOpponentName.BackColor = Color.Transparent;
            labelOpponentName.BorderStyle = BorderStyle.Fixed3D;
            labelOpponentName.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelOpponentName.ForeColor = Color.White;
            labelOpponentName.Location = new Point(876, 242);
            labelOpponentName.Name = "labelOpponentName";
            labelOpponentName.Size = new Size(435, 71);
            labelOpponentName.TabIndex = 12;
            labelOpponentName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelOpponentInfo
            // 
            labelOpponentInfo.BackColor = Color.Transparent;
            labelOpponentInfo.BorderStyle = BorderStyle.Fixed3D;
            labelOpponentInfo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOpponentInfo.ForeColor = Color.White;
            labelOpponentInfo.Location = new Point(920, 322);
            labelOpponentInfo.Name = "labelOpponentInfo";
            labelOpponentInfo.Size = new Size(342, 221);
            labelOpponentInfo.TabIndex = 14;
            // 
            // labelComputerAmmo
            // 
            labelComputerAmmo.BackColor = Color.Transparent;
            labelComputerAmmo.BorderStyle = BorderStyle.Fixed3D;
            labelComputerAmmo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelComputerAmmo.ForeColor = Color.White;
            labelComputerAmmo.Location = new Point(838, 559);
            labelComputerAmmo.Name = "labelComputerAmmo";
            labelComputerAmmo.Size = new Size(499, 53);
            labelComputerAmmo.TabIndex = 15;
            // 
            // labelChooseMove
            // 
            labelChooseMove.AutoSize = true;
            labelChooseMove.BackColor = Color.Transparent;
            labelChooseMove.BorderStyle = BorderStyle.Fixed3D;
            labelChooseMove.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelChooseMove.ForeColor = Color.White;
            labelChooseMove.Location = new Point(213, 322);
            labelChooseMove.Name = "labelChooseMove";
            labelChooseMove.Size = new Size(220, 34);
            labelChooseMove.TabIndex = 1;
            labelChooseMove.Text = "Choose Your Move";
            // 
            // buttonShoot
            // 
            buttonShoot.BackColor = Color.Transparent;
            buttonShoot.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShoot.Location = new Point(135, 369);
            buttonShoot.Name = "buttonShoot";
            buttonShoot.Size = new Size(112, 51);
            buttonShoot.TabIndex = 2;
            buttonShoot.Text = "Shoot";
            buttonShoot.UseVisualStyleBackColor = false;
            buttonShoot.Click += buttonShoot_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = Color.Transparent;
            buttonLoad.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLoad.Location = new Point(253, 369);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(126, 51);
            buttonLoad.TabIndex = 3;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonShield
            // 
            buttonShield.BackColor = Color.Transparent;
            buttonShield.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonShield.Location = new Point(385, 369);
            buttonShield.Name = "buttonShield";
            buttonShield.Size = new Size(117, 51);
            buttonShield.TabIndex = 4;
            buttonShield.Text = "Shield";
            buttonShield.UseVisualStyleBackColor = false;
            buttonShield.Click += buttonShield_Click;
            // 
            // buttonSHOTFUN
            // 
            buttonSHOTFUN.BackColor = Color.Transparent;
            buttonSHOTFUN.Font = new Font("Yu Gothic UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSHOTFUN.Location = new Point(189, 443);
            buttonSHOTFUN.Name = "buttonSHOTFUN";
            buttonSHOTFUN.Size = new Size(244, 100);
            buttonSHOTFUN.TabIndex = 5;
            buttonSHOTFUN.Text = "SHOTGUN";
            buttonSHOTFUN.UseVisualStyleBackColor = false;
            buttonSHOTFUN.Click += buttonSHOTFUN_Click;
            // 
            // labelPlayerName
            // 
            labelPlayerName.BackColor = Color.Transparent;
            labelPlayerName.BorderStyle = BorderStyle.Fixed3D;
            labelPlayerName.Font = new Font("Yu Gothic UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPlayerName.ForeColor = Color.White;
            labelPlayerName.Location = new Point(113, 242);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(417, 71);
            labelPlayerName.TabIndex = 13;
            labelPlayerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelPlayerAmmo
            // 
            labelPlayerAmmo.BackColor = Color.Transparent;
            labelPlayerAmmo.BorderStyle = BorderStyle.Fixed3D;
            labelPlayerAmmo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPlayerAmmo.ForeColor = Color.White;
            labelPlayerAmmo.Location = new Point(113, 559);
            labelPlayerAmmo.Name = "labelPlayerAmmo";
            labelPlayerAmmo.Size = new Size(417, 53);
            labelPlayerAmmo.TabIndex = 16;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 322);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // frmShotgunGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1409, 742);
            Controls.Add(pictureBox1);
            Controls.Add(labelPlayerAmmo);
            Controls.Add(labelComputerAmmo);
            Controls.Add(labelOpponentInfo);
            Controls.Add(labelPlayerName);
            Controls.Add(labelOpponentName);
            Controls.Add(buttonExit);
            Controls.Add(buttonSHOTFUN);
            Controls.Add(buttonShield);
            Controls.Add(buttonLoad);
            Controls.Add(buttonShoot);
            Controls.Add(labelChooseMove);
            Controls.Add(labelRound1);
            Name = "frmShotgunGame";
            Text = "Shotgun: The Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelRound1;
        private Button buttonExit;
        private Label labelOpponentName;
        private Label labelOpponentInfo;
        private Label labelComputerAmmo;
        private Label labelChooseMove;
        private Button buttonShoot;
        private Button buttonLoad;
        private Button buttonShield;
        private Button buttonSHOTFUN;
        private Label labelPlayerName;
        private Label labelPlayerAmmo;
        private PageSetupDialog pageSetupDialog1;
        private PictureBox pictureBox1;
    }
}
