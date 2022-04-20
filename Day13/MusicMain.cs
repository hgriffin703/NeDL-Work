using System;

namespace Day13 //same namespace as Program
{
    class Music //base class
    {
        public string artist;
        public string recordLabel;
        public Music() //call the object class again
        {
            artist = null; 
            recordLabel = null;
        }
    public Music (string aArtist, string aRecordLabel)
    {
        artist = aArtist;
        recordLabel = aRecordLabel;
    }
    public override string ToString() //overwrites the values to strings
    {
        return "The artist is: " + artist + " and their record label is: " + recordLabel;
    }
  }
}
  
 