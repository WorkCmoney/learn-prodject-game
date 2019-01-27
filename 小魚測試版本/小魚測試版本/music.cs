using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace 小魚測試版本
{
    class music
    {
        string Filename;
        public music(string fname)
        {
            Filename = fname;
        }

       
        
        public void Play()
        {
  
            try
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Filename);
                player.Play();
                              
            }
            catch(Exception ex)
            {

            }


        }
    }
}
