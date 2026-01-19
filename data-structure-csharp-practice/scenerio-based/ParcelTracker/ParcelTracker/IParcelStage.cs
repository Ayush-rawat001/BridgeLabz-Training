using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker.ParcelTracker
{
    internal interface IParcelStage
    {
        void TrackParcel();
        void AddCheckpoint(string after,string stage);

        void MarkParcelLost(string stage);

    }
}
