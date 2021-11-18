using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazzzeee
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImeIPrezime { get => $"{Ime} {Prezime}"; }
        public int Godiste { get; set; }
    }
}
