using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var AlbumList = new List<Album>();
            var SongsList = new List<Song>();
            bool flag = true;
            while (true)
            {
                string albumAnswer;
                Console.WriteLine("Do you want to add an album? [y]es or [n]o");
                albumAnswer = Console.ReadLine();
                if (albumAnswer == "n")
                    break;
                else
                {
                    Console.Write("What is the name of the album?");
                    string albumName = Console.ReadLine();
                    Console.Write("What is the name of the artist?");
                    string albumArist = Console.ReadLine();

                    Album album = new Album();
                    album.title = albumName;
                    album.artist = albumArist;
                    AlbumList.Add(album);



                    string answer2 = "y";
                    while (answer2 == "y")
                    {
                        Console.Write("What is the name of the song?");
                        string songName = Console.ReadLine();
                        Console.Write("What is the duration of the song?");
                        string duration = Console.ReadLine();

                        Song song = new Song();
                        song.title = songName;
                        song.duration = duration;
                        SongsList.Add(song);

                        Console.Write("Do you want to add another song? [y]es or [n]o");
                        answer2 = Console.ReadLine();
                    }

                    album.songs = SongsList;
                }


            }
            Console.Write("Do you want to retrieve all the albums?[y]es or [n]o");

            string input = Console.ReadLine();

            if (input == "y" && AlbumList.Count() == 0)
            {
                Console.WriteLine("You don't have any albums to retrieve!");
            }
            else if (input == "y" && AlbumList.Count() > 0)
            {
                for (int i = 0; i < AlbumList.Count(); i++)
                {
                    Console.WriteLine("Album Info:");
                    Console.Write(AlbumList[i].title);
                    Console.Write(AlbumList[i].artist);

                    for (int j = 0; j < AlbumList[i].songs.Count(); j++)
                    {
                        Console.WriteLine("List of songs:");
                        Console.Write(AlbumList[i].songs[i].title + ",");
                        Console.Write(AlbumList[i].songs[i].duration);
                    }

                }
            }

        }
    }
}
