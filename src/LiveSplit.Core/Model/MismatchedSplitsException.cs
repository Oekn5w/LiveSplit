using System;

namespace LiveSplit.Model
{
    public class MismatchedSplitsException : Exception
    {
        public int index;
        public string splitNameHibernated;
        public string splitNameCurrent;
        public MismatchedSplitsException(int index, string splitNameHibernated, string splitNameCurrent)
        {
            this.index = index;
            this.splitNameHibernated = splitNameHibernated;
            this.splitNameCurrent = splitNameCurrent;
        }
    }
}
