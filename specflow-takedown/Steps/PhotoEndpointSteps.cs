using System.Collections.Generic;
using EasyHttp.Http;
using Shouldly;
using specflow_takedown.Classes;
using specflow_takedown.Models;
using TechTalk.SpecFlow;

namespace specflow_takedown.Steps
{
    [Binding]
    public class PhotoEndpointSteps
    {
        private PhotoService _photoService = new PhotoService();
        private HttpClient _httpClient = new HttpClient();
        private HttpResponse _response;
        private IList<Photo> _photos = new List<Photo>();

        [Given(@"I am requesting photo metadata")]
        public void GivenIAmRequestingPhotoMetadata()
        {
            _photoService.Uri = "http://jsonplaceholder.typicode.com/photos";
        }
        
        [When(@"I make a request")]
        public void WhenIMakeARequest()
        {
            _httpClient.Request.Accept = HttpContentTypes.ApplicationJson;
            _response = _httpClient.Get(_photoService.Uri);            
        }
        
        [Then(@"the response should include (.*) photos")]
        public void ThenTheResponseShouldIncludePhotos(int count)
        {
            _photos = _response.StaticBody<IList<Photo>>();
            _photos.Count.ShouldBe(count);
        }
        
        [Then(@"each photo should include the field ""(.*)""")]
        public void EachPhotoShouldIncludeTheField(string fieldName)
        {
            foreach(Photo photo in _photos)
            {
                var outcome = photo.GetType().GetProperty(fieldName);
                outcome.ShouldNotBeNull();
            }
        }
    }
}
