namespace R3BinderTools.Helpers
{
    using System;
    using System.IO;
    using System.Media;

    public static class MusicPlay
    {
        public static void Inizialize(UnmanagedMemoryStream stream)
        {
            try
            {
                using var snd = new SoundPlayer(stream);
                snd?.Load();
                if (snd.IsLoadCompleted)
                {
                    snd.Play();
                }
            }
            catch (Exception ex) { File.WriteAllText(Path.Combine(GlobalPath.CurrDir, "ErrorPlay.txt"), ex.Message); }
        }
    }
}