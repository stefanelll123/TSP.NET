using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Event
{
    public partial class AddEvent : Form
    {
        private readonly ServiceImplementationClient _service;

        public AddEvent(ServiceImplementationClient service)
        {
            _service = service;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _service.AddEvent(
                new ServiceReference1.Event
                {
                    Id = Guid.NewGuid(),
                    Name = tbName.Text,
                });
            Close();
        }
    }
}
