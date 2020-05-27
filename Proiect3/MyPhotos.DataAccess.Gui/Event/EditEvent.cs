using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Event
{
    public partial class EditEvent : Form
    {
        private readonly IRepository<Model.Models.Event> _repository;
        private readonly Model.Models.Event _type;

        public EditEvent(IRepository<Model.Models.Event> repository, Model.Models.Event type)
        {
            _repository = repository;
            _type = type;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _repository.Update(_type, new Model.Models.Event()
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
