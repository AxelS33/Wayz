using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WaysServices
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    public class WayService : IWayService1
    {
        private Services.Services services;


        public StgMsg.StgMsg checkSecurity(StgMsg.StgMsg msg)
        {
            switch (msg.pSecurity)
            {
                case "qsdqsd":
                    this.callServices(msg);
                    break;
                default:
                    return msg;
            }
            return msg;
        }

        private StgMsg.StgMsg callServices(StgMsg.StgMsg msg)
        {
            switch (msg.servName)
            {
                case "Admin":
                    this.services = new Services.Admin();
                    this.services.launchServices(msg);
                    break;
                case "WaysGame":
                    this.services = new Services.WaysGame();
                    this.services.launchServices(msg);
                    break;
                case "WaysOriention":
                    this.services = new Services.WaysOriention();
                    this.services.launchServices(msg);
                    break;
                default:
                    return msg;      
            }
            return msg;
        }

   
    }
}
