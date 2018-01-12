﻿using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Lunalipse.Common.Data
{
    public class MusicEntity
    {
        public string id;
        public string Album, Name, ID3Name, Extension, Path, Year;
        public string[] Artist;
        public BitmapSource AlPic;

        public string AllArtist
        {
            get
            {
                return Artist[0];
            }
        }

        public string MusicName
        {
            get
            {
                return Name;
            }
        }

        public string IDv23Name
        {
            get
            {
                return ID3Name;
            }
        }

        public BitmapSource Picture
        {
            get
            {
                return AlPic;
            }
        }
    }
}
