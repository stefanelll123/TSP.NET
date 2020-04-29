using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Place
{
    public partial class AddPlace : Form
    {
        private readonly ServiceImplementationClient _service;

        public AddPlace(ServiceImplementationClient service)
        {
            _service = service;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _service.AddPlace(
                new Places
                {
                    Id = Guid.NewGuid(),
                    Name = tbName.Text,
                });
            Close();
        }
    }
}
