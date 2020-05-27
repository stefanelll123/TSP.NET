using System.Windows.Forms;
using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Api.Repositories;
using MyPhotos.DataAccess.Gui.Photos;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Gui
{
    public partial class PhotoControl : Form
    {
        private IPhotoRepository _repository;
        private readonly IRepository<Model.Models.Type> _typeRepository;
        private readonly IRepository<Model.Models.Event> _eventRepository;
        private readonly IRepository<Model.Models.Person> _personRepository;
        private readonly IRepository<Places> _placeRepository;

        public PhotoControl()
        {
            InitializeComponent();

            _repository = new PhotoRepository();
            _typeRepository = new TypeRepository();
            _eventRepository = new EventRepository();
            _placeRepository = new PlaceRepository();
            _personRepository = new PersonRepository();
        }

        private void ControlGenericForm_Load(object sender, System.EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var addForm = new AddPhoto(_repository, _typeRepository, _eventRepository, _personRepository, _placeRepository);
            addForm.ShowDialog();
            Reload();
        }

        private void Reload()
        {
            photosBindingSource.DataSource = _repository.GetAll();
        }

        private void btnEdit_Click(object sender, System.EventArgs e)
        {
            //var row = dataGridView1.SelectedRows[0].DataBoundItem as Model.Models.Event;
            //var form = new EditEvent(repository, row);
            //form.ShowDialog();
            //Reload();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Model.Models.Photos row)
            {
                _repository.Delete(row.Id);
            }
            Reload();
        }
    }
}
