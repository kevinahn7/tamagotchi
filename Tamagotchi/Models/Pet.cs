using System;
using System.Collections.Generic;
namespace Tamagotchi.Models
{
    public class Pet
    {
        private string _name;
        private int _attention = 100;
        private int _rest = 100;
        private int _hunger = 100;
        private int _age = 1;
        private int _time = 0;
        private static List<Pet> _petList = new List<Pet>() { };
        private int _id;

        public Pet(string name)
        {
            _name = name;
            _id = _petList.Count;
            _petList.Add(this);
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

        public int GetId()
        {
            return _id;
        }

        public void UpdateAttributes()
        {
            _rest -= 10;
            _hunger -= 10;
            _attention -= 10;
            _time += 20;
            UpdateAge();
        }

        public void UpdateAge()
        {
            if (_time % 100 == 0)
            {
                _age++;
            }
        }

        public void UpdateAttention()
        {
            _attention += 30;
            UpdateAttributes();
        }

        public void UpdateHunger()
        {
            _hunger += 30;
            UpdateAttributes();
        }

        public void UpdateRest()
        {
            _rest += 30;
            UpdateAttributes();
        }

    }
}
