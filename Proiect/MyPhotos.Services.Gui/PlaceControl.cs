using System.Windows.Forms;
using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Api.Repositories;
using MyPhotos.DataAccess.Gui.Place;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Gui
{
    public partial class PlaceControl : Form
    {
        private IRepository<Places> repository;
        
        public PlaceControl()
        {
            InitializeComponent();
            repository = new PlaceRepository();
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddPlace(repository);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            placesBindingSource.DataSource = repository.GetAll();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as Places;
            var form = new EditPlace(repository, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Places row)
            {
                repository.Delete(row.Id);
            }
            Reload();
        }
    }
}
