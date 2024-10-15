using DocumentFormat.OpenXml.Wordprocessing;
using Inlämningsuppgift2_ShotgunGame.Abstracts;
using Inlämningsuppgift2_ShotgunGame.Classes;
using Inlämningsuppgift2_ShotgunGame.Enums;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Inlämningsuppgift2_ShotgunGame.Abstracts.ShotgunParticipant;

namespace Inlämningsuppgift2_ShotgunGame.Service
{
    public class GameMaster
    {
        private Form gameForm; // Reference to the form to handle closing/restarting
        private Player1 player;
        private Computer1 computer;

        public GameMaster(Form form, Player1 player, Computer1 computer)
        {
            gameForm = form;
            this.player = player;
            this.computer = computer;
        }

        // WinnerDecider returns true if there's a winner, false otherwise
        public bool WinnerDecider(Player1 player, Computer1 computer)
        {
            if (player.Move == MoveType.Shoot && computer.Move == MoveType.Reload)
            {
                WinnerWinner(player);
                return true;
            }
            else if (computer.Move == MoveType.Shoot && player.Move == MoveType.Reload)
            {
                WinnerWinner(computer);
                return true;
            }
            else if (player.Move == MoveType.Shotgun && computer.Move == MoveType.Shotgun)
            {
                return false;
            }
            else if (player.Move == MoveType.Shotgun)
            {
                WinnerWinner(player);
                return true;
            }
            else if (computer.Move == MoveType.Shotgun)
            {
                WinnerWinner(computer);
                return true;
            }
            return false;
        }

        public void CompareMovesAndDecide(Player1 player, Computer1 computer)
        {
            string result = "";

            if (player.Move == MoveType.Shoot && computer.Move == MoveType.Block)
            {
                result = $"{computer.Name} blocked {player.Name}'s shot! {computer.Name} smirks, \"You'll have to do better than that!\"";
            }
            else if (player.Move == MoveType.Shoot && computer.Move == MoveType.Reload)
            {
                result = $"{player.Name} wins the round by shooting while {computer.Name} was reloading!";
            }
            else if (computer.Move == MoveType.Shoot && player.Move == MoveType.Reload)
            {
                result = $"{computer.Name} shoots while {player.Name} was reloading! {computer.Name} wins this round with a sneaky shot!";
            }
            else if (player.Move == MoveType.Reload && computer.Move == MoveType.Reload)
            {
                result = $"It's a tense standoff as {computer.Name} and {player.Name} both reload...";
            }
            else if (player.Move == MoveType.Block && computer.Move == MoveType.Shoot)
            {
                result = $"{player.Name} blocks {computer.Name}'s shot just in time! \"Not today, {computer.Name}!\" {player.Name} yells triumphantly.";
            }
            else if (player.Move == MoveType.Block && computer.Move == MoveType.Block)
            {
                result = $"Both players take cover. There is silence as {player.Name} looks up at the same time {computer.Name }does. You have both shielded at the same time... embarassing.";
            }
            else if (player.Move == MoveType.Block && computer.Move == MoveType.Reload)
            {
                result = $"{player.Name} tries to block but {computer.Name} is just reloading! {computer.Name} smirks knowing they now have the upperhand.";
            }
            else if (player.Move == MoveType.Shoot && computer.Move == MoveType.Shoot)
            {
                result = $"Both {player.Name} and {computer.Name} fire their shots simultaneously! Bullets fly past each other, and both players lose ammo!";
            }
            else if (player.Move == MoveType.Shotgun && computer.Move == MoveType.Shoot)
            {
                result = $"{player.Name} pulls out the Shotgun! Even {computer.Name}'s bullet can't stop it! {player.Name} wins with a devastating blast!";
            }
            else if (player.Move == MoveType.Shotgun && computer.Move == MoveType.Block)
            {
                result = $"{player.Name} unleashes the Shotgun, breaking {computer.Name}'s defenses. {player.Name} wins with overwhelming firepower!";
            }
            else if (computer.Move == MoveType.Shotgun && player.Move == MoveType.Block)
            {
                result = $"{computer.Name} blasts you with a Shotgun! Your shield is no match. It's a crushing defeat for {player.Name}.";
            }
            else if (computer.Move == MoveType.Shotgun && player.Move == MoveType.Reload)
            {
                result = $"{computer.Name} blasts you with a Shotgun! You drop the ammo you were reloading. It's a crushing defeat for {player.Name}.";
            }
            else if (computer.Move == MoveType.Reload && player.Move == MoveType.Shotgun)
            {
                result = $"You blast {computer.Name} with a Shotgun! Their ammo drops from their limp fingers. {computer.Name} falls to the ground with a hole in their chest.";
            }
            else if (computer.Move == MoveType.Shotgun && player.Move == MoveType.Shoot)
            {
                result = $"{computer.Name} blasts you with a Shotgun! Your puny bullet is no match! {computer.Name} wins!";
            }
            else if (player.Move == MoveType.Shotgun && computer.Move == MoveType.Shotgun)
            {
                result = $"Both {player.Name} and {computer.Name} unleash their Shotguns at the same time! The ground shakes, and you are both suriously hurt by this apocalyptic blast but you are both still standing!";
            }
            else
            {
                result = $"After a quick burst of action the dust settles and both {player.Name} and {computer.Name}, are still standing. The showdown continues!";
            }

            // Show result message first
            MessageBox.Show(result);

            // Now check if there is a winner, if there are NO winners this text is display
            if (!WinnerDecider(player, computer))
            {
                // No winner, continue the game
                MessageBox.Show("No winner yet, continue playing!");
            }
        }

        // Used when a winner is determined
        private void WinnerWinner(ShotgunParticipant winner)
        {
            DialogResult playAgain = MessageBox.Show($"{winner.Name} wins the game!\nDo you want to play again?", "Game Over", MessageBoxButtons.YesNo);

            if (playAgain == DialogResult.Yes)
            {
                ResetGame();
                MessageBox.Show("The game has been reset. Good luck in the next round!");
            }
            else
            {
                gameForm.Close();
            }
        }

        private void ResetGame()
        {
            player.CurrentAmmo = 0;
            computer.CurrentAmmo = 0;

        }
    }
}
