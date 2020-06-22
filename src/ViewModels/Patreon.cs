using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace csandra.ln.marvel.rpg{
    /// <summary>
    /// Represent a patreon
    /// Patreons give 125 extra points to specific attributes
    /// </summary>
    public class Patreon{
        /// <summary>
        /// the name of the superpower
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// group of the patreon
        /// </summary>
        public eGroup Group { get; set; }
        /// <summary>
        /// List of powers available through patreon
        /// </summary>
        public List<Power> AllPowers { get; set; }
    }
}