using System;

namespace Day13
{
    class Songs: Music //child class : base class
    {
        public string songTitle;
        public string songLength;
        public Songs()
        {
            songTitle = null; 
            songLength = null;
        }
    public Songs (string aSongTitle, string aSongLength, string aArtist, string aRecordLabel): base(aArtist, aRecordLabel)
    {
        songTitle = aSongTitle;
        songLength = aSongLength;
    }
    public override string ToString() //overwrites the values to strings; polymorphism
    {
        return "The Artist " + artist + " their song is: " + songTitle + " and the length of the song is: " + songLength;
    }
  }
}