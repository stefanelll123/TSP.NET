using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.Event;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui
{
    public partial class EventControl : Form
    {
        private ServiceImplementationClient repository;
        
        public EventControl()
        {
            InitializeComponent();
            repository = new ServiceImplementationClient();
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
            eventBindingSource.DataSource = repository.GetAllEvents();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as ServiceReference1.Event;
            var form = new EditEvent(repository, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is ServiceReference1.Event row)
            {
                repository.DeleteEvent(row.Id);
            }
            Reload();
        }
    }
}
