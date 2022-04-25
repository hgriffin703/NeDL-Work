using System;
namespace MusicDay16
{
    abstract class Music
    {
        public string artist;
        public string recordLabel;
        public Music()
        {
            artist = "";
            recordLabel ="";
        }
        public Music(string newArtist, string newRecordLabel)
        {
            artist = newArtist;
            recordLabel = newRecordLabel;
        }
        public override string ToString()
        {
            return ("The artist: " + artist + " | Record Label: " + recordLabel);
        }
    }
}