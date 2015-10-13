using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExpressionTesting
{
    public class SimpleMonitor : IDisposable
    {
        // Fields
        private int _busyCount;

        // Methods
        public void Dispose()
        {
            Leave();
        }

        public void Enter()
        {
            this._busyCount++;
        }

        public void Leave()
        {
            this._busyCount--;
        }

        public IDisposable Start
        {
            get
            {
                Enter();
                return this;
            }
        }

        // Properties
        public bool Busy
        {
            get
            {
                return (this._busyCount > 0);
            }
        }

        public int Count
        {
            get { return this._busyCount; }
        }

        public void ActionIfNotBusy(Action action)
        {
            if (!Busy)
            {
                try
                {
                    Enter();
                    action();
                }
                finally
                {
                    Leave();
                }

            }
        }

        public static implicit operator bool(SimpleMonitor monitor)
        {
            return monitor.Busy;
        }
    }
}
