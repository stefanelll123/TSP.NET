using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Event
{
    public partial class AddEvent : Form
    {
        private readonly IRepository<Model.Models.Event> _repository;

        public AddEvent(IRepository<Model.Models.Event> repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repository.Add(
                new Model.Models.Event
                {
                    Id = Guid.NewGuid(),
                    Name = tbName.Text,
                });
            Close();
        }
    }
}
