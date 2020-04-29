using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.Place;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui
{
    public partial class PlaceControl : Form
    {
        private ServiceImplementationClient service;
        
        public PlaceControl()
        {
            InitializeComponent();
            service = new ServiceImplementationClient();
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddPlace(service);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            placesBindingSource.DataSource = service.GetAllPlaces();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as Places;
            var form = new EditPlace(service, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Places row)
            {
                service.DeletePlace(row.Id);
            }
            Reload();
        }
    }
}
