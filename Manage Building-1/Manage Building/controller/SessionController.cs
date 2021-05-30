using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manage_Building.controller
{
    class SessionController
    {
        private readonly ConnectorClass dbConnection;

        public SessionController()
        {
            this.dbConnection = new ConnectorClass();
        }
    }
}
