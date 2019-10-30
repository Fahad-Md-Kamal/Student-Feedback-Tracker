using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFeedbackTracker_00171328
{
    public partial class frmWordCloud : Form
    {
        Database1Entities db = new Database1Entities();
        Dictionary<string, int> DictionaryList = new Dictionary<string, int>();
        string[] cancelWords = {"i","you", "the","and","an","be", "a", "of", "this", "that", "on", "in", "am", "is", "are", "was", "were" };
        string[] words = { };

        public frmWordCloud()
        {
            InitializeComponent();
        }


        void WordColud()
        {
            var feedbacks = db.Feedbacks.Where(x => (x.Assessment.assDate >= dtpStrtDate.Value && x.Assessment.assDate <= dtpEndDate.Value)).Select(d => d.Description).ToList();

            foreach (var fdb in feedbacks.ToList())
            {
                words = fdb.Split(' ');
                var lower = words.Select(s => s.ToLowerInvariant()).ToArray();

                foreach (string word in lower)
                {
                    if (!cancelWords.Contains(word))
                    {
                   
                        if (!DictionaryList.ContainsKey(word))
                        {
                            DictionaryList.Add(word, 1);
                        }
                        else
                        {
                            DictionaryList[word] += 1;
                        }
                    }

                }
            }
            gv.DataSource = DictionaryList.ToList();
        }

        private void gv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = gv.Rows[e.RowIndex];
                lblWord.Text = row.Cells[0].Value.ToString().ToUpper();
                lblEndDate.Text = row.Cells[1].Value.ToString().ToUpper();
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {

            WordColud();
        }
    }
}
