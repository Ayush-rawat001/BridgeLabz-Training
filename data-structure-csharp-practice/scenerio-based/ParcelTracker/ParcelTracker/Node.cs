using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker.ParcelTracker
{
    class Node
    {
            public string Stage;
        
            public Node Next;

            public Node(string stage)
            {
                Stage = stage;
                Next = null;
            }
    }

}

