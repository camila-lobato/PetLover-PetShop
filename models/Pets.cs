using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeForm.models
{
    internal class Pets
    {
        public int _idPet { get; set; }
        public string _nomePet { get; set; }
        public string _idade { get; set; }
        public string _especie { get; set; }
        public string _raca { get; set; }
        public Donos _dono { get; set; }
    }
}
