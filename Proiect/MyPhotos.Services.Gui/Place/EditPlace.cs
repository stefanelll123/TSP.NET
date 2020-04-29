using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Place
{
    public partial class EditPlace : Form
    {
        private readonly ServiceImplementationClient _service;
        private readonly Places _type;

        public EditPlace(ServiceImplementationClient service, Places type)
        {
            _service = service;
            _type = type;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _service.UpdatePlace(_type, new Places()
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
