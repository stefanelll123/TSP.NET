using System;
using System.Windows.Forms;

using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Person
{
    public partial class AddPerson : Form
    {
        private readonly IRepository<Model.Models.Person> _repository;

        public AddPerson(IRepository<Model.Models.Person> repository)
        {
            _repository = repository;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _repository.Add(
                new Model.Models.Person
                {
                    Id = Guid.NewGuid(),
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text
                });
            Close();
        }
    }
}
