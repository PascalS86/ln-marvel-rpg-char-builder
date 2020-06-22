using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace csandra.ln.marvel.rpg
{
    public class CharacterService
    {   
        private readonly string apiUri = "@@@API_ACCESS@@@";
        //TODO: Delete
        public List<Character> CharacterSource {get;set;}
        //TODO: Change to real DataSource
        public List<Character> Get()
        {
            try
            {
                if (CharacterSource == null)
                    CharacterSource = new List<Character>();
                return CharacterSource;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<Character>();
            }
        }

        //TODO: Change to real DataSource
        public void Post(Character data, string client = "")
        {
            try
            {
                if (CharacterSource == null)
                    CharacterSource = new List<Character>();
                if (CharacterSource.Contains(data))
                {
                    CharacterSource.Remove(data);
                }
                CharacterSource.Add(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        internal string GetAPI()=> apiUri;
    }
}