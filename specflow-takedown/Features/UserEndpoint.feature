Feature: User endpoint tests
	So that I can consume correct user metadata
	As a consumer
	I want to be able to query the User Service for information

Scenario: Consumer hits the GET user metadata endpoint and is shown the correct metadata
	Given I am requesting user metadata
	When I make a request
	Then the response should include 10 users
	And each user should include the field "Id"
	And each user should include the field "Name"
	And each user should include the field "Username"
	And each user should include the field "Email"
	And each user should include the field "Phone"
	And each user should include the field "Website"