using System.Windows.Forms;
using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Api.Repositories;
using MyPhotos.DataAccess.Gui.Event;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Gui
{
    public partial class EventControl : Form
    {
        private IRepository<Model.Models.Event> repository;
        
        public EventControl()
        {
            InitializeComponent();
            repository = new EventRepository();
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddEvent(repository);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            eventBindingSource.DataSource = repository.GetAll();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as Model.Models.Event;
            var form = new EditEvent(repository, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Model.Models.Event row)
            {
                repository.Delete(row.Id);
            }
            Reload();
        }
    }
}
