using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.controller
{
    public class BuildingController
    {
        private readonly ConnectorClass dbConnection;

        public BuildingController()
        {
            dbConnection = new ConnectorClass();
        }

        public bool AddNewBuilding()
        {
            return false;
        }
    }
}
