using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantomima
{
    public class TitleManager
    {
        SettingsManager settings { get; set; }
        public List<string> choices = new List<string>();
        List<string> movieBuffer = new List<string>();

        private static Random _getRandom = new Random();
        public int externalPositionIndex = 0;

        public TitleManager(SettingsManager settings)
        {
            this.settings = settings;
            movieBuffer.AddRange(File.ReadAllLines(Directory.GetCurrentDirectory() + settings.MovieFilePath));
        }

        public void ClearChoices()
        {
            //katharizei tis epiloges apo to kentriko pinaka gia na mi mporeis na tis ksanabreis.

            choices.RemoveAll(s => true);
        }

        public string NextChoice()
        {
            return (externalPositionIndex++ < settings.numberOfMovieChoices) ? choices[externalPositionIndex] : choices[externalPositionIndex - 1];
        }

        public string PreviousChoice()
        {
            return (externalPositionIndex-- >= 0) ? choices[externalPositionIndex] : choices[externalPositionIndex + 1];
        }

        public string GetNextPlayer()
        {
            //xrisimopoiei to clear giati o proigoumenos paixtis isws eixe dei tainies
            //mhdenizei ta cnt kai pointer.
            ClearChoices();
            externalPositionIndex = 0;
            for (int i = 0; i < settings.numberOfMovieChoices; i++)
            {
                choices.Add(movieBuffer[_getRandom.Next(0, movieBuffer.Count - 1)]);
            }
            movieBuffer.RemoveAll(m => choices.Contains(m));
            return choices[externalPositionIndex];
        }
    }
}
