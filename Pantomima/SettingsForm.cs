using System;
using System.Windows.Forms;

namespace Pantomima
{
    public partial class SettingsForm : Form
    {
        // Loads the Settings model to the Form.
        public SettingsManager settingsManager;

        public SettingsForm(SettingsManager settings)
        {
            InitializeComponent();
            settingsManager = settings;
            boxTimers.SetSelected(boxTimers.Items.IndexOf(settingsManager.seconds.ToString()), true);
            boxDifficulty.SetSelected(boxDifficulty.Items.IndexOf(settingsManager.difficulty), true);
            boxSounds.Checked = settingsManager.sounds;
        }

        public event EventHandler ButtonClicked;

        public void NotifyButtonClicked(EventArgs e)
        {
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
             
        private void btnSave_Click(object sender, EventArgs e)
        {
            settingsManager.difficulty = boxDifficulty.SelectedItem?.ToString();
            settingsManager.seconds = boxTimers.SelectedItem != null ? Convert.ToInt32(boxTimers.SelectedItem.ToString()) : settingsManager.seconds;
            settingsManager.sounds = boxSounds.Checked;
            settingsManager.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
