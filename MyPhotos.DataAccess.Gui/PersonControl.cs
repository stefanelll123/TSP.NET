using System.Windows.Forms;
using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Api.Repositories;
using MyPhotos.DataAccess.Gui.Person;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Gui
{
    public partial class PersonControl : Form
    {
        private IRepository<Model.Models.Person> repository;
        
        public PersonControl()
        {
            InitializeComponent();
            repository = new PersonRepository(new MyPhotosModelContainer());
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddPerson(repository);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            personBindingSource.DataSource = repository.GetAll();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as Model.Models.Person;
            var form = new EditPerson(repository, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Model.Models.Person row)
            {
                repository.Delete(row.Id);
            }
            Reload();
        }
    }
}
