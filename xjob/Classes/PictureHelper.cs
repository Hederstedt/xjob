using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace xjob.Classes
{
    public static class PictureHelper
    {
        public static byte[] CreatePlaceHolder(this String str)
        {           
            byte[] imageData = null;
            FileInfo fileInfo = new FileInfo(str);
            long imageLength = fileInfo.Length;
            using (FileStream fs = new FileStream(str, FileMode.Open, FileAccess.Read))
            {
                BinaryReader br = new BinaryReader(fs);
                imageData = br.ReadBytes((int)imageLength);
            };
            return imageData;
        }
    }
}
