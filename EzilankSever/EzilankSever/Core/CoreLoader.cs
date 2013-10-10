using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EzilankSever.Object;
using System.Collections;
namespace EzilankSever.Core
{
    class CoreLoader
    {
        
        private ArrayList al;
        public CoreLoader()
        {
            InitPlayerDic();
        }
        public void InitPlayerDic()
        {
           
            DBConnect dbc = new DBConnect();
            al = dbc.SelectPlayer();
            for (int i = 0; i < al.Count;i++ )
            {
                SetPlayer(al[i] as Dictionary<string, string>);
            }
           
            
        }
        private void SetPlayer(Dictionary<string, string> dc)
        {
            Dictionary<string, string> hs = al[0] as Dictionary<string, string>;
            Player p1 = new Player();
            p1.Id = dc["Id"];
            p1.Name = dc["Name"];
            p1.Level = dc["Level"];
            p1.AttMax = dc["AttMax"];
            p1.AttMin = dc["AttMin"];
            p1.ManaMax = dc["ManaMax"];
            p1.ManaCurrent = dc["ManaCurrent"];
            p1.Money = dc["Money"];
            p1.Point = dc["Point"];
            p1.UserId = dc["UserId"];
            p1.AttMax = dc["AttMax"];
            p1.CurrExp = dc["CurrExp"];
            ActivePlayerPool.addActivePlayer(p1.Id, p1);
        }
    }
}
