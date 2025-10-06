# webbrowser

## Overview
This project is a Windows thin client application that utilizes WebView2 to display web content. It connects to a remote URL and provides a simple browsing experience.

## Project Structure
```
webbrowser
├── src
│   └── WebBrowserThinClient
│       ├── WebBrowserThinClient.csproj
│       ├── App.xaml
│       ├── App.xaml.cs
│       ├── MainWindow.xaml
│       ├── MainWindow.xaml.cs
│       ├── Views
│       │   └── BrowserView.xaml
│       ├── ViewModels
│       │   └── MainViewModel.cs
│       ├── Services
│       │   └── WebViewService.cs
│       └── Properties
│           └── AssemblyInfo.cs
├── WebBrowserThinClient.sln
├── .gitignore
└── README.md
```

## Setup Instructions
1. Clone the repository to your local machine.
2. Open the solution file `WebBrowserThinClient.sln` in your preferred IDE.
3. Restore the NuGet packages required for the project.
4. Build the solution to ensure all dependencies are correctly configured.

## Usage
- Run the application to launch the main window.
- The application will display the specified remote URL in the WebView2 control.
- You can navigate to different URLs as needed.

## Dependencies
- WebView2: Ensure that the WebView2 runtime is installed on your machine to run this application.

## Contributing
Feel free to submit issues or pull requests for any enhancements or bug fixes.