using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ttsapp
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer _synthesizer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                this._synthesizer = new SpeechSynthesizer();
                this._synthesizer.Volume = Volume_TrackBar.Value;
                this._synthesizer.Rate = Rate_TrackBar.Value;

                foreach (var voice in this._synthesizer.GetInstalledVoices())
                {
                    if (voice.Enabled)
                    {
                        Voice_ComboBox.Items.Add(voice.VoiceInfo.Name);
                    }
                }
                Voice_ComboBox.SelectedIndex = 0;

                this._synthesizer.SelectVoice(Voice_ComboBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize speech synthesizer: " + ex.Message + "\r\n\r\n" + ex.StackTrace, "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
        }

        private void QR_Yes_Button_Click(object sender, EventArgs e)
        {
            string text = "";

            if (sender == QR_Dunno_Button)
            {
                text = "I don't know.";
            }
            else if (sender == QR_ExplainVoice_Button)
            {
                text = "For medical reasons I cannot speak for the time being, so I am using this computer assisted speech program to communicate.";
            }
            else if (sender == QR_Look_Button)
            {
                text = "Look here.";
            }
            else if (sender == QR_No_button)
            {
                text = "No";
            }
            else if (sender == QR_ThankYou_Button)
            {
                text = "Thank you.";
            }
            else if (sender == QR_Yes_Button)
            {
                text = "Yes";
            }

            Text_TextBox.Text = text;

            if (Speak_Button.Enabled)
            {
                Speak_Button.PerformClick();
            }

            Text_TextBox.SelectionStart = 0;
            Text_TextBox.SelectionLength = 0;
            Text_TextBox.SelectAll();
        }

        private void Text_TextBox_TextChanged(object sender, EventArgs e)
        {
            Speak_Button.Enabled = (Text_TextBox.Text.Trim().Length > 0);
        }

        private void Speak_Button_Click(object sender, EventArgs e)
        {
            _synthesizer.SpeakAsyncCancelAll();
            _synthesizer.SpeakAsync(Text_TextBox.Text);
            Text_TextBox.SelectionStart = 0;
            Text_TextBox.SelectionLength = 0;
            Text_TextBox.SelectAll();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Text_TextBox.Clear();
        }

        private void Rate_TrackBar_Scroll(object sender, EventArgs e)
        {
            this._synthesizer.Rate = Rate_TrackBar.Value;
        }

        private void Volume_TrackBar_Scroll(object sender, EventArgs e)
        {
            this._synthesizer.Volume = Volume_TrackBar.Value;
        }

        private void Voice_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._synthesizer.SelectVoice(Voice_ComboBox.SelectedItem.ToString());
        }

        private void Quit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
