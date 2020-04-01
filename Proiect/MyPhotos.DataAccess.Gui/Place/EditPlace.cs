using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Place
{
    public partial class EditPlace : Form
    {
        private readonly IRepository<Model.Models.Places> _repository;
        private readonly Model.Models.Places _type;

        public EditPlace(IRepository<Model.Models.Places> repository, Model.Models.Places type)
        {
            _repository = repository;
            _type = type;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _repository.Update(_type, new Model.Models.Places()
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
