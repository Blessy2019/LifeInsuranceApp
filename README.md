# Life Insurance App

Project 


This is a Life Insurance Project allows users to choose various options provided on the screen , on the basis of their input values they can view the monthly premium calculated and 
would be diplayed on the screen.

The user need to provide the following inputs on the screen :
1) First Name
2) Last Name
3) Gender 
4) Date of Birth - Select from the calendar
5) Age - This will be calculated based on the Date of Birth you select and displayed on screen
6) Occupation - Select the appropriate occupation from the dropdown
7) Sum Insured - Amount in $

And then finally click the "Calculate Premium" and which you would display the premium calculated based on the user inputs.

# Steps for Project

1) Created a MVC .net core project 
2) Created the User Model with the properties required in application
3) Designed the View Page - using mvc form 
4) In Controller, added the code for filling the OccupationList dropdown on pageload itself.
5) In View page, for Date of Birth set the default date as "today" , which is done to perform calculation of age as you select the date.
6) Added validations for entire form. Since are the fields are mandatory.
7) On selecting a value from OccupationList dropdown , a jQuery AJAX function is called which returns the Rating Factor based on the Occupation and Occupation Rating mapping.
8) Also, added the Unit test cases in "LifeInsurance.Tests" Project.
9) On Calculate Premium Button Click - the total premium is calculated and displayed based on the below formula :

Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12

Occupation

Occupation  Rating
Cleaner     Light Manual
Doctor      Professional
Author      White Collar
Farmer      Heavy Manual
Mechanic    Heavy Manual
Florist     Light Manual

There is a factor associated with each rating as below,

Occupation Rating
Rating         Factor
Professional   1.0
White Collar   1.25
Light Manual   1.50
Heavy Manual   1.75

# Steps to access the Project

1) Copy the github.link and open in Visual Studio 
2) Mention a local path on your system where you want to clone the Git Repository.
3) Once done , build the solution and once cross-check do you have the bin\roslyn folder insdie project and then run the application. 
