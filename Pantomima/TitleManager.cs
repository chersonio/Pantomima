using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pantomima
{
    /// <summary>
    /// Loads from settings the movies. 
    /// Keeps track of which movie is shown to the PantomimaForm
    /// Manages the movie choices the player will see and it clears when a next player appears
    /// </summary>
    public class TitleManager
    {
        #region Initialize settings/the movie file/the movie choices
        // Initializes settings
        SettingsManager settings { get; set; }

        // Creates a list of choices that will appear to the player.
        public List<string> choices = new List<string>();

        // Initializes the list that will buffer the movies.
        List<string> movieBuffer = new List<string>();

        private static Random _getRandom = new Random();

        // Keep an external position index so you can keep track on which choice is shown in the Pantomima form 
        public int externalPositionIndex = 0;
        #endregion

        /// <summary>
        /// Loads settings and adds the read movie(lines) from the document.
        /// </summary>
        /// <param name="settings"></param>
        public TitleManager(SettingsManager settings)
        {
            this.settings = settings;
            movieBuffer.AddRange(File.ReadAllLines(Directory.GetCurrentDirectory() + settings.MovieFilePath));
        }

        /// <summary>
        /// Clears the choices appeared to the player from the movie buffer.
        /// </summary>
        public void ClearChoices()
        {
            choices.RemoveAll(s => true);
        }

        /// <summary>
        /// Returns the next movie from the initialized choices, if there is one.
        /// </summary>
        /// <returns></returns>
        public string NextChoice()
        {
            return (externalPositionIndex++ < settings.numberOfMovieChoices) ? choices[externalPositionIndex] : choices[externalPositionIndex - 1];
        }

        /// <summary>
        /// Returns the previous movie from the initialized choices, if there is one.
        /// </summary>
        /// <returns></returns>
        public string PreviousChoice()
        {
            return (externalPositionIndex-- >= 0) ? choices[externalPositionIndex] : choices[externalPositionIndex + 1];
        }

        /// <summary>
        /// Clears previous choices and sets the new choices for the next Player
        /// </summary>
        /// <returns>New choices</returns>
        public string GetNextPlayer()
        {
            // Clears every choice from the buffer. (maybe this one should be on the PantomimaForm's button NextPlayer
            ClearChoices();
            externalPositionIndex = 0;

            // Resets the index of the position of choices depending on the number of movie choices it gets from settings.
            for (int i = 0; i < settings.numberOfMovieChoices; i++)
            {
                // Sets new choices.
                choices.Add(movieBuffer[_getRandom.Next(0, movieBuffer.Count - 1)]);
            }

            // Deletes the new choices from the buffer.
            movieBuffer.RemoveAll(m => choices.Contains(m));
            return choices[externalPositionIndex];
        }
    }
}
