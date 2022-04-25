using System;

namespace MusicDay16
{
    class Album: Music
    {
        public string albumTitle;
        public string yearReleased;
        public Album()
        {
            albumTitle = "";
            yearReleased = "";
        }
        public Album(string newArtist, string newRecordLabel, string newAlbumTitle, string newYearReleased): base (newArtist, newRecordLabel)
        {
            albumTitle = newAlbumTitle;
            yearReleased = newYearReleased;
        }
        public override string ToString()
        {
            return base.ToString() + " | Album Title: " + albumTitle + " released in " + yearReleased;
        }
    }
}