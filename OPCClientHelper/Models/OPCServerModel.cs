using CommonLibrary;
using OPC.Common;
using OPCDA.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCClientHelper.Models
{
    public class OPCServerModel : BaseNotificationObject
    {
        /// <summary>
        /// Server Computer Name
        /// </summary>
        public Host Host { get; set; }

        /// <summary>
        /// OPC Server Name
        /// </summary>
        public string OPCServerName { get; set; }

        private bool _IsOPCServerConnected = false;
        /// <summary>
        /// Client is Connected to Server or not
        /// </summary>
        public bool IsOPCServerConnected
        {
            get
            {
                return _IsOPCServerConnected;
            }
            set
            {
                _IsOPCServerConnected = value;
                OnPropertyChanged("IsOPCServerConnected");
            }
        }

        private OpcServer _OpcServerInstance = new OpcServer();
        public OpcServer OpcServerInstance
        {
            get
            {
                return _OpcServerInstance;
            }
            set
            {
                _OpcServerInstance = value;
                OnPropertyChanged("OpcServerInstance");
            }
        }

        private List<string> _OPCServerAllItems;
        public List<string> OPCServerAllItems
        {
            get
            {
                return _OPCServerAllItems;
            }
            set
            {
                _OPCServerAllItems = value;
                OnPropertyChanged("OPCServerAllItems");
            }
        }
    }
}
