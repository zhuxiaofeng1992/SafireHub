using OPC.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCClientHelper.Models
{
    public class HostModel
    {
        /// <summary>
        ///Include HostName/UserName/Password/Domain
        /// </summary>
        public Host Host { get; set; }
        public string OPCServerName { get; set; }
        public bool IsOPCServerConnected { get; set; }
    }
}
