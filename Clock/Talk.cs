using System;
using System.Media;
using System.Threading;

namespace Clock
{
    class Talk
    {
        private static string path = "audio\\";
        private static bool talking = false;

        public Talk()
        {
            
        }

        public void PlayFile(string name)
        {
            SoundPlayer sp = new SoundPlayer(path + name);
            sp.PlaySync();
        }

        public void TalkTime(DateTime dt)
        {
            if (talking) return;
            Thread thread = new Thread(Run);
            thread.IsBackground = true;
            talking = true;
            thread.Start(dt);
        }

        private void Run(object param)
        {
            int hh = ((DateTime)param).Hour;
            int mm = ((DateTime)param).Minute;
            PlayFile(hh.ToString("00") + "hh.wav");
            if (mm == 0) PlayFile("zero.wav");
            else if (mm < 20) PlayFile(mm.ToString("00") + "mm.wav");
            else
            {
                int m1 = mm / 10;
                int m2 = mm % 10;
                PlayFile(m1 + "0.wav");
                PlayFile("0" + m2 + "mm.wav");
            }
            talking = false;
        }
    }
}
