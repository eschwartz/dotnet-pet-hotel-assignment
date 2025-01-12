using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    // public enum PetBreedType {}
    // public enum PetColorType {}
    public class Pet {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Breed {get; set;}
        public string Color {get; set;}
        [ForeignKey("PetOwners")]
        public int OwnedById {get; set;}
    }
}
