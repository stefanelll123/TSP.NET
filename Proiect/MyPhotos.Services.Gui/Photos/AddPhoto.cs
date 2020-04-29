using System;
using System.Windows.Forms;
using MyPhotos.DataAccess.Gui.ServiceReference1;

namespace MyPhotos.DataAccess.Gui.Photos
{
    public partial class AddPhoto : Form
    {
        private readonly ServiceImplementationClient _service;

        public AddPhoto(ServiceImplementationClient service)
        {
            _service = service;

            InitializeComponent();
        }

        private void AddPhoto_Load(object sender, System.EventArgs e)
        {
            typeBindingSource.DataSource = _service.GetAllTypes();
            personBindingSource.DataSource = _service.GetAllPersons();
            placesBindingSource.DataSource = _service.GetAllPlaces();
            eventBindingSource.DataSource = _service.GetAllEvents();
        }

        private void btnSelectFile_Click(object sender, System.EventArgs e)
        {
            var file = openFileDialog1.ShowDialog();
            lblPath.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var photo = new ServiceReference1.Photos
            {
                Id = Guid.NewGuid(),
                Name = tbName.Text,
                Path = lblPath.Text,
                CreationDate = DateTime.Now
            };


            var personId = ((ServiceReference1.Person) cbPersons.SelectedItem).Id;
            photo.People[photo.People.Length] = _service.GetPersonById(personId);

            var typeId = ((ServiceReference1.Type)cbTypes.SelectedItem).Id;
            photo.Types[photo.Types.Length] = _service.GetTypeById(typeId);

            var eventId = ((ServiceReference1.Event)cbEvent.SelectedItem).Id;
            photo.Event = _service.GetEventById(eventId);

            var placeId = ((Places)cbPlaces.SelectedItem).Id;
            photo.Places[photo.Places.Length] = _service.GetPlaceById(placeId);

            _service.AddPhoto(photo);
            Close();
        }
    }
}
