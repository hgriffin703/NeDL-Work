using System;

namespace Day13
{
    class Album: Music //chid class : base clase
    {
        public string albumTitle;
        private string releaseDate;
        public string ReleaseDate
        {
            get{return releaseDate;}
            set{releaseDate = value;}
        }
        public Album()
        {
            albumTitle = null; 
            releaseDate = null;
        }
    public Album (string aAlbumTitle, string aReleaseDate, string aArtist, string aRecordLabel): base(aArtist, aRecordLabel)
    {
        albumTitle = aAlbumTitle;
        releaseDate = aReleaseDate;
    }
    public override string ToString() //overwrites the values to strings
    {
        return "The Artist " + artist + " their album is: " + albumTitle + " and the release date was: " + releaseDate;
    }
  }
}