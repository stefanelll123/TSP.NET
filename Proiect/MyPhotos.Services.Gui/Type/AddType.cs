using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Type
{
    public partial class AddType : Form
    {
        private readonly ServiceImplementationClient _service;

        public AddType(ServiceImplementationClient service)
        {
            _service = service;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _service.AddType(
                new ServiceReference1.Type
                {
                    Id = Guid.NewGuid(),
                    Name = tbName.Text,
                });
            Close();
        }
    }
}
