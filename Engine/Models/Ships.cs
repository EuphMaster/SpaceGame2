using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.models
{
    class Ships
    {
        public string ShipName { get; set; }
        
        public void Ship()
        {

            var ship1 = new Ships();
            ship1.ShipName = "Enterprise";

            var ship2 = new Ships();
            ship2.ShipName = "Defiant";

        }
    }
}
