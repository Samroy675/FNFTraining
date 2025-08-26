using System;
using System.Collections.Generic;
using System.Web.UI;

namespace SampleWebFormsApp
{
    public class WordEntry
    {
        public string Word { get; set; }
        public string Translation { get; set; }
    }

    public partial class MyWords : Page
    {
        static List<WordEntry> wordList = new List<WordEntry>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchWord = txtSearch.Text.Trim().ToLower();
            var found = wordList.Find(w => w.Word.ToLower() == searchWord);
            lblSearchResult.Text = found != null
                ? $"Translation: {found.Translation}"
                : "Word not found.";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim();
            string translation = txtTranslation.Text.Trim();

            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(translation))
            {
                wordList.Add(new WordEntry { Word = word, Translation = translation });
                txtWord.Text = "";
                txtTranslation.Text = "";
                BindGrid();
            }
        }

        private void BindGrid()
        {
            gvWords.DataSource = wordList;
            gvWords.DataBind();
        }
    }
}
