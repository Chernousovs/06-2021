using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdApp
{
    public class Poster : Advert
    {
        private int _numberOfCopies;
        private double _costPerCopy;
        private string _dimentionsType;

        public Poster(int fee, string dimentionsType, int numberOfCopies, double costPerCopy) : base(fee)
        {
            _costPerCopy = costPerCopy;
            _dimentionsType = dimentionsType;
            _numberOfCopies = numberOfCopies;
        }

        private int DimentionsTypeCheck()
        {
            int costPerType;

            switch (_dimentionsType)
            {
                case "Type A":
                    costPerType = 10;
                    break;
                case  "Type B":
                    costPerType = 25;
                    break;
                case "Type C":
                    costPerType = 50;
                    break;
                default:
                    costPerType = 70;
                    break;
            }

            return costPerType;
        }

        private new int Cost()
        {
            var fee = base.Cost() + DimentionsTypeCheck() * _numberOfCopies * _costPerCopy;
            return (int)fee;
        }

        public override string ToString()
        {
            return "\nPoster: Fee = " + Cost();
        }
    }
}
