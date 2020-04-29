using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.Person;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui
{
    public partial class PersonControl : Form
    {
        private ServiceImplementationClient service;
        
        public PersonControl()
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
            var addForm = new AddPerson(service);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            personBindingSource.DataSource = service.GetAllPersons();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as ServiceReference1.Person;
            var form = new EditPerson(service, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is ServiceReference1.Person row)
            {
                service.DeletePerson(row.Id);
            }
            Reload();
        }
    }
}
