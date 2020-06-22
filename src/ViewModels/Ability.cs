using System;
using System.Text;
using System.Collections.Generic;
using System.Threading;

namespace csandra.ln.marvel.rpg{
    /// <summary>
    /// Represent an ability
    /// Ability have a base value.
    /// Points worth to the base value can be spent to abilities of the same attribute class.
    /// </summary>
    public class Ability{
        /// <summary>
        /// the name of the ability
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// the attribute of the ability
        /// </summary>
        public string Attribute { get; set; }
        /// <summary>
        /// minimum value of the ability, based on attribute
        /// </summary>
        public int BaseValue{get;set;}
        /// <summary>
        /// value of the ability
        /// </summary>
        public int Value{get;set;}
    }
}