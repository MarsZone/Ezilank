using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EzilankSever.Object
{
    class ActivePlayerPool
    {
        public static Dictionary<string, Player> PlayerDic = new Dictionary<string, Player>();

        public static void addActivePlayer(string id,Player p1)
        {
            PlayerDic.Add(id,p1);
        }
    }

}
