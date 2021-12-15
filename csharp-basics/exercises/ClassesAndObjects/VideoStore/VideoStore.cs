using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class VideoStore
    {

        private List<Video> listOfTitles = new List<Video>();

        public VideoStore()
        {
            
        }

        public void AddVideo(string title)
        {
            listOfTitles.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            if (listOfTitles.Any(x => x.Title == title))
            {
                listOfTitles.First(x => x.Title == title).BeingCheckedOut();
            } 
        }

        public void ReturnVideo(string title)
        {
            if (listOfTitles.Any(x => x.Title == title))
            {
                listOfTitles.First(x => x.Title == title).BeingReturned();
            }
        }

        public void TakeUsersRating(double rating, string title)
        {
            if (listOfTitles.Any(x => x.Title == title))
            {
                listOfTitles.First(x => x.Title == title).ReceivingRating(rating);
            }
        }

        public void ListInventory()
        {
            foreach (var video in listOfTitles)
            {
                Console.WriteLine(video.ToString());
            }
        }
    }
}
