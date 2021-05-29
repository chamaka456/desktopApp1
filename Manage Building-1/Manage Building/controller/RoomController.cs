using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.controller
{
    public class RoomController
    {
        private readonly ConnectorClass dbConnection;

        public RoomController()
        {
            dbConnection = new ConnectorClass();
        }

        public bool AddNewRoom()
        {
            return false;
        }
    }
}
