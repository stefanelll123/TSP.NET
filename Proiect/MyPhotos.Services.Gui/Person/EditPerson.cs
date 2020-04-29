using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Person
{
    public partial class EditPerson : Form
    {
        private readonly ServiceImplementationClient _service;
        private readonly ServiceReference1.Person _person;

        public EditPerson(ServiceImplementationClient service, ServiceReference1.Person person)
        {
            _service = service;
            _person = person;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _service.UpdatePerson(_person, new ServiceReference1.Person
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text
            });
            Close();
        }

        private void EditPerson_Load(object sender, EventArgs e)
        {
            tbFirstName.Text = _person.FirstName;
            tbLastName.Text = _person.LastName;
        }
    }
}
