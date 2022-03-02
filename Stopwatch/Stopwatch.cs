using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    internal class Stopwatch
    {
        private Boolean _isStart; //Used to check whether the stopwatch is running.
        private DateTime _startTime; //_startTime and _stopTime : are DateTime objects that are used to record the start time and stop time respectively.
        private DateTime _stopTime;
        private TimeSpan _timeSpan; //_timeSpan is a TimeSpan object, as the name suggestes it stores the time span between start and stop times.

        public void Start()
            {
                if (_isStart)
                {
                    throw new InvalidOperationException();
                }

                _startTime = DateTime.Now;
                _isStart = true;

            }

            public string Stop()
            {
                if (!_isStart)
                {
                    throw new InvalidOperationException();
                }
                _stopTime = DateTime.Now;
                _timeSpan = _stopTime - _startTime;
                _isStart = false;

                return _timeSpan.Seconds.ToString();
            }




        }


	
}


/*
i) Read the input from the user.
ii) If the input is start -> start the stopwatch
If the input is stop -> throw an InvalidOperation exception
iii) Read another input from the user
iv) If the input is stop -> stop the stopwatch and print the time span
If the input is start -> throw an InvalidOperation exception
v) Repeat from step (i).


 */