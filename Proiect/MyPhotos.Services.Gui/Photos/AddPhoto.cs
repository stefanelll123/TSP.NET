using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Api;
using MyPhotos.DataAccess.Model.Models;

namespace MyPhotos.DataAccess.Gui.Photos
{
    public partial class AddPhoto : Form
    {
        private readonly IPhotoRepository _repository;
        private readonly IRepository<Model.Models.Type> _typeRepository;
        private readonly IRepository<Model.Models.Event> _eventRepository;
        private readonly IRepository<Model.Models.Person> _personRepository;
        private readonly IRepository<Places> _placeRepository;

        public AddPhoto(
            IPhotoRepository repository,
            IRepository<Model.Models.Type> typeRepository,
            IRepository<Model.Models.Event> eventRepository,
            IRepository<Model.Models.Person> personRepository,
            IRepository<Model.Models.Places> placeRepository
            )
        {
            _repository = repository;
            _typeRepository = typeRepository;
            _eventRepository = eventRepository;
            _personRepository = personRepository;
            _placeRepository = placeRepository;

            InitializeComponent();
        }

        private void AddPhoto_Load(object sender, System.EventArgs e)
        {
            typeBindingSource.DataSource = _typeRepository.GetAll();
            personBindingSource.DataSource = _personRepository.GetAll();
            placesBindingSource.DataSource = _placeRepository.GetAll();
            eventBindingSource.DataSource = _eventRepository.GetAll();
        }

        private void btnSelectFile_Click(object sender, System.EventArgs e)
        {
            var file = openFileDialog1.ShowDialog();
            lblPath.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var photo = new Model.Models.Photos
            {
                Id = Guid.NewGuid(),
                Name = tbName.Text,
                Path = lblPath.Text,
                CreationDate = DateTime.Now
            };


            var personId = ((Model.Models.Person) cbPersons.SelectedItem).Id;
            photo.People.Add(_personRepository.GetById(personId));

            var typeId = ((Model.Models.Type)cbTypes.SelectedItem).Id;
            photo.Types.Add(_typeRepository.GetById(typeId));

            var eventId = ((Model.Models.Event)cbEvent.SelectedItem).Id;
            photo.Event = _eventRepository.GetById(eventId);

            var placeId = ((Model.Models.Places)cbPlaces.SelectedItem).Id;
            photo.Places.Add(_placeRepository.GetById(placeId));

            _repository.Add(photo);
            Close();
        }
    }
}
