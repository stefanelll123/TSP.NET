using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Place
{
    public partial class AddPlace : Form
    {
        private readonly IRepository<Model.Models.Places> _repository;

        public AddPlace(IRepository<Model.Models.Places> repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repository.Add(
                new Model.Models.Places
                {
                    Id = Guid.NewGuid(),
                    Name = tbName.Text,
                });
            Close();
        }
    }
}
