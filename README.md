# AppiumTesting
Learning to use Appium for testing desktop applications.

### Background
Appium follows the WC3 WebDriver specification, a specification initially created for interacting with web applications allowing consistent and scriptable access to all elements of a web page. This specification allows for automation and testing of these webpages.

Appium has built upon this specification, and extended its support beyond web platforms to any UI including desktop, mobile, and even embedded devices, allowing for a consistent automation interface among many types of UI. Appium also allows for developers to use any programming language of their choice for interfacing with the specification. 

Appium follows a Client-Server architecture for UI automation. A full Appium setup requires  (1) a **client library**, which is a library in your chosen programming language which allows for you to create requests conforming to the WebDriver Specification (2) the **Appium server** based on Node.js, which receives HTTP requests from the client library, and (3) a **driver** for your specific UI platform, which implements the WebDriver requests and interacts with the UI.


### My Setup
Prerequisite: windows machine or virtual machine.

Prerequisite: Visual Studio environment with the .Net desktop development workload installed. To check your workloads or add this workload, you can go to your visual studio installer,



Download Node.js (includes npm). The Appium Server is built upon Node.js.\
https://nodejs.org/en/download


Get the Appium **Server**
```powershell
npm i --location=global appium
```

Get the **Drivers** for Windows Desktop Apps.\
1. Appium’s Drivers:
```powershell
appium driver install windows
```
2. Download Microsoft’s WinAppDrivers which Appium extends for it’s Server from:\
https://github.com/Microsoft/WinAppDriver/releases

Access the .Net **client library** for Appium\
In Visual Studio: Tools > NuGet Package manager > Manage NuGet Packages for Solution\
Then install the Appium.WebDriver.\
While you’re at it get xunit for testing as well.


Install appium inspector. This allows you to open a desktop app through appium and see properties in real time for elements you interact with. Helpful for determining the properties of elements, and how to call them when automating or testing. Install from:\
https://github.com/appium/appium-inspector



### Running the code

I am running the code within the Visual Studio ide as a project.

First, you need to start the Appium server. Open a terminal and type appium. You will see output that your server has been started and can be accessed at http://192.168.1.235:4723/

Set the solution or project you want to run, then click the play button and execution will begin from main, as it is set up as a Visual Studio project. (Honestly I'm not too sure good practice for Solutions and Projects and how they are organized but for now the only runnable thing is the calculator.csproj so select that.)
