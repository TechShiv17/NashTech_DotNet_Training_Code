using System.Diagnostics;

namespace Problem3
{
    public class Stopwatch
    {
        private TimeSpan _startTime;
        private bool _isRunning;

        public Stopwatch()
        {
            _isRunning = false;
            _startTime = TimeSpan.Zero;
        }

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }

            _isRunning = true;
            _startTime = TimeSpan.FromTicks(System.Diagnostics.Stopwatch.GetTimestamp());
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running.");
            }

            _isRunning = false;
        }

        public TimeSpan GetElapsedTime()
        {
            if (_isRunning)
            {
                return TimeSpan.FromTicks(System.Diagnostics.Stopwatch.GetTimestamp() - _startTime.Ticks);
            }
            else
            {
                return TimeSpan.FromTicks(_startTime.Ticks);
            }
        }
    }
}