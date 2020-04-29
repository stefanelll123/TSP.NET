using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Person
{
    public partial class AddPerson : Form
    {
        private readonly ServiceImplementationClient _service;

        public AddPerson(ServiceImplementationClient service)
        {
            _service = service;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _service.AddPerson(
                new ServiceReference1.Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text
                });
            Close();
        }
    }
}
