using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsProj.classes
{
    public class Bird
    {
        public int serialNumber { get; set; }
        public string? species { get; set; }
        public string? subSpecies { get; set; }
        public DateOnly dateOfBirth { get; set; }
        public string? cageNumber { get; set; }
        public int dadSerialNumber { get; set; }
        public int momSerialNumber { get; set; }
        public string? gender { get; set; }

        public Bird()
        {
            this.serialNumber = 0000;
            this.species = null;
            this.subSpecies = null;
            this.dateOfBirth = new DateOnly(2000,01,01);
            this.cageNumber = null;
            this.dadSerialNumber = 0001;
            this.momSerialNumber = 0002;
            this.gender = null;
        }

        public Bird(int serialNumber, string species, string subSpecies, DateOnly dateOfBirth, string cageNumber, int dadSerialNumber, int momSerialNumber, string gender)
        {
            this.serialNumber = serialNumber;
            this.species = species;
            this.subSpecies = subSpecies;
            this.dateOfBirth = dateOfBirth;
            this.cageNumber = cageNumber;
            this.dadSerialNumber = dadSerialNumber;
            this.momSerialNumber = momSerialNumber;
            this.gender = gender;
        }
    }
}
