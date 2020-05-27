using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;

namespace MyPhotos.DataAccess.Gui.Person
{
    public partial class EditPerson : Form
    {
        private readonly IRepository<Model.Models.Person> _repository;
        private readonly Model.Models.Person _person;

        public EditPerson(IRepository<Model.Models.Person> repository, Model.Models.Person person)
        {
            _repository = repository;
            _person = person;
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _repository.Update(_person, new Model.Models.Person
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
