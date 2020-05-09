using SpellingCorrector;
using System;
using System.Windows.Forms;

namespace SpellingCorrection
{
    public partial class SpellingCorrector : Form
    {
        Spelling spelling;

        public SpellingCorrector()
        {
            InitializeComponent();
            spelling = new Spelling();
        }

        private void ButtonWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WordBox.Text))
                return;

            WordResultText.Text = "Correct form is '" + spelling.Correct(WordBox.Text) + "'";
        }

        private void SentenceButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SentenceBox.Text))
                return;

            string sentence = SentenceBox.Text;
            string correction = null;

            foreach (string item in sentence.Split(' '))
            {
                correction += " " + spelling.Correct(item);
            }

            SentenceResultText.Text = "Correct form is: " + correction;
        }
    }
}
