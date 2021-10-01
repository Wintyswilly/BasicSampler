namespace ApplicationServices.Sampler
{
    public interface ISamplerControls
    {
        bool StopAnySoundPlaying();

        void PlayWindowsMedia(string location);

        void PlaySoundPlayer(string location);
    }
}