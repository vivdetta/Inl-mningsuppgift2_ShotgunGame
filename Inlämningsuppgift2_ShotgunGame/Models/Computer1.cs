using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämningsuppgift2_ShotgunGame.Abstracts;

namespace Inlämningsuppgift2_ShotgunGame.Classes
{
    public class Computer1 : ShotgunParticipant
    {
        private static readonly Dictionary<string, string> computerCharacters = new Dictionary<string, string>()
    {
        { "John Wick", "A relentless assassin known for his focus and commitment. Don't mess with his dog." },
        { "Faye Valentine", "A charming but cunning bounty hunter from the Cowboy Bebop crew." },
        { "Skynet", "An artificial intelligence bent on eliminating all humans. Cold and calculating." },
        { "John Rambo", "A survival expert and veteran. Capable of outlasting any opponent in a prolonged fight." },
        { "Django", "A former slave turned bounty hunter. Quick on the draw and fearless in the face of danger." },
        { "Sinon", "A sharpshooter from the world of Sword Art Online. Known for precision and calm under pressure." },
        { "Legolas", "The elven archer with unmatched skills and agility, straight out of Middle-earth." },
        { "Ellen \"The Lady\"", "A tough-as-nails gunslinger from the Wild West." },
        { "Doc Holiday", "A skilled gambler and gunfighter, known for his wit and sharp tongue." },
        { "Man with No Name", "A mysterious drifter with a deadly aim. Silent, but always dangerous." }
    };

        // Property to hold the description of the character
        public string Description { get; private set; }

        //private static readonly List<string> computerNames = new List<string>()
        //{
           //"John Wick", "Faye Valentine", "Skynet", "John Rambo", "Django",
           //"Sinon", "Legolas", "Ellen \"The Lady\"", "Doc Holiday", "Man with No Name"
        //};
        public Computer1() : base(name: GetRandomName(), currentAmmo: 0)
        {
            // Assign the description after the name is set
            // So, when you access computerCharacters[Name], you're not asking for the key (Name itself).
            // Instead, you're using the key (Name) to look up the value (the description)
            // that the dictionary has associated with that key.

            //When you use computerCharacters["John Wick"],
            //you're using "John Wick" as the key to access the value associated with it.
            Description = computerCharacters[Name];
        }
        private static string GetRandomName()
        {
            Random random = new Random();
            List<string> computerNames = new List<string>(computerCharacters.Keys);
            int randomIndex = random.Next(computerNames.Count);
            return computerNames[randomIndex];
        }

        public void MakeComputerMove(Player1 player)
        {
            Random random = new Random();
            if (CurrentAmmo == 0 && player.CurrentAmmo == 0)
            {
                LoadAmmo();
            }
            else if (player.CurrentAmmo == 0 && CurrentAmmo >= 1 && CurrentAmmo < 3)
            {
                int randomMove = random.Next(0, 2);
                switch (randomMove)
                {
                    case 0:
                        LoadAmmo();
                        break;
                    case 1:
                        Shoot();
                        break;
                }
            }
            else if (player.CurrentAmmo >= 1 && CurrentAmmo >= 1 && CurrentAmmo < 3)
            {
                int randomMove = random.Next(0, 3);
                switch (randomMove)
                {
                    case 0:
                        Block();
                        break;
                    case 1:
                        Shoot();
                        break;
                    case 2:
                        LoadAmmo();
                        break;
                }
            }
            else if (CurrentAmmo == 3)
            {
                ShotgunFinish();
            }
            else if (CurrentAmmo > 1)
            {
                int randomMove = random.Next(0, 3);

                switch (randomMove)
                {
                    case 0:
                        Shoot();
                        break;
                    case 1:
                        Block();
                        break;
                    case 2:
                        LoadAmmo();
                        break;

                }
            }
            else 
            { 
                LoadAmmo();
            }

        }
       
    }
}
