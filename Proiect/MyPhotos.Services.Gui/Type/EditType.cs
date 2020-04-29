using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Type
{
    public partial class EditType : Form
    {
        private readonly ServiceImplementationClient _repository;
        private readonly ServiceReference1.Type _type;

        public EditType(ServiceImplementationClient repository, ServiceReference1.Type type)
        {
            _repository = repository;
            _type = type;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _repository.UpdateType(_type, new ServiceReference1.Type()
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
