namespace Inlämningsuppgift2_ShotgunGame
{
    partial class frmStartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartScreen));
            labelGameSynopsis = new Label();
            labelPlayerName = new Label();
            textBoxPlayerName = new TextBox();
            buttonStart = new Button();
            labelShotgunHeading = new Label();
            SuspendLayout();
            // 
            // labelGameSynopsis
            // 
            labelGameSynopsis.AutoSize = true;
            labelGameSynopsis.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelGameSynopsis.ForeColor = Color.White;
            labelGameSynopsis.Location = new Point(94, 99);
            labelGameSynopsis.Name = "labelGameSynopsis";
            labelGameSynopsis.Size = new Size(631, 100);
            labelGameSynopsis.TabIndex = 0;
            labelGameSynopsis.Text = resources.GetString("labelGameSynopsis.Text");
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerName.ForeColor = Color.White;
            labelPlayerName.Location = new Point(367, 230);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(59, 25);
            labelPlayerName.TabIndex = 1;
            labelPlayerName.Text = "Name";
            // 
            // textBoxPlayerName
            // 
            textBoxPlayerName.Location = new Point(295, 267);
            textBoxPlayerName.Name = "textBoxPlayerName";
            textBoxPlayerName.Size = new Size(211, 31);
            textBoxPlayerName.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(324, 319);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(142, 35);
            buttonStart.TabIndex = 3;
            buttonStart.Text = "START";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelShotgunHeading
            // 
            labelShotgunHeading.AutoSize = true;
            labelShotgunHeading.Font = new Font("Yu Gothic UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelShotgunHeading.ForeColor = Color.White;
            labelShotgunHeading.Location = new Point(94, 29);
            labelShotgunHeading.Name = "labelShotgunHeading";
            labelShotgunHeading.Size = new Size(611, 70);
            labelShotgunHeading.TabIndex = 4;
            labelShotgunHeading.Text = "Welcome to... SHOTGUN";
            // 
            // frmStartScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(labelShotgunHeading);
            Controls.Add(buttonStart);
            Controls.Add(textBoxPlayerName);
            Controls.Add(labelPlayerName);
            Controls.Add(labelGameSynopsis);
            Name = "frmStartScreen";
            Text = "Patr";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGameSynopsis;
        private Label labelPlayerName;
        private TextBox textBoxPlayerName;
        private Button buttonStart;
        private Label labelShotgunHeading;
    }
}