using CommonLibrary;
using OPCClientHelper.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SafireHub.Models
{
    public class MainModel: BaseNotificationObject
    {
        private int _OPCServerCount;
        /// <summary>
        /// Display in MainWindow
        /// </summary>
        public int OPCServerCount
        {
            get
            {
                return this._OPCServerCount;
            }
            set
            {
                this._OPCServerCount = value;
                OnPropertyChanged("OPCServerCount");
            }
        }

        private bool _IsWebServiceAlive = false;
        public bool IsWebServiceAlive
        {
            get
            {
                return this._IsWebServiceAlive;
            }
            set
            {
                this._IsWebServiceAlive = value;
                OnPropertyChanged("IsWebServiceAlive");
            }
        }

        private ObservableCollection<OPCServerModel> _OPCServerListCollection;
        /// <summary>
        /// Display in MainWindow
        /// </summary>
        public ObservableCollection<OPCServerModel> OPCServerListCollection
        {
            get
            {
                return this._OPCServerListCollection;
            }
            set
            {
                this._OPCServerListCollection = value;
                OnPropertyChanged("OPCServerListCollection");
            }
        }

        private string _LogContent = string.Empty;
        public string LogContent
        {
            get
            {
                return this._LogContent;
            }
            set
            {
                this._LogContent = value;
                OnPropertyChanged("LogContent");
            }
        }

        private string _RunBtnToolTip = "Run";
        public string RunBtnToolTip
        {
            get
            {
                return this._RunBtnToolTip;
            }
            set
            {
                this._RunBtnToolTip = value;
                OnPropertyChanged("RunBtnToolTip");
            }
        }

        private List<DataModel> _SecondDataModelList;
        /// <summary>
        /// Send to WebService every second
        /// </summary>
        public List<DataModel> SecondDataModelList
        {
            get
            {
                return this._SecondDataModelList;
            }
            set
            {
                this._SecondDataModelList = value;
                OnPropertyChanged("SecondDataModelList");

            }
        }

        private List<DataModel> _MinuteDataModelList;
        /// <summary>
        /// Send to WebService every minute
        /// </summary>
        public List<DataModel> MinuteDataModelList
        {
            get
            {
                return this._MinuteDataModelList;
            }
            set
            {
                this._MinuteDataModelList = value;
                OnPropertyChanged("MinuteDataModelList");
            }
        }

        private List<DataModel> _HourDataModelList;
        /// <summary>
        /// Send to WebService every hour
        /// </summary>
        public List<DataModel> HourDataModelList
        {
            get
            {
                _HourDataModelList = new List<DataModel>();
                return this._HourDataModelList;
            }
            set
            {

                this._HourDataModelList = value;
                OnPropertyChanged("HourDataModelList");
            }
        }
        private List<DataModel> _EventDataModelList;
        /// <summary>
        /// Send to WebService once occurred
        /// </summary>
        public List<DataModel> EventDataModelList
        {
            get
            {
                return this._EventDataModelList;
            }
            set
            {
                this._EventDataModelList = value;
                OnPropertyChanged("EventDataModelList");
            }
        }
    }

    public class DataModel
    {
        public string ComputerName { get; set; }
        public string ServerName { get; set; }
        public string SendDataTime { get; set; }
        public string SendDataName { get; set; }
        public string SendDataValue { get; set; }
    }
}
