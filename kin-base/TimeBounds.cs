// This file was modified by Kin Ecosystem (2019)


using System;
using Kin.Base.xdr;

namespace Kin.Base
{
    public class TimeBounds
    {
        ///<summary>
        ///Timebounds constructor.
        ///</summary>
        ///<param name="minTime"> 64bit Unix timestamp, 0 if unset</param>
        ///<param name="maxTime"> 64bit Unix timestamp, 0 if unset</param>
        public TimeBounds(long minTime, long maxTime)
        {
            if (maxTime != 0 && minTime >= maxTime)
                throw new ArgumentException("minTime must be >= maxTime");

            MinTime = minTime;
            MaxTime = maxTime;
        }

        ///<summary>
        ///Timebounds constructor.
        ///</summary>
        ///<param name="minTime"> earliest time the transaction is valid from</param>
        ///<param name="maxTime"> latest time the transaction is valid to</param>
        public TimeBounds(DateTimeOffset? minTime = null, DateTimeOffset? maxTime = null)
        {
            if (maxTime != null && minTime >= maxTime)
                throw new ArgumentException("minTime must be >= maxTime");

            var minEpoch = minTime?.ToUnixTimeSeconds() ?? 0;
            var maxEpoch = maxTime?.ToUnixTimeSeconds() ?? 0;

            MinTime = minEpoch;
            MaxTime = maxEpoch;
        }

        public long MinTime { get; }

        public long MaxTime { get; }

        public static TimeBounds FromXdr(xdr.TimeBounds timeBounds)
        {
            if (timeBounds == null)
            {
                return null;
            }

            return new TimeBounds(
                timeBounds.MinTime.InnerValue.InnerValue,
                timeBounds.MaxTime.InnerValue.InnerValue
            );
        }

        public xdr.TimeBounds ToXdr()
        {
            var timeBounds = new xdr.TimeBounds();
            var minTime = new Uint64();
            var maxTime = new Uint64();
            minTime.InnerValue = MinTime;
            maxTime.InnerValue = MaxTime;
            timeBounds.MinTime = new TimePoint(minTime);
            timeBounds.MaxTime = new TimePoint(maxTime);
            return timeBounds;
        }

        public override bool Equals(Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;

            TimeBounds that = (TimeBounds) o;

            if (MinTime != that.MinTime) return false;
            return MaxTime == that.MaxTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Start
                .Hash(MinTime)
                .Hash(MaxTime);
        }
    }
}
