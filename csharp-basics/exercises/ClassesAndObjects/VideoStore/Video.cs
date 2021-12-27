using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    public class Video
    {
        private string _title;
        private bool _isAvalible;
        private List<double> ratingList = new List<double>();

        public Video(string title)
        {
            _title = title;
            _isAvalible = true;
        }

        public void BeingCheckedOut()
        {
            _isAvalible = false;
        }

        public void BeingReturned()
        {
            _isAvalible = true;
        }

        public void ReceivingRating(double rating)
        {

            ratingList.Add(rating);
        }

        public double AverageRating()
        {
            return ratingList.Any() ? ratingList.Sum() / ratingList.Count() : 0;
        }

        public bool Available()
        {
            return _isAvalible;
        }

        public string Title => _title;

        public override string ToString()
        {
            return $"{Title} | Average rating: {AverageRating()} | {(Available() ? "Available NOW" : "Unavailable" )}";
        }
    }
}
