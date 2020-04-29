using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;
using MyPhotos.DataAccess.Gui.Type;

namespace MyPhotos.DataAccess.Gui
{
    public partial class TypeControl : Form
    {
        private ServiceImplementationClient service;
        
        public TypeControl()
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
            var addForm = new AddType(service);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            typeBindingSource.DataSource = service.GetAllTypes();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            var row = dataGridView1.SelectedRows[0].DataBoundItem as ServiceReference1.Type;
            var form = new EditType(service, row);
            form.ShowDialog();
            Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is ServiceReference1.Type row)
            {
                service.DeleteType(row.Id);
            }
            Reload();
        }
    }
}
