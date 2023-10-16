using System.Collections.Generic;
using ImageBrowser.Model;
using static ImageBrowser.Repository.CategoryType;

namespace ImageBrowser.Repository
{
    public class PictureRepositoryInMemory : PictureRepository
    {
        private List<Picture> pictures = new List<Picture>();
        
        public PictureRepositoryInMemory()
        {
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan alt.jpg", @"D:\patreon\ayyaSAP\pack57\7 Alternate versions\Bastila Shan alt.jpg", Alternate.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan bottomless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan bottomless", Bottomless.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan cum.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Bastila Shan\Bastila Shan cum.jpg", Cum.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan futa cum.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Bastila Shan\Bastila Shan futa cum.jpg", Futacum.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan futa.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Bastila Shan\Bastila Shan futa.jpg", Futa.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan lingerie.jpg", Lingerie.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan NSFW.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan NSFW.jpg", Nude.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan pubes full.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan pubes full.jpg", Pubes.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan pubes.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan pubes.jpg", Pubes.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan tanline.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan tanline.jpg", Tanline.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan topless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bastila Shan\Bastila Shan topless.jpg", Topless.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Bastila Shan", @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan.jpg", @"D:\patreon\ayyaSAP\pack57\2 High-Res illustrations\Bastila Shan.jpg", Normal.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Cat Woman", @"D:\patreon\ayyaSAP\pack57\thumbnail\Catwoman lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\6 Second chance\Catwoman lingerie.jpg", Lingerie.ToString(), "DC", "AyyaSAP"));
            pictures.Add(new Picture("Cat Woman", @"D:\patreon\ayyaSAP\pack57\thumbnail\Catwoman NSFW.jpg", @"D:\patreon\ayyaSAP\pack57\6 Second chance\Catwoman NSFW.jpg", Nude.ToString(), "DC", "AyyaSAP"));
            pictures.Add(new Picture("Cat Woman", @"D:\patreon\ayyaSAP\pack57\thumbnail\Catwoman NSFW2.jpg", @"D:\patreon\ayyaSAP\pack57\6 Second chance\Catwoman NSFW2.jpg", Nude.ToString(), "DC", "AyyaSAP"));
            pictures.Add(new Picture("Cat Woman", @"D:\patreon\ayyaSAP\pack57\thumbnail\Catwoman.jpg", @"D:\patreon\ayyaSAP\pack57\6 Second chance\Catwoman.jpg", Normal.ToString(), "DC", "AyyaSAP"));
            pictures.Add(new Picture("Cat Woman", @"D:\patreon\ayyaSAP\pack57\thumbnail\Catwoman2.jpg", @"D:\patreon\ayyaSAP\pack57\6 Second chance\Catwoman2.jpg", Normal.ToString(), "DC", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible alt.jpg", @"D:\patreon\ayyaSAP\pack57\7 Alternate versions\Kim Possible alt.jpg", Alternate.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible bottomless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible bottomless.jpg", Bottomless.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible cum.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Kim Possible\Kim Possible cum.jpg", Cum.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible futa cum.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Kim Possible\Kim Possible futa cum.jpg", Futacum.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible futa.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Kim Possible\Kim Possible futa.jpg", Futa.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible lingerie.jpg", Lingerie.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible nsfw.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible nsfw.jpg", Nude.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible pubes full.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible pubes fulle.jpg", Pubes.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible pubes.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible pubes.jpg", Pubes.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible tanline.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible tanline.jpg", Tanline.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible topless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Kim Possible\Kim Possible topless.jpg", Topless.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Kim Possible", @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible.jpg", @"D:\patreon\ayyaSAP\pack57\2 High-Res illustrations\Kim Possible.jpg", Normal.ToString(), "Kim Possible", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran 2 nsfw.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran 2 nsfw.jpg", Nude.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran alt.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\Nova Terra x Samus Aran alt.jpg", Alternate.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran bottomless.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran bottomless.jpg", Bottomless.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran cum.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\Futa+Cum\Nova Terra x Samus Aran cum.jpg", Cum.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran futa cum.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\Futa+Cum\Nova Terra x Samus Aran futa cum.jpg", Futacum.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran futa.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\Futa+Cum\Nova Terra x Samus Aran futa.jpg", Futa.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran lingerie.jpg", Lingerie.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran nsfw.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran nsfw.jpg", Nude.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran pubes full.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran pubes full.jpg", Pubes.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran pubes.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran pubes.jpg", Pubes.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran tanline.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran tanline.jpg", Tanline.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran topless.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\NSFW\Nova Terra x Samus Aran topless.jpg", Topless.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\Nova Terra x Samus Aran.jpg", Normal.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Nova Terra x Samus Aran", @"D:\patreon\ayyaSAP\pack57\thumbnail\Nova Terra x Samus Aran2 alt.jpg", @"D:\patreon\ayyaSAP\pack57\5 YURI\Nova Terra x Samus Aran2 alt.jpg", Alternate.ToString(), "Metroid", "AyyaSAP"));
            pictures.Add(new Picture("Tifa", @"D:\patreon\ayyaSAP\pack57\thumbnail\Tifa bottomless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Tifa bottomless.jpg", Bottomless.ToString(), "Final Fantasy", "AyyaSAP"));
            pictures.Add(new Picture("Tifa", @"D:\patreon\ayyaSAP\pack57\thumbnail\Tifa lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Tifa lingerie.jpg", Lingerie.ToString(), "Final Fantasy", "AyyaSAP"));
            pictures.Add(new Picture("Tifa", @"D:\patreon\ayyaSAP\pack57\thumbnail\Tifa NSFW.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Tifa NSFW.jpg", Nude.ToString(), "Final Fantasy", "AyyaSAP"));
            pictures.Add(new Picture("Tifa", @"D:\patreon\ayyaSAP\pack57\thumbnail\Tifa tanline.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Tifa tanline.jpg", Tanline.ToString(), "Final Fantasy", "AyyaSAP"));
            pictures.Add(new Picture("Tifa", @"D:\patreon\ayyaSAP\pack57\thumbnail\Tifa topless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Tifa topless.jpg", Topless.ToString(), "Final Fantasy", "AyyaSAP"));
            pictures.Add(new Picture("Tifa", @"D:\patreon\ayyaSAP\pack57\thumbnail\Tifa.jpg", @"D:\patreon\ayyaSAP\pack57\2 High-Res illustrations\Bonus\Tifa.jpg", Normal.ToString(), "Final Fantasy", "AyyaSAP"));
            pictures.Add(new Picture("Twi'lek Dancer", @"D:\patreon\ayyaSAP\pack57\thumbnail\Twi'lek Dancer  NSFW.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Twi'lek Dancer NSFW.jpg", Nude.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Twi'lek Dancer", @"D:\patreon\ayyaSAP\pack57\thumbnail\Twi'lek Dancer.jpg", @"D:\patreon\ayyaSAP\pack57\2 High-Res illustrations\Bonus\Twi'lek Dancer.jpg", Normal.ToString(), "Star Wars", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda alt.jpg", @"D:\patreon\ayyaSAP\pack57\7 Alternate versions\Wanda alt.jpg", Alternate.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda bottomless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda bottomless.jpg", Bottomless.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda cum.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Wanda\Wanda cum.jpg", Cum.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda futa cum.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Wanda\Wanda futa cum.jpg", Futacum.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda futa.jpg", @"D:\patreon\ayyaSAP\pack57\4 Futa+Cum\Wanda\Wanda futa.jpg", Futa.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda lingerie.jpg", Lingerie.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda nsfw.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda nsfw.jpg", Nude.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda pubes full.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda pubes full.jpg", Pubes.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda pubes.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda pubes.jpg", Pubes.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda tanline.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda tanline.jpg", Tanline.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda topless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Wanda\Wanda topless.jpg", Topless.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Wanda", @"D:\patreon\ayyaSAP\pack57\thumbnail\Wanda.jpg", @"D:\patreon\ayyaSAP\pack57\2 High-Res illustrations\Wanda.jpg", Normal.ToString(), "Marvel", "AyyaSAP"));
            pictures.Add(new Picture("Yor Forger", @"D:\patreon\ayyaSAP\pack57\thumbnail\Yor Forger bottomless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Yor Forger bottomless.jpg", Bottomless.ToString(), "SPY x FAMILY", "AyyaSAP"));
            pictures.Add(new Picture("Yor Forger", @"D:\patreon\ayyaSAP\pack57\thumbnail\Yor Forger lingerie.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Yor Forger lingerie.jpg", Lingerie.ToString(), "SPY x FAMILY", "AyyaSAP"));
            pictures.Add(new Picture("Yor Forger", @"D:\patreon\ayyaSAP\pack57\thumbnail\Yor Forger NSFW.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Yor Forger NSFW.jpg", Nude.ToString(), "SPY x FAMILY", "AyyaSAP"));
            pictures.Add(new Picture("Yor Forger", @"D:\patreon\ayyaSAP\pack57\thumbnail\Yor Forger topless.jpg", @"D:\patreon\ayyaSAP\pack57\3 NSFW+Lingerie\Bonus\Yor Forger topless.jpg", Topless.ToString(), "SPY x FAMILY", "AyyaSAP"));
            pictures.Add(new Picture("Yor Forger", @"D:\patreon\ayyaSAP\pack57\thumbnail\Yor Forger.jpg", @"D:\patreon\ayyaSAP\pack57\2 High-Res illustrations\Bonus\Yor Forger.jpg", Normal.ToString(), "SPY x FAMILY", "AyyaSAP"));
        }
        
        public List<Picture> RetrieveAll()
        {
            return pictures;
        }
        public List<Picture> RetrieveFor(HashSet<string> categories, HashSet<string> franchises)
        {
            var list = pictures;
            
            if (categories.Count > 0)
                list = list.FindAll(picture => categories.Contains(picture.Category));

            if (franchises.Count > 0)
                list = list.FindAll(picture => franchises.Contains(picture.Franchise));

            return list;
        }

    }
}