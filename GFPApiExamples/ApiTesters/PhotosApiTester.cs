using System;
using System.Net;
using System.Reflection;

namespace GFPApiExamples.ApiTesters
{
    public class PhotosApiTester : ApiTester
    {
        public int GetPhoto(int photoId)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(GetUrl("Photos/" + photoId));
                request.Method = "GET";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", string.Format("api-key {0}", ApiKey));
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    return (int)response.StatusCode;
                }

            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;
                if (response != null)
                    return (int)response.StatusCode;

                return 0;
            }
        }

        public int GetPhotos()
        {
            try
            {
                var request = (HttpWebRequest) WebRequest.Create(GetUrl("Photos"));
                request.Method = "GET";
                request.Accept = "application/json";
                request.ContentType = "application/json";
                request.Headers.Add("Authorization", string.Format("api-key {0}", ApiKey));
                using (var response = (HttpWebResponse) request.GetResponse())
                {
                    return (int) response.StatusCode;
                }

            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse) ex.Response;
                if (response != null)
                    return (int) response.StatusCode;

                return 0;
            }
        }

        public int PutLowResImage(int photoId)
        {
            try
            {
                var boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
                var request = (HttpWebRequest) WebRequest.Create(GetUrl("Photos/" + photoId + "/LowResImage"));
                request.ContentType = "multipart/form-data; boundary=" + boundary;
                request.Method = "PUT";
                request.KeepAlive = true;
                request.Headers.Add("Authorization", string.Format("api-key {0}", ApiKey));
                using (var requestStream = request.GetRequestStream())
                {
                    var boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                    requestStream.Write(boundarybytes, 0, boundarybytes.Length);

                    var header = string.Format("Content-Disposition: form-data; name=\"Image\"; filename=\"LowResImage.jpg\"\r\n Content-Type: application/octet-stream\r\n\r\n");
                    var headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                    requestStream.Write(headerbytes, 0, headerbytes.Length);

                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GFPApiExamples.LowResExample.jpg"))
                    {
                        var buffer = new byte[1024];
                        var bytesRead = 0;
                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                            requestStream.Write(buffer, 0, bytesRead);
                        requestStream.Write(boundarybytes, 0, boundarybytes.Length);
                    }

                    requestStream.Close();

                    using (var response = (HttpWebResponse) request.GetResponse())
                    {
                        return (int) response.StatusCode;
                    }
                }
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;
                if (response != null)
                    return (int)response.StatusCode;

                return 0;
            }
        }

        public int PutHighResImage(int photoId)
        {
            try
            {
                var boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
                var request = (HttpWebRequest)WebRequest.Create(GetUrl("Photos/" + photoId + "/HighResImage"));
                request.ContentType = "multipart/form-data; boundary=" + boundary;
                request.Method = "PUT";
                request.KeepAlive = true;
                request.Headers.Add("Authorization", string.Format("api-key {0}", ApiKey));
                using (var requestStream = request.GetRequestStream())
                {
                    var boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");
                    requestStream.Write(boundarybytes, 0, boundarybytes.Length);

                    var header = string.Format("Content-Disposition: form-data; name=\"Image\"; filename=\"HighResImage.jpg\"\r\n Content-Type: application/octet-stream\r\n\r\n");
                    var headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
                    requestStream.Write(headerbytes, 0, headerbytes.Length);

                    using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("GFPApiExamples.HighResExample.jpg"))
                    {
                        var buffer = new byte[1024];
                        var bytesRead = 0;
                        while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) != 0)
                            requestStream.Write(buffer, 0, bytesRead);
                        requestStream.Write(boundarybytes, 0, boundarybytes.Length);
                    }

                    requestStream.Close();

                    using (var response = (HttpWebResponse)request.GetResponse())
                    {
                        return (int)response.StatusCode;
                    }
                }
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;
                if (response != null)
                    return (int)response.StatusCode;

                return 0;
            }
        }

        private string GetUrl(string path)
        {
            return ServerHost.TrimEnd('/').TrimEnd('\\') + "/" + path;
        }
    }
}