using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace csandra.ln.marvel.rpg{

    public enum eGroup{
        Avengers,
        Shield,
        Xmen,
        FantasticFour,
        GuardiansOfTheGalaxy,
        none
    }

    /// <summary>
    /// This class contains the info relevant to the rpg character
    /// characters spend 375 points on attributes
    /// </summary>
    public class Character{
        /// <summary>
        /// Represents the name of the character
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the lastname of the character
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Represents the height in cm of the character
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Represents the eyecolor of the character
        /// </summary>
        public string Eyes { get; set; }
        /// <summary>
        /// Represents the haircolor of the character
        /// </summary>
        public string Hair { get; set; }
        /// <summary>
        /// Represents the weight of the character
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Represents the hero name of the character
        /// </summary>
        public string Alias { get; set; }
        /// <summary>
        /// Represents the durability of the character
        /// </summary>
        public int Durability { get; set; } = 1;
        /// <summary>
        /// Represents the energy related powers of the character
        /// </summary>
        public int Energy { get; set; } = 1;
        /// <summary>
        /// Represents the figthing skills of the character
        /// </summary>
        public int FightingSkills { get; set; } = 1;
        /// <summary>
        /// Represents the intelligence of the character
        /// </summary>
        public int Intelligence { get; set; } = 1;
        /// <summary>
        /// Represents the speed of the character
        /// </summary>
        public int Speed { get; set; } = 1;
        /// <summary>
        /// Represents the strength of the character
        /// </summary>
        public int Strength {get;set;} = 1;
        /// <summary>
        /// Represents the social skill of the character
        /// </summary>
        public int Social {get;set;} = 1;
        /// <summary>
        /// Represents the economic skill of the character
        /// </summary>
        public int Economics {get;set;} = 1;
        /// <summary>
        /// Represents the agility of the character
        /// </summary>
        public int Agility {get;set;} = 1;
        /// <summary>
        /// Represents the dexterity of the character
        /// </summary>
        public int Dexterity {get;set;} = 1;
        /// <summary>
        /// Represents the mental power of the character
        /// </summary>
        public int Psyche {get;set;} = 1;
        /// <summary>
        /// Biography in markdown
        /// </summary>
        public string Biography { get; set; }
        /// <summary>
        /// Short description of the character in markdown
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Some info about eduction
        /// </summary>
        public List<string> Eduction { get; set; }
        /// <summary>
        /// Represents the place of birth of the character
        /// </summary>
        public string PlaceOfBirth { get; set; }
        /// <summary>
        /// Represents the birthday of the character
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Represents the powers of the character
        /// </summary>
        public List<Power> Powers { get; set; }   
        /// <summary>
        /// List of relatives
        /// </summary>
        public List<string> Relatives { get; set; }
        /// <summary>
        /// List of allies
        /// </summary>
        public List<string> Allies { get; set; }
        /// <summary>
        /// Group based on patreon
        /// </summary>
        public eGroup Group{get;set;}
        /// <summary>
        /// Selected patreon
        /// </summary>
        public Patreon Patreon { get; set; }
        /// <summary>
        /// Profile image uri
        /// </summary>
        public string ProfileImageUri { get; set; }
        /// <summary>
        /// List of image uris, for random backgrounds, etc.
        /// </summary>
        public List<string> ImageUris { get; set; }
    }
}