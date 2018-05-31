# UmbracoTrialTest "AcmeCorporation"
An ASP.NET website allowing users to entera draw for prizes. A person can enter a draw if they have a valid serial number and an age more than 18 years old.
They also can draw up to twice per valid serial number.

To start the project after you clone it, is to execute the file "acmeDB.sql"  in an SQL Server instance and the entire database will be set up automatically.
After that, don't forget to change the connection string for the one you executed the queries.

The solution in Visual Studio is buid in 2 different projects: the "ClassLibrary" holding the repository and separate the model from the controllers and the views, and the "UmbracoTrialTest" web applicaton project.

Once the database and the web applications are running, the first page will present the list of all the submitions taken from the database.
To have the submition page you need to type the following URL:"http://localhost:62434/PrizeDrawer/NewSubmition" and there you will be able to insert the
 information and if all the conditions are fulfilled ( such as your age is above 18, you haven’t requested a product more than two times) you will be able to submit and the information will be added to the list.
 
