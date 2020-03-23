using System.Windows.Forms;
using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Api.Repositories;
using MyPhotos.DataAccess.Gui.Type;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Gui
{
    public partial class TypeControl : Form
    {
        private IRepository<Model.Models.Type> repository;
        
        public TypeControl()
        {
            InitializeComponent();
            repository = new TypeRepository(new MyPhotosModelContainer());
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddType(repository);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            typeBindingSource.DataSource = repository.GetAll();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as Model.Models.Type;
            var form = new EditType(repository, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Model.Models.Type row)
            {
                repository.Delete(row.Id);
            }
            Reload();
        }
    }
}
