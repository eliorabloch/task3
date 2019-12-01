using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskthree
{
    public class HostingUnit
    {
        public string UnitName;
        public int Rooms;
        public bool IsSwimmimgPool;
        public List<DateTime> AllOrders { get; set; }
        public List<string> Uris { get; set; }
        public HostingUnit()
        {
            Uris = new List<string>() { "https://www.google.com/search?q=hotel+pictures&source=lnms&tbm=isch&sa=X&ved=2ahUKEwiLgO_e55TmAhVL_aQKHdHiBEEQ_AUoAXoECAkQAw&biw=1422&bih=678&dpr=2.25#imgrc=gfZ92jZ_5xcsRM:" };

        }

    }
}
