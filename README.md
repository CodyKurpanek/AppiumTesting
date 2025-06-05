# AppiumTesting
**Learning to use Appium for testing desktop applications.**

### Background
Appium follows the WC3 WebDriver specification, a specification initially created for interacting with web applications allowing consistent and scriptable access to all elements of a web page. This specification allows for automation and testing of these webpages.

Appium has built upon this specification, and extended its support beyond web platforms to any UI including desktop, mobile, and even embedded devices, allowing for a consistent automation interface among many types of UI. Appium also allows for developers to use any programming language of their choice for interfacing with the specification. 

Appium follows a Client-Server architecture for UI automation. A full Appium setup requires  (1) a client library, which is a library in your chosen programming language which allows for you to create requests conforming to the WebDriver Specification (2) the Appium server based on Node.js, which receives HTTP requests from the client library, and (3) a driver for your specific UI platform, which implements the WebDriver requests and interacts with the UI.


### My Setup
Prerequisite: windows machine or virtual machine.

Visual Studio environment with the .Net desktop development workload installed. To check your workloads or add this workload, you can go to your visual studio installer,



Download Node.js (includes npm). The Appium Server is built upon Node.js.\
https://nodejs.org/en/download


Get appium using npm in powershell
```powershell
npm i --location=global appium
```

Get the appium windows driver:
```powershell
appium driver install windows
```
