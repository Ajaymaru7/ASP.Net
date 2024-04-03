using System;
using System.Collections.Generic;
using System.Linq;
namespace G_Prg_Music.Controllers
{
    public class MusicController : Controller
    {
        public static List<Music> albums = new List<Music>
{
new Music {AlbumID = 1 , AlbumName = "Shayad" , releaseyear = 2020 , singername = "ArijitSingh" , musicianname = "PritamChakraborty" }, new Music {AlbumID = 2 , AlbumName = "LutGaye" , releaseyear = 2021, singername = "JubinNautiyal" , musicianname = "TanishkBagchi" }, new Music {AlbumID = 3 , AlbumName = "Ranjha" , releaseyear = 2021, singername = "JasleenRoyal" , musicianname = "JasleenRoyal" }, new Music {AlbumID = 4 , AlbumName = "Befikra" , releaseyear = 2016, singername = "MeetBros" , musicianname = "MeetBros" },
new Music {AlbumID = 5 , AlbumName = "Makhna" , releaseyear = 2019, singername = "TanishkBagchi" , musicianname = "TanishkBagchi" }
};

        public object ModelState { get; private set; }

        // GET: Music
        public ActionResult Index()
        {
            return View(albums);
        }

        private ActionResult View(List<Music> albums)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            var album = albums.Find(a => a.AlbumID == id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        private ActionResult View(Music album)
        {
            throw new NotImplementedException();
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Edit(Music album)
        {
            if (ModelState.IsValid)
            {
                var existingmusic = albums.FirstOrDefault(a =>
                a.AlbumID == album.AlbumID);
                if (existingmusic != null)
                {
                    existingmusic.AlbumName = album.AlbumName;
                    existingmusic.releaseyear = album.releaseyear;
                    existingmusic.singername = album.singername;
                    existingmusic.musicianname = album.musicianname;
                }
                return RedirectToAction("Index");
            }
            return View(album);
        }

        private ActionResult RedirectToAction(string v)
        {
            throw new NotImplementedException();
        }
    }
}