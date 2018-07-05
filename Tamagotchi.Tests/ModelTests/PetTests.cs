using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void GetProperties_GetsPetProperties_ReturnEqualValue()
        {
            Pet newPet = new Pet("Jeff");

            string nameResult = newPet.GetName();
            int attentionResult = newPet.GetAttention();
            int restResult = newPet.GetRest();
            int hungerResult = newPet.GetHunger();
            int ageResult = newPet.GetAge();
            int idResult = newPet.GetId();
            List<Pet> listResult = Pet.GetAllPets();
            List<Pet> actualPetList = new List<Pet>() { newPet };


            Assert.AreEqual("Jeff", nameResult);
            Assert.AreEqual(100, attentionResult);
            Assert.AreEqual(100, restResult);
            Assert.AreEqual(100, hungerResult);
            Assert.AreEqual(1, ageResult);
            Assert.AreEqual(1, idResult);
            CollectionAssert.AreEqual(actualPetList, listResult);
        }

        [TestMethod]
        public void ClearAll_ClearsAll_ReturnEqualValue()
        {
            Pet newPet = new Pet("Jeff");
            Pet.ClearAll();
            List<Pet> actualPetList = new List<Pet>() { };
            CollectionAssert.AreEqual(actualPetList, Pet.GetAllPets());
        }

        [TestMethod]
        public void ClearPet_ClearsPet_ReturnEqualValue()
        {
            Pet newPetJeff = new Pet("Jeff");
            Pet newPetTom = new Pet("Tom");
            Pet newPetBob = new Pet("Bob");
            Pet.ClearPet(2);
            List<Pet> actualPetList = new List<Pet>() { newPetJeff, newPetBob };
            CollectionAssert.AreEqual(actualPetList, Pet.GetAllPets());
            Assert.AreEqual(1, newPetJeff.GetId());
            Assert.AreEqual(2, newPetBob.GetId());
        }

    }
}
