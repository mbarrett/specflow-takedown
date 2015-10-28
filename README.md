specflow-takedown
===================

A clean and cutdown template for writing acceptance tests against API endpoints.

##Usage

Ensure you have installed the Visual Studio integration packages for Specflow as documented here <a href="http://www.specflow.org/getting-started">http://www.specflow.org/getting-started</a>

To run an acceptance test:

* Build the solution
* Open the desired feature file located within the Features folder
* Right click the feature or scenario title
* Click 'Run Specflow Scenarios'

Even better use the command line:

* Navigate to the root of the specflow-takedown project (cd [file_location]\specflow-takedown\specflow-takedown)
* Execute the command line test runner by typing 'runtests.cmd' and hit [Enter]

##Troubleshooting

The acceptance tests make a GET request to various endpoints within <a href="http://jsonplaceholder.typicode.com">jsonplaceholder.typicode.com<a/>. In case of request timeouts please check your connection to jsonplaceholder.typicode.com. 

##Credits	

Shout outs to <a href="https://github.com/hhariri/EasyHttp">EasyHttp<a/>, <a href="https://github.com/shouldly/shouldly">Shouldly<a/> and <a href="http://www.specflow.org/">Specflow<a/>.
