using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Event
{
    public partial class EditEvent : Form
    {
        private readonly ServiceImplementationClient _service;
        private readonly ServiceReference1.Event _type;

        public EditEvent(ServiceImplementationClient service, ServiceReference1.Event type)
        {
            _service = service;
            _type = type;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _service.UpdateEvent(_type, new ServiceReference1.Event()
            {
                Name = tbName.Text,
            });
            Close();
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            tbName.Text = _type.Name;
        }
    }
}
