using System.Collections.ObjectModel;
using System.Windows;

namespace DynamicScriptControl
{
    public class Attribute
    {

        public string Key { get; set; }
        public string Value { get; set; }
        private string _formatString;
        public string FormatString
        {
            get
            {
                if (_formatString.IsEmpty())
                    _formatString = "{0}";
                return _formatString;
            }
            set { _formatString = value; }
        }

        public string ToCode(string formatString)
        {
            return string.Format(formatString, Key, string.Format(FormatString, Value));
        }
    }

    public class AttributeCollection : ObservableCollection<Attribute>
    {
        
    }
}