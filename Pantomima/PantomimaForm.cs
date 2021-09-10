using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp;

namespace Pantomima
{
    public partial class PantomimaForm : Form
    {
        #region Notes to ADD
        //Katw apo to next player mporw na balw SETTINGS
        //Settings:
        //Hxoi, Timer(poso?), Difficulty mode, poses tainies na sou dinei (twra einai 3), xrwmata
        //Poses tainies exoun meinei (sto buffer) (isws na tis apothikevei se onoma xristi gia na thimatai poies exoun eipwthei gia na min ksanapesoun)
        //Na prosthetei tainies apo arxeio i na xrisimopoiei teleiws diaforetiko arxeio.
        //Na psaksw na to katebazw apo to google drive = AMAN MALAKA DIABASMA
        #endregion

        // This is the main Form of the game. 

        // Initializes settings and timer
        public static SettingsManager settingsManager = SettingsManager.Load();
        public TitleManager titleManager = new TitleManager(settingsManager);

        //here i define seconds for the timer.
        static int timeDefine = settingsManager.seconds;
        static int timeLeft = timeDefine;

        SettingsForm settings = new SettingsForm(settingsManager);

        public PantomimaForm()
        {
            InitializeComponent();

            // Makes the 'Previous' button disabled, since there are no previous movies.
            btnPrevious.Enabled = false;

            // Shows the timeLeft Total to the corresponding Label.
            lblTimer.Text = timeLeft.ToString();
            lblTimer.Font = new Font(lblTimer.Font.FontFamily, 11);

            // Calls GetNextPlayer to initiate the first player
            lblMovie.Text = titleManager.GetNextPlayer();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            lblMovie.Text = titleManager.NextChoice();
            btnNext.Enabled = titleManager.externalPositionIndex < (settingsManager.numberOfMovieChoices - 1);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            lblMovie.Text = titleManager.PreviousChoice();
            btnPrevious.Enabled = titleManager.externalPositionIndex > 0;
        }

        private void btnNextPlayer_Click(object sender, EventArgs e)
        {
            // Enable only the 'Next' button, since it will only show the first movie of the choices. Disable 'Previous' and hide 'Pause'
            btnNext.Enabled = true;
            btnPrevious.Enabled = false;
            btnPause.Visible = false;
            // Show the next movie choices. 
            lblMovie.Text = titleManager.GetNextPlayer();

            // Reset timer to the one chosen by the user in settings
            timeLeft = timeDefine;
            tmrCountdown.Stop();

            // Show time.
            lblTimer.Text = timeLeft.ToString();

            //Create as many instances as needed for the Downloader (netInfo)
            //NetInfo netInfo = new NetInfo();

            //You need to check if paths exist.
            //you need to see if the selected movies exist in wikipedia
            //goto programm-given panel @ wiki and download - image & description
            //netInfo.Download(netInfo.UrlToDownload, netInfo.DownloadDirectory + "test.jpg").DownloadCompleted += PantomimaForm_DownloadCompleted; 
        }

        //Wait until the image gets downloaded. Then set it to picBox
        private void PantomimaForm_DownloadCompleted(object sender, EventArgs e)
        {
            /*
             * thelw na krataei tis plirofories to netinfo pou tis pairnei apo to pantomimaform(???)
             * ap na tis epeksergazetai kai na ginetai event me to -> Otan to .DownloadCompleted +=
             * kai na epistrefei ta stoixeia
             * otan einai etoimo
             * sto swsto koumpi. Kai na allazei to picBox.ImageLocation
             * To koumpi tha perimenei i to netinfo?
             */

            //picBox.ImageLocation = ((HttpDownloader)sender).FullFileName;
        }

        //Choose movie. Start countdown. Disable buttons previous and next. Enable stop button.
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblMovie.Text)) 
            {
                lblTimer.Font = new Font(lblTimer.Font.FontFamily, 27);
                lblTimer.ForeColor = Color.FromArgb(255, 246, 229);
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
                titleManager.ClearChoices();
                tmrCountdown.Enabled = true;
                btnPause.Visible = true;
            }
        }

        // TODO: When user hits Pause, make the timer label red and small.
        //*** When user tries to 'Save' Settings it will work only if a movie isnt on a countdown, OR it must work only after the timer finishes.
        //*** When 'Pause' is pressed it should be replaced with 'Resume'. Not 'Choose'.
        //*** For some reason the timer drops by one and then stops after you hit 'Choose' (start or resume)

        //Set countdown. If it gets to 0 stop it.
        private void tmrCoudntdown_Tick_1(object sender, EventArgs e)
        {
            //** Na balw na min fainetai an de xrisimopoieitai to timer. Bebaia isws na min boithaei ton paixti.
            //** opote mporw na to exw mikro kai na megalwnei kata to Choose
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimer.Text = timeLeft.ToString();
            }
            //*** mporw na balw kai na kanei diafores sta teleutaia deutera. hxo h optiko
            if (timeLeft < 10)
            {
                lblTimer.ForeColor = Color.FromArgb(255, 49, 69);
            }
            else
            {
                tmrCountdown.Stop();
                tmrCountdown.Enabled = false;
                return;
            }
        }

        //Pause countdown. Disable pause button. That way the Choose button reapears
        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrCountdown.Stop();
            tmrCountdown.Enabled = false;
            btnPause.Visible = false;
            lblTimer.ForeColor = Color.FromArgb(255, 49, 69);
            //na ta energopoiw an mporoun na energopoiithoun 
            //exw balei na katharizei to choose tin lista........ den boithaei
            btnNext.Enabled = false;
            btnPrevious.Enabled = false;
        }

        //Opens the Settings form.
        private void lblSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settings.FormClosed += Settings_FormClosed;
            settings.ShowDialog(this);
        }

        //*** ATTENTION 
        // Refresh everything dependent on settings. Example timer. 
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            //*** need to make more settings
            settingsManager = ((SettingsForm)sender).settingsManager; 
            lblTimer.Text = settingsManager.seconds.ToString();
        }

         private void linkTutorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //pnlTutorial.Visible = true;
        }

    }
}
