using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts.MP_Selector
{

    [Serializable]
    public struct Control
    {
        public string Id;
        public int Active;
        public string InputJump;
        public string InputLeft;
        public string InputRight;
    }
}
