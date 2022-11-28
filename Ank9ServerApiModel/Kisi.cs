using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank9ServerApiModel
{
    public class Kisi
    {
        public int Id { get; set; }
        public int Tc { get; set; }
        public string Ad { get; set; }
        private string _Soyad;
        public string Soyad { get { return _Soyad; } set { _Soyad = value.ToUpper(); } }
        private DateTime _dogumtarihi;
        public DateTime dogumtarihi { get { return _dogumtarihi; } 
            set {
                _dogumtarihi = (DateTime.Now.Year-value.Year)>=20? value:throw new Exception("yaş uygun değil");
            } 
        }
        public Cinsiyet cinsiyet { get; set; }
    }
    public enum Cinsiyet { K,E }
}
