using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //2.1.1
    public class Song {
        public string title { get; private set; } = String.Empty;
        public string artistName { get; set; } = String.Empty;
        public int length { get; set; }

        public Song(string Title, string ArtistName, int Length) {
            Title = title;
            ArtistName = artistName;
            Length = length;

        }

    }
    


        //2.1.2
}
