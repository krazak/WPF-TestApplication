using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class MBModel
    {
   
        static readonly public Dictionary<ImageSizeModel.Type, ImageSizeModel> ImageSizeMap =
            new Dictionary<ImageSizeModel.Type, ImageSizeModel>()
            {
                { ImageSizeModel.Type.Clip, new ImageSizeModel("Clip", ImageSizeModel.Type.Clip) },
                { ImageSizeModel.Type.Fill, new ImageSizeModel("Fill", ImageSizeModel.Type.Fill)  },
                { ImageSizeModel.Type.LetterBox, new ImageSizeModel("LetterBox", ImageSizeModel.Type.LetterBox) },
                { ImageSizeModel.Type.OneToOne, new ImageSizeModel("OneToOne", ImageSizeModel.Type.OneToOne) },
                { ImageSizeModel.Type.PillarBox, new ImageSizeModel("PillarBox", ImageSizeModel.Type.PillarBox) }
            };

        static readonly public Dictionary<LayoutTypeModel.Type, LayoutTypeModel> LayoutTypeMap =
            new Dictionary<LayoutTypeModel.Type, LayoutTypeModel>()
            {
                { LayoutTypeModel.Type.One, new LayoutTypeModel(LayoutTypeModel.Type.One, "One") },
                { LayoutTypeModel.Type.Two, new LayoutTypeModel(LayoutTypeModel.Type.Two, "Two") },              
                { LayoutTypeModel.Type.Three, new LayoutTypeModel(LayoutTypeModel.Type.Three, "Three") }
            };
       
    }
} 
