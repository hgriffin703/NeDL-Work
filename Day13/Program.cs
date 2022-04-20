using System;

namespace Day13 //must be the same namespace througout
{
    class Program
    {
        static void Main(string[] args)
        {
            Music testMusicMain = new Music("Shakira", "Best Records"); //this inputs data to the Music Class
            Console.WriteLine(testMusicMain); //this prints out the return from MusicMain Line 21
            Album testAlbum = new Album("Shakira, Shakira", "10/20/2003", "ShakiraTest", "1Best"); //start with the ones from the Album
            Console.WriteLine(testAlbum);
            Songs testSong = new Songs("One Love", "3:45", "Bob Marley", "Long Day Studios");
            Console.WriteLine(testSong);
            Console.WriteLine("");

            Album [] musicalArray = new Album[5]; //album array
            for (int index = 0; index < musicalArray.Length; index++)
            {
                musicalArray[index] = new Album();
            }

            musicalArray[0].artist = ("Elton John"); //album info
            musicalArray[0].recordLabel = ("London Records");//album info
            musicalArray[0].albumTitle = ("Vienna"); //album info
            musicalArray[0].ReleaseDate = ("04/20/1976"); //album info

            Songs [] songsarray = new Songs[5];  //song array for data
            for (int indexS = 0; indexS < songsarray.Length; indexS++)
            {
                songsarray[indexS] = new Songs();
            }
            songsarray[2].artist = ("John Legend"); //song info
            songsarray[2].recordLabel = ("Capital Records");//song info
            songsarray[2].songTitle = ("Ordinary People"); //song info
            songsarray[2].songLength = ("4:35"); //song info

            songsarray[3].artist = ("Don McLean"); //song info
            songsarray[3].recordLabel = ("Tower Records");//song info
            songsarray[3].songTitle = ("American Pie"); //song info
            songsarray[3].songLength = ("9:21"); //song info
            
            songsarray[4].artist = ("Miley Cyrus"); //song info
            songsarray[4].recordLabel = ("London Records");//song info
            songsarray[4].songTitle = ("Party in the USA"); //song info
            songsarray[4].songLength = ("3:35"); //song info

            for(int index = 0; index < musicalArray.Length; index++)
            {
                if(!(((musicalArray[index]).albumTitle)==null))
                Console.WriteLine(musicalArray[index]); //printing the return from your album file
            }
             Console.WriteLine("");
            for (int indexS = 0; indexS < songsarray.Length; indexS++)
            {
                if(!(((songsarray[indexS]).songTitle)==null)) //printing the return from your song file
                Console.WriteLine(songsarray[indexS]);
            }
        }
    } 
}

