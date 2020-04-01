using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Type
{
    public partial class AddType : Form
    {
        private readonly IRepository<Model.Models.Type> _repository;

        public AddType(IRepository<Model.Models.Type> repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repository.Add(
                new Model.Models.Type
                {
                    Id = Guid.NewGuid(),
                    Name = tbName.Text,
                });
            Close();
        }
    }
}
