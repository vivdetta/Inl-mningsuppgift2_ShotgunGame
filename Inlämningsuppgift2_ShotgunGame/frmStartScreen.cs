using Inlämningsuppgift2_ShotgunGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Inlämningsuppgift2_ShotgunGame.Service;

namespace Inlämningsuppgift2_ShotgunGame
{
    public partial class frmStartScreen : Form
    {
        public frmStartScreen()
        {
            InitializeComponent();
            SoundHelper.PlaySoundEffect("gun-cocking-02.wav");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPlayerName.Text))
            {
                MessageBox.Show("Please enter a name to continue");
            }

            else
            {
                string playerName = textBoxPlayerName.Text;
                DialogResult userReady = MessageBox.Show($"Welcome {playerName}! Are you ready... FOR SHOTGUN!",
                    "Please Confirm", MessageBoxButtons.YesNo);
                if (userReady == DialogResult.Yes)
                {
                    Player1 player = new Player1(playerName);

                    Computer1 computer = new Computer1();

                    frmShotgunGame changeForm = new frmShotgunGame(player, computer);
                    changeForm.Show();
                    this.Hide();

                }
                else
                {
                    textBoxPlayerName.Clear();
                }

            }

        }
    }
}
