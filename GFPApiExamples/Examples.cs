using System;
using System.Windows.Forms;
using GFPApiExamples.ApiTesters;

namespace GFPApiExamples
{
    public partial class Examples : Form
    {
        public Examples()
        {
            InitializeComponent();
        }

        private void uploadLowResImage_Click(object sender, EventArgs e)
        {
            var apiTester = CreateApiTester<PhotosApiTester>();
            if (apiTester == null) return;

            var photoId = GetPhotoId();
            if (photoId == -1) return;

            HandleResponse(apiTester.PutLowResImage(photoId));
        }

        private void putHighResImage_Click(object sender, EventArgs e)
        {
            var apiTester = CreateApiTester<PhotosApiTester>();
            if (apiTester == null) return;

            var photoId = GetPhotoId();
            if (photoId == -1) return;

            HandleResponse(apiTester.PutHighResImage(photoId));
        }

        private void getPhotos_Click(object sender, EventArgs e)
        {
            var apiTester = CreateApiTester<PhotosApiTester>();
            if (apiTester == null) return;

            HandleResponse(apiTester.GetPhotos());
        }

        private void getPhoto_Click(object sender, EventArgs e)
        {
            var apiTester = CreateApiTester<PhotosApiTester>();
            if (apiTester == null) return;

            var photoId = GetPhotoId();
            if (photoId == -1) return;

            HandleResponse(apiTester.GetPhoto(photoId));
        }

        private int GetPhotoId()
        {
            var photoId = 0;
            if (!int.TryParse(validPhotoId.Text, out photoId))
            {
                MessageBox.Show("Please enter a valid photo Id");
                return -1;
            }

            return photoId;
        }

        private void HandleResponse(int statusCode)
        {
            switch (statusCode)
            {
                case 0:
                    MessageBox.Show("Invalid Server Address");
                    break;

                case 404:
                    MessageBox.Show("404 - Not Found returned. Are you sure you have entered the Server Address correctly?");
                    break;

                case 200:
                case 201:
                    MessageBox.Show("Request completed successfully!");
                    break;
                 
                case 500:
                    MessageBox.Show("An error has occured on the server. Please check the Server Address and if this is correct please report the issue with GFP.");
                    break;

                case 401:
                    MessageBox.Show("401 - Unauthorized returned. Are you sure you have entered the API Key correctly?");
                    break;
                  
                case 422:
                    MessageBox.Show("422 - Unprocessable Entity returned. Are you using the latest version of the GFP Api Examples code?");
                    break;

                default:
                    MessageBox.Show(statusCode + " returned. This status code is unexpected?");
                    break;
            }

        }

        private T CreateApiTester<T>()
            where T : ApiTester, new()
        {
            if (string.IsNullOrEmpty(serverAddress.Text.Trim()))
                MessageBox.Show("You must provide a valid Server Address to the GFP API.");

            if (string.IsNullOrEmpty(apiKey.Text.Trim()))
                MessageBox.Show("You must provide a valid API Key to the GFP API.");

            var apiTester = new T();
            apiTester.ServerHost = serverAddress.Text;
            apiTester.ApiKey = apiKey.Text;

            return apiTester;
        }
    }
}
