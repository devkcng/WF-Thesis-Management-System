using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFThesisManagementSystem.Forms.StudentViews.StudentUserControl
{
    public partial class UCCalendar : UserControl
    {
        public int month= DateTime.Now.Month, year = DateTime.Now.Year;
        public event EventHandler previousPtbClicked;
        public event EventHandler nextPtbClicked;
        public UCCalendar()
        {
            InitializeComponent();
            this.ptbNext.Click += NextPtb_Click;
            this.ptbPrevious.Click += PreviousPtb_Click;
        }

        private void PreviousPtb_Click(object sender, EventArgs e)
        {
            OnpreviousPtbClicked(EventArgs.Empty);
        }
        protected virtual void OnpreviousPtbClicked(EventArgs e)
        {
            previousPtbClicked?.Invoke(this, e);
        }

        private void NextPtb_Click(object sender, EventArgs e)
        {
            OnnextPtbClicked(EventArgs.Empty);
        }

        protected virtual void OnnextPtbClicked(EventArgs e)
        {
            nextPtbClicked?.Invoke(this, e);
        }
    }
}
