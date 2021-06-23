
# AnimeBattleGenerator
## QA Application Project 2🌐





**Contents**

1. [ Brief. ](#brief)
2. [ Architecture. ](#Architecture)
3. [ Project Tracking. ](#projecttracking)
4. [ Risk Assessment. ](#riskassessment)
5. [ Testing. ](#testing)
6. [ Front-End Design. ](#frontenddesign)
7. [ Known Issues. ](#knownissues)
8. [ Future Improvements. ](#futureimprovements)
9. [ Authors. ](#authors)







<a name="brief"></a>
## 1. Brief
For this brief I have been asked to create an application that generates "Objects" upon a set of predefined rules. It requires a service orientated architecture which must be composed of at least 4 services that work together. Service 1 renders a HTML, service 2 and 3 both generate a random "Object" and service 4 will also create and object that's based on the result of service 2 and 3.

**Additional Requirements**

In addition to the requirements set out in the brief, I am also required to include the following:

- A Trello board (or equivalent Kanban board tech) with full expansion
 on user stories, use cases and tasks needed to complete the project.
 It could also provide a record of any issues or risks that I faced
 creating my project.
- Clear Documentation from a design phase describing the architecture
 I used for my project as well as a detailed Risk Assessment.
- Create two different implementations for service 2,3 and 4.
-   An Application fully integrated using the Feature-Branch model into a Version Control System which will subsequently be built through a CI server and deployed to a cloud-based environment.
 -   If a change is made to a code base, then Webhooks should be used so that Azure Pipelines recreates and redeploys the changed application
 - Applications and services should be deployed using azure as a cloud platform.

## 2. My Approach

To meet the requirements of the brief, I have produced a MVC Web application using the .NET Framework Core that that must allow the user to do the following:

 - Create a service that generates a class of anime classes and a second service that creates a class of anime clans. The third service would then generate a final combination of both classes which merges their stats that is then displayed on the front end.

<a name="Architecture"></a>
## 3. Architecture

**Database Structure**

Pictured below is an entity relationship diagram (ERD) showing the structure of the database.

ERD:

![Alt text](/ProjectImages/ERD.PNG "ERD")



**CI Pipeline**

![Alt text](/ReadmeImages/image005.PNG "Pipeline")

The picture above shows the structure of my CI Pipeline. It works from using my local machine and push the code to GitHub which is linked to my Azure Web Apps which has continuous integration using GitHub Actions. I also used a terraform script to create my App Services and App Plan on azure which will update each time a change is pushed to my main branch on GitHub. This virtually means there is next to no downtime once the process is complete.

<a name="projecttracking"></a>
##**Project Tracking**

Trello was used to track the progress of the project (pictured below). You can find the link to this board here: [QA Project 2 | Trello](https://trello.com/invite/b/1NeeAYvM/45ba408c76c6e07c09cee17f80159988/generator-project)

![Alt text](/ProjectImages/Trello.PNG "Trello Board")

The board has been designed and structured to move from left to right from of the project implementation. The summary of each card is stated below

- Backlog [User Stories]:  A list of requirements set out in the brief in order for this to be a successful project.
- _Project Resources:_ List of relevant resources
- _User Stories:_  Any functionality that is implemented into the project first begins as a user story. This keeps the development of every element of the web app focused on the user experience first.
- _Planning:_ is the section where decisions are being made on what needs to be implemented next
- _In Progress_: shows what&#39;s currently being worked on
- _Testing:_ once a feature has been implemented it goes onto the testing stage
- _Finished_ : this section contains the features that have passed the testing stage and made it to production

<a name="riskassessment"></a>
## 4. Risk Assessment

The risk assessment matrix for this project can be found below in the screenshot :

![Alt text](/ProjectImages/RiskAssessment.PNG "Risk ssessment")


<a name="testing"></a>
## 4. Testing

Only one of the controllers for this application was tested using xUnit testing alongside with a code coverage report addon. The controller test included Repository patterns, Moq implementation to mock the controller behavior.

Below is a screenshot of the coverage report :

![Alt text](/Projectmages/test1.PNG "Test Coverage 1")

<a name="frontenddesign"></a>
## 5. Front-End Design

When the web app is first launched the user will be brought to this home page:

![Alt text](/ProjectImages/FrontEnd.PNG "Home")

Here are also some Swagger Screenshots of the Services:
Class API:
![Alt text](/ProjectImages/ClassAPI.PNG "ClassAPI")
Clan API:
![Alt text](/ProjectImages/ClanAPI.PNG "ClanAPI")
FaceOffAPI:
![Alt text](/ProjectImages/FaceOffAPI.PNG "FaceOffAPI")


<a name="knownissues"></a>
## 6. Known Issues

There aren't any issues I'm currently aware of...

<a name="futureimprovements"></a>
## 7. Future Improvements

For future improvements outside of my existing bugs I would like to:

- Add a more satisfying UI
- A feature where it generates two characters at once and compares their stats as well.
- Implement Angular


<a name="authors"></a>
## 8. Authors

Keneil Jordan
