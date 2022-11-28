using Ank9ServerApiModel;
using Ank9ServerApiModel.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ank9_Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ServerController : ControllerBase
    {
        private readonly ServerApiContext _context;
        public ServerController(ServerApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public List<Kisi> Get()
        {
            return _context.Kisiler.OrderBy(x => x.Ad).ToList();
        }
        [HttpGet("{id}")]
        public Kisi Getir(int id)
        {
            return _context.Kisiler.Where(x => x.Tc == id).FirstOrDefault();
        }
        [HttpPost]
        public void Ekle(Kisi kisi)
        {
            Kisi yeni = new Kisi()
            {
                Id = kisi.Id,
                Ad = kisi.Ad,
                Soyad = kisi.Soyad,
                cinsiyet = kisi.cinsiyet,
                dogumtarihi = kisi.dogumtarihi,
                Tc = kisi.Tc,
            };
            _context.Kisiler.Add(yeni);
            _context.SaveChanges();
        }
        [HttpPut("{id}")]
        public void Degistir(int id,Kisi degisenkisi)
        {
            Kisi eski = _context.Kisiler.Where(x => x.Id == id).FirstOrDefault();
            eski.Ad = degisenkisi.Ad;
            eski.Soyad = degisenkisi.Soyad;
            eski.dogumtarihi = degisenkisi.dogumtarihi;
            eski.cinsiyet = degisenkisi.cinsiyet;

            _context.Update(eski);
            _context.SaveChanges();
        }
        [HttpDelete("{ad}/{soyad}")]
        public void Sil(string ad,string soyad)
        {
            Kisi kisi = _context.Kisiler.Where(x => x.Ad == ad && x.Soyad == soyad).FirstOrDefault();
            _context.Kisiler.Remove(kisi);
            _context.SaveChanges();
        }
        [HttpGet("{id}")]
        public List<KisiDto> Dogumgunu(int id)
        {
            List<Kisi> kisiler = _context.Kisiler.Where(x => x.dogumtarihi.Month == id).ToList();
            return kisiler.OrderBy(x => x.dogumtarihi).ToList().Select(x => new KisiDto()
            {
                Ad = x.Ad,
                Soyad = x.Soyad,
                Yas = DateTime.Now.Year - x.dogumtarihi.Year
            }).ToList();
        }
    }
}
