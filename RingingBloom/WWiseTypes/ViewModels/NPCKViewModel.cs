﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RingingBloom.Common;

namespace RingingBloom
{
    class NPCKViewModel
    {
        public ObservableCollection<Wem> wems;

        public NPCKViewModel(List<Wem> npck)
        {
            wems = new ObservableCollection<Wem>(npck);
        }

    }
}