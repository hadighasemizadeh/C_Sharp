using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDiffence
{
    class GameException:Exception
    {
        public GameException(){}
        public GameException(string msg) : base(msg)
        {

        }
    }
    class OutOfMap : GameException
    {
        public OutOfMap(){}
        public OutOfMap(string msg) : base(msg)
        {

        }
    }
}
