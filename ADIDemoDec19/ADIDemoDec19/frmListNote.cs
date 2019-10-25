using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIDemoDec19
{
    public partial class frmListNote : Form
    {
        Database1Entities db = new Database1Entities();
        
 
        public frmListNote()
        {
            InitializeComponent();
            LoadData();
        }

        private void frmListNote_Load(object sender, EventArgs e)
        {

        }


        private void LoadData()
        {
            var list = db.Notes.Where(d => d.uId == Tools.UserId).Select(d => new { d.Id, Note = d.Notes, Keywor = d.Feedback.Keywords }).ToList();           
            //var list = db.Notes.Select(d => new { d.Id, Note = d.Notes, d.Feedback.Keywords }).ToList();
            gv.DataSource = list;
        }


    }
}
