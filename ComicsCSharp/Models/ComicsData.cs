using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsCSharp.Models
{
    public class ComicsData
    {
        //this method come from ComicController.cs 
        private static List<Comic> comics = new List<Comic>();
        //add Getall() with static b/c private upline of coding have a static 
        public static List<Comic> GetAll()
        {
            return comics;
        }

        public static void Add(Comic comic)
        {
            comics.Add(comic);
        }
        //lambda
        //public static void RemoveById(int id)
        //{
        //    comics.RemoveAll(c => c.ComicID == id);
        //}
        public static void RemoveById(int id)
        {
            foreach (Comic comic in comics)
            {
                if (Equals(comic, id))
                {
                    comics.Remove(comic);
                }
            }
        }

        public static bool Equals(Comic comic, int id)
        {
                return comic.ComicID == id;
        }
    }
}
