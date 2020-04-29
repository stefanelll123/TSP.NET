using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.Photos;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui
{
    public partial class PhotoControl : Form
    {
        private ServiceImplementationClient _repository;

        public PhotoControl()
        {
            InitializeComponent();

            _repository = new ServiceImplementationClient();
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddPhoto(_repository);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            photosBindingSource.DataSource = _repository.GetAllPhotos();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            //var row = dataGridView1.SelectedRows[0].DataBoundItem as Event;
            //var form = new EditEvent(repository, row);
            //form.ShowDialog();
            //Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is ServiceReference1.Photos row)
            {
                _repository.DeletePhoto(row.Id);
            }
            Reload();
        }
    }
}
