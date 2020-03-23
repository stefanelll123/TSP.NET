using System;

namespace Lab001.Ex01.Library
{
    public class EventEmitter
    {
        public event EventHandler ThresholdReached;

        public void CallAllToExecute()
        {
            ThresholdReached(this, null);
        }
    }
}
