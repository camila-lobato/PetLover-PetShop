using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeForm.models
{
    internal class Pets
    {
        public string _idPet;
        public string _nomePet;
        public string _idade;
        public string _especie;
        public string _raca;
        public Donos _dono = new Donos();
    }
}
