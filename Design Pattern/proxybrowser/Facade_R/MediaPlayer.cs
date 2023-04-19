using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_R
{
    internal class MediaPlayer
    {
        public void Play(string format)
        {
            switch (format)
            {
                case "MP3":
                    MP3 mp3 = new();
                    mp3.Play();
                    break;
                case "MP4":
                    MP4 mp4 = new();
                    mp4.Play();
                    break;
                case "JPEG":
                    JPEG jpeg = new();
                    jpeg.Play();    
                    break;

                default:
                    break;
            }
        }
    }
}
