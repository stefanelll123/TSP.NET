using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Type
{
    public partial class EditType : Form
    {
        private readonly IRepository<Model.Models.Type> _repository;
        private readonly Model.Models.Type _type;

        public EditType(IRepository<Model.Models.Type> repository, Model.Models.Type type)
        {
            _repository = repository;
            _type = type;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _repository.Update(_type, new Model.Models.Type()
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
