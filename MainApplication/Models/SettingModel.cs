using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafireHub.Models
{
    public class SettingModel: BaseNotificationObject
    {
        private ObservableCollection<TextBoxModel> _SettingViewCollection;
        public ObservableCollection<TextBoxModel> SettingViewCollection
        {
            get
            {
                return this._SettingViewCollection;
            }
            set
            {
                this._SettingViewCollection = value;
                OnPropertyChanged("SettingViewCollection");
            }
        }
    }
    public class TextBoxModel: BaseNotificationObject
    {
        public string BitName { get; set;}
        private string _BitTextValue;
        public string BitTextValue
        {
            get
            {
                return this._BitTextValue;
            }
            set
            {
                this._BitTextValue = value;
                OnPropertyChanged("BitTextValue");
            }
        }
        public string Unit { get; set; }
        public int Tag { get; set; }
    }
}
