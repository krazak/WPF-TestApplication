using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class LayoutTypeModel
    {
        private readonly Type _layoutType;
        private readonly string _name;
        public enum Type
        {
            One,
            Two,
            Three
        }

        public LayoutTypeModel(Type type, string name)
        {
            _layoutType = type;
            _name = name;
        }
        public Type LayoutType { get { return _layoutType; } }
        public string Name {  get { return _name; } }
    }
}
