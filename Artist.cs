using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleIBMproject
{
    internal class Artist :Person
    {
        // artist properties
        public int ArtistId { get; set; }
        public string? StageName { get; set; }   
        public string? Genre { get; set; }
        public int AlbumsReleased { get; set; }

        // constructor for Artist class
        public Artist()
        {
            StageName = "Unknown";
            Genre = "Unknown";
            AlbumsReleased = 0;
        }
        public Artist(int artistId, int id,string name, int age,string city, string stageName, string genre, int albumsReleased)
            : base(id,name,city,age)
        {
            ArtistId = artistId;
            StageName = stageName;
            Genre = genre;
            AlbumsReleased = albumsReleased;
        }

        // method to display artist details
        public void DisplayArtistDetails()
        {
            Console.WriteLine($"Artist ID: {ArtistId}");
            Console.WriteLine($"Stage Name: {StageName}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Albums Released: {AlbumsReleased}");
            base.DisplayPersonDetails(); // Call the base class method to display person details
        }
        // method to get artist info
        public string GetArtistInfo()
        {
            return $"Artist ID: {ArtistId}, Stage Name: {StageName}, Genre: {Genre}, Albums Released: {AlbumsReleased}, " +
                   base.GetPersonInfo(); // Call the base class method to get person info
        }

        // method to update artist details
        public void UpdateArtistDetails(string stageName, string genre, int albumsReleased)
        {
            StageName = stageName;
            Genre = genre;
            AlbumsReleased = albumsReleased;
        }
        // override ToString method to return artist details
        public override string ToString()
        {
            return $"Artist ID: {ArtistId}, Stage Name: {StageName}, Genre: {Genre}, Albums Released: {AlbumsReleased}, " +
                   base.ToString(); // Call the base class ToString method
        }
    }
}
