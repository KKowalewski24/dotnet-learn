﻿using System.Collections.Generic;
using System.Threading.Tasks;
using EFCoreWebApi.EF;
using EFCoreWebApi.Models;

namespace EFCoreWebApi.Initializers {

    public class DataInitializer : IDataInitializer {

        /*------------------------ FIELDS REGION ------------------------*/
        private readonly ApplicationDbContext _applicationDbContext;

        /*------------------------ METHODS REGION ------------------------*/
        public DataInitializer(ApplicationDbContext applicationDbContext) {
            _applicationDbContext = applicationDbContext;
        }

        public async Task SeedDataAsync() {
            Owner owner = new Owner("Kamil", "Kowalewski");
            Pet dog = new Pet("Dog", owner);
            Pet cat = new Pet("Cat", owner);
            owner.AddPetsToOwner(new List<Pet> { dog, cat });
            await _applicationDbContext.Pets.AddAsync(dog);
            await _applicationDbContext.Owners.AddAsync(owner);
            await _applicationDbContext.SaveChangesAsync();
        }

    }

}
