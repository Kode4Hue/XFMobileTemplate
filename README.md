# XFMobileTemplate
A Xamarin Forms Mobile Solution Template based on the principles of Clean Architecture. Feel free to grab it and use on your next Xamarin Forms Project.

**Disclaimer**
* This project was created with the intention of helping peope scaffold Xamarin Forms boilerplate code quicker with the principles of Clean Architecture intact. 
* This template aims to reflects the princples of clean architecture, however, some principles will be implemented or improved over time.

### Intented Use Cases: 
* Use this template as the foundation for creating Large/Enterprise-Grade Mobile Applications using Xamarin Forms.
* Use this Mobile App Template for reducing the need to write boilerplate code
* Use this template in scenarios where a development team seek to future-proof their Xamarin Forms codebase for easier transition to .NET MAUI.

### Prerequisites:
* [Download & Install](https://www.microsoft.com/net/download) .NET Core 3.1 or .NET 5.0 to gain access to the dotnet cli command
* [Download and Install](https://visualstudio.microsoft.com/downloads/) Visual Studio 2019 for Windows or for Mac
* Follow the 'Download and install' steps in the [Xamarin Getting Started Tutorial](https://dotnet.microsoft.com/learn/xamarin/hello-world-tutorial/install) for ensuring our Xamarin environment is setup on your Windows or Mac device.
  
### Installing this template:
* Clone this project and navigate to the directory containing this project
* Navigate to the directory containing this project via our command line or terminal (Windwows/Mac)
* Then execute `dotnet new --instal XfMobileTemplate` to install this template amongst our list of available templates.
* Finally, confirm that the template was installed correctly by executing `dotnet new --list` to view a list of all templates installed. You should see a project with 'Xamarin Forms Clean Architecture Template' with a shortname of 'XfMobileTemplate'.

### Starting a New Project from this Template:
* Navigate to the directory you would like to create the project in using Command Line or Terminal (Windows/Mac)
* Next we can generate our project by executing `dotnet new XfMobileTemplate -o YourProjectName` in the Command Line or Terminal
* Finally, Open your project in your Visual Studio for Windows or Mac instance.
* You are now ready to start building your Xamarin Forms Project with Clean Architecture Principles


### Clean Architecture Layers:
* Presentation:
  * XfMobileTemplate.Presn
  * XfMobileTemplate.Presn.Android
  * XfMobileTemplate.Presn.iOS
* Infrastructure:
  * XfMobileTemplate.CA.Infrastructure
* Application:
  * XfMobileTemplate.CA.Application
* Domain
  * XfMobileTemplate.CA.Domain

### Main Tech Stack:
* [Xamarin Forms 5](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/) 
* [Prism Library - MVVM, Events, NavigationService, etc](https://prismlibrary.com/)
* [Mediatr](https://github.com/jbogard/MediatR)
* [FluentValidation](https://fluentvalidation.net/)
* [JSON.NET](https://www.newtonsoft.com/json)

### Roadmap:
* 2022: Transition to .NET MAUI (once its released ofcourse)

### Credits:
* This template is highlighly influenced by Jason Taylor's [SPA Clean Architecture Solution Template](https://github.com/jasontaylordev/CleanArchitecture)
* Check out Damien Aicheh's [blog post](https://damienaicheh.github.io/xamarin/dotnet/templates/2018/06/12/xamarin-custom-template-en.html) on how to create your own Xamarin project template.
* Credits to [Khary Sharpe](https://www.linkedin.com/in/kharysharpe/) for introducing me to the concept of Clean Architecture back in 2015.
* Credits to the great [Uncle Bob](http://cleancoder.com/) for So providing amazing Enducational content on the concept of Clean Architecture. It has helped so many developers like myself understand how to write quality and maintainable code.
