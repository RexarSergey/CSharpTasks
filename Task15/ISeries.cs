using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    internal interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }

    internal class ArithProgression : ISeries
    {
        int startVal_;
        int step_;
        int currVal_;

        public int GetNext()
        {
            currVal_ += step_;
            return currVal_;
        }

        public void Reset()
        {
            currVal_ = startVal_;
        }

        public void SetStep(int x)
        {
            step_ = x;
        }

        public void SetStart(int x)
        {
            startVal_ = x;
            currVal_ = startVal_;
        }
    }

    internal class GeomProgression : ISeries
    {
        int startVal_;
        int step_;
        int currVal_;

        public int GetNext()
        {
            currVal_ *= step_;
            return currVal_;
        }

        public void Reset()
        {
            currVal_ = startVal_;
        }

        public void SetStep(int x)
        {
            step_ = x;
        }

        public void SetStart(int x)
        {
            startVal_ = x;
            currVal_ = startVal_;
        }
    }
}
