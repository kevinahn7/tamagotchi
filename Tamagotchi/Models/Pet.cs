using System;
namespace Tamagotchi.Models
{
    public class Pet
    {
        private string _name;
        private int _attention = 100;
        private int _rest = 100;
        private int _hunger = 100;
        public int _age = 1;

        public Pet(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetAttention()
        {
            return _attention;
        }

        public int GetRest()
        {
            return _rest;
        }

        public int GetHunger()
        {
            return _hunger;
        }

        public int GetAge()
        {
            return _age;
        }
    }
}
