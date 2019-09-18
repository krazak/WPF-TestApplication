using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class ImageSizeModel
    {
        private readonly Type _imageSizeType;
        private readonly string _name;

        public enum Type
        {
            Fill,
            LetterBox,
            PillarBox,
            Clip,
            OneToOne
        }

        public ImageSizeModel(string name, Type type)
        {
            _name = name;
            _imageSizeType = type;
        }

        public Type ImageSizeType
        {
            get { return _imageSizeType; }
        }
        public string Name
        {
            get { return _name; }
        }
    }
}
