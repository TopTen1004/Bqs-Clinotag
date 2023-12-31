﻿namespace BqsClinoTag.Models.LightObject
{
    public class LieuLight
    {
        public int IdLieu { get; set; }
        public string UidTag { get; set; }
        public string? Client { get; set; }
        public string? Nom { get; set; }   
        public List<TacheLight>? lTache { get; set; }

        public LieuLight(Lieu lieu)
        {
            IdLieu = lieu.IdLieu;
            UidTag = lieu.UidTag;
            Client = lieu.IdClientNavigation.Nom;
            Nom = lieu.Nom;
            lTache = new List<TacheLight>();
            foreach (TacheLieu t in lieu.TacheLieus)
            {
                TacheLight tl = new TacheLight();
                tl.idTacheLieu = t.IdTl;
                tl.idTache = t.IdTache;
                tl.nom = t.IdTacheNavigation.Nom;
                tl.description = t.IdTacheNavigation.Description;
                lTache.Add(tl);

            }
        }
    }
}