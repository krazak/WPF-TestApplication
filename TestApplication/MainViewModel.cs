using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class MainViewModel
    {
        public List<ImageSizeModel> ImageSizeTypes
        {
            get { return MBModel.ImageSizeMap.Values.ToList(); }
        }

        public List<LayoutTypeModel> LayoutTypes
        {
            get { return MBModel.LayoutTypeMap.Values.ToList(); }
        }

        public LayoutTypeModel SelectedItem1 { get; set; }

        public LayoutTypeModel SelectedItem2 { get; set; }
    }
}
