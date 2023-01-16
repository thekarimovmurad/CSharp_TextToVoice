using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_TextToVoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region OpenTetx
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //string filePath = "C:/Users/theka/Desktop/TEXT.txt";
            //synth.SetOutputToDefaultAudioDevice();
            //using (StreamReader sr = new StreamReader(filePath))
            //{
            //    string fileContent = sr.ReadToEnd();
            //    synth.Speak(fileContent);
            //}
            #endregion

            #region ConsoleRead
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            //synth.SetOutputToDefaultAudioDevice();
            //string text=Console.ReadLine();
            //synth.Speak(text);
            #endregion

            #region ChanceSound
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
            //synth.Volume = 100;
            //synth.Rate = 1;
            //synth.SetOutputToDefaultAudioDevice();
            //foreach (var voice in synth.GetInstalledVoices())
            //{
            //    if (voice.VoiceInfo.Gender == VoiceGender.Male && voice.VoiceInfo.Age == VoiceAge.Adult)
            //    {
            //        synth.SelectVoice(voice.VoiceInfo.Name);
            //        break;
            //    }
            //}
            //synth.Speak("Text read ");
            #endregion
        }
    }
}
