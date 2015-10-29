Feature: Photo endpoint tests
	So that I can consume correct photo metadata
	As a consumer
	I want to be able to query the Photo Service for information

Scenario: Consumer hits the GET photo metadata endpoint and is shown the correct metadata
	Given I am requesting photo metadata
	When I make a request
	Then the response should include 5000 photos
	And each photo should include the field "AlbumId"
	And each photo should include the field "Id"
	And each photo should include the field "Title"
	And each photo should include the field "Url"
	And each photo should include the field "ThumbnailUrl"