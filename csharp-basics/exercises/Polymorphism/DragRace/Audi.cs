using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int _currentSpeed = 0;

        public void SpeedUp() 
        {
            _currentSpeed += 15;
        }

        public int CurrentSpeed => _currentSpeed;

        public void SlowDown() 
        {
            _currentSpeed -= 15;
        }

        public string ShowCurrentSpeed() 
        {
            return _currentSpeed.ToString();
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}