using System;
using System.Collections.Generic;
using System.Text;

namespace domain.objects
{
    public class StorableItem
    {
        public int Id { get; private set; }

        public StorableItem(int id)
        {
            Id = id;
        }
    }
}
