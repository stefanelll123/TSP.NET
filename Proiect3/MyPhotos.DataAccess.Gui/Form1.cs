using System;
using System.Windows.Forms;

namespace MyPhotos.DataAccess.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            var form = new PersonControl();
            form.ShowDialog();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            var form = new TypeControl();
            form.ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            var form = new EventControl();
            form.ShowDialog();
        }

        private void btnPlaces_Click(object sender, EventArgs e)
        {
            var form = new PlaceControl();
            form.ShowDialog();
        }

        private void btnPhotos_Click(object sender, EventArgs e)
        {
            var form = new PhotoControl();
            form.ShowDialog();
        }
    }
}
