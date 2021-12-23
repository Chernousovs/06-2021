namespace AdApp
{
    public class TVAd: Advert
    {
        private int _airTimeSec, _poundPerSec;
        private bool _isPeakTime;
        public TVAd(int fee, int poundPerSec, int airTimeSec, bool isPeakTime) : base(fee)
        {
            _airTimeSec = airTimeSec;
            _poundPerSec = poundPerSec;
            _isPeakTime = isPeakTime;
        }
        
        public new int Cost() 
        {
            if (_isPeakTime)
            {
                return base.Cost() + _airTimeSec * _poundPerSec * 2;
            }
            return base.Cost() + _airTimeSec * _poundPerSec;
        }

        public override string ToString() 
        {
            return "\nTV advertisement: Fee = " + Cost();
        }
    }
}