using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Repository_Pattern
{
    public enum GenreType
    {
        Action = 1, Bromance, Documentary, Drama, Horror, Noir, RomCom, SciFi, WildWest
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public string Description { get; set; }
        public double RunTimeInMinutes { get; set; }
        public double StarRating { get; set; }
        public string MaturityRating { get; set; }
        public bool IsFamilyFriendly { get; set; }

        //ctor + tab tab auto create constructor
        public StreamingContent()  { }
        public StreamingContent(string title, GenreType typeOfGenre, string description, double runTimeInMinutes, double starRating, string maturityRating, bool isFamilyFriendly)
        {
            Title = title;
            TypeOfGenre = typeOfGenre;
            Description = description;
            RunTimeInMinutes = runTimeInMinutes;
            StarRating = starRating;
            MaturityRating = maturityRating;
            IsFamilyFriendly = isFamilyFriendly;
        }
    }
}

