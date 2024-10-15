using Inlämningsuppgift2_ShotgunGame.Classes;
using Inlämningsuppgift2_ShotgunGame.Service;
using System.Media;

namespace Inlämningsuppgift2_ShotgunGame
{
    public partial class frmShotgunGame : Form
    {
        private Player1 player;
        private Computer1 computer;
        private GameMaster gameMaster;

        public frmShotgunGame(Player1 player, Computer1 computer)
        {
            InitializeComponent();

            SoundHelper.PlayBackgroundMusic();

            this.player = player;
            this.computer = computer;
            this.gameMaster = new GameMaster(this, player, computer); // Pass the player and computer

            labelPlayerName.Text = player.Name;
            labelOpponentName.Text = computer.Name;

            labelOpponentInfo.Text = computer.Description;

            CheckVisableButtons();

            ShowAmmo();

        }


        private void buttonShoot_Click(object sender, EventArgs e)
        {

            player.Shoot();
            computer.MakeComputerMove(player);

            gameMaster.CompareMovesAndDecide(player, computer);


            ShowAmmo();
            CheckVisableButtons();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSHOTFUN_Click(object sender, EventArgs e)
        {

            player.ShotgunFinish();
            computer.MakeComputerMove(player);
                
            gameMaster.CompareMovesAndDecide(player, computer);

            ShowAmmo();
            CheckVisableButtons();

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            player.LoadAmmo();
            computer.MakeComputerMove(player);

            gameMaster.CompareMovesAndDecide(player, computer);

            ShowAmmo();
            CheckVisableButtons();
        }

        private void buttonShield_Click(object sender, EventArgs e)
        {
            player.Block();
            computer.MakeComputerMove(player);
            
            gameMaster.CompareMovesAndDecide(player, computer);

            ShowAmmo();
            CheckVisableButtons();
        }
        private void ShowAmmo()
        {
            labelPlayerAmmo.Text = $"{player.Name}'s Current Ammo: {player.CurrentAmmo}";
            labelComputerAmmo.Text = $"{computer.Name}'s Current Ammo: {computer.CurrentAmmo}";
        }
        private void CheckVisableButtons()
        {
            if (player.CurrentAmmo == 0)
            {
                buttonShoot.Enabled = false;
                buttonSHOTFUN.Enabled = false;
            }
            else if (player.CurrentAmmo >= 1 && player.CurrentAmmo <= 2)
            {
                buttonShoot.Enabled = true;
                buttonSHOTFUN.Enabled = false;
            }
            else if(player.CurrentAmmo >= 3)
            {
                buttonShoot.Enabled = true;
                buttonSHOTFUN.Enabled = true;
            }
            else
            {
                buttonShoot.Enabled = true;
                buttonSHOTFUN.Enabled = true;
            }
        }
    }
}
