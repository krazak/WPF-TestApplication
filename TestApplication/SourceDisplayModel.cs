using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class SourceDisplayModel
    {
        private bool _displaySrcName;
        public enum Type
        {
            SDI_1,
            SDI_2,
            SDI_3,
            SDI_4,
            CV_1,
            CV_2,
            CV_3,
            DVI_1,
            DVI_2,
            VGA_1,
            VGA_2,
            None1,
            None2,
            None3
        }

        public SourceDisplayModel()
        {
            SourceName = "";
            DisplayName = "";
            _displaySrcName = false;
            PersistantDisplay = false;
        }

        public Type InputType { get; set; }
        public string SourceName { get; set; }
        public string DisplayName { get; set; }
        public bool DisplaySrcName {
            get
            {
                return _displaySrcName;
            }
            set
            {
                if (value)
                {
                    DisplayName = SourceName;
                }
                else
                {
                    DisplayName = InputType.ToString();
                }
                _displaySrcName = value;
            }
        }
        public bool PersistantDisplay { get; set; }
    }
}
