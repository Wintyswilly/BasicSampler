namespace ApplicationServices.Sampler
{
    using System.Diagnostics.Eventing.Reader;
    using System.Media;
    using WMPLib;

    public class SamplerControls : ISamplerControls
    {
        private SoundPlayer splayer;

        private WindowsMediaPlayer wMPlayer;

        private SoundPlayer SPlayer
        {
            get
            {
                if (splayer == null)
                {
                    splayer = new SoundPlayer();
                }

                return splayer;
            }
        }

        private WindowsMediaPlayer WMPLayer
        {
            get
            {
                if (wMPlayer == null)
                {
                    wMPlayer = new WMPLib.WindowsMediaPlayer();
                }

                return wMPlayer;
            }
        }

        public SamplerControls()
        {

        }

        public bool StopAnySoundPlaying()
        {
            SPlayer.Stop();
            WMPLayer.controls.stop();
            return true;
        }

        public void PlayWindowsMedia(string location)
        {

            WMPLayer.URL = location;
            WMPLayer.controls.play();
        }

        public void PlaySoundPlayer(string location)
        {
            SPlayer.SoundLocation = location;
            SPlayer.Play();
        }
    }
}