# DatingApp
VS Code Extension
1.
2.GitHub Pull Requests and Issues

![image](https://user-images.githubusercontent.com/20635839/110594570-f9c42b00-81a2-11eb-8371-7d7dd3471afe.png)
![image](https://user-images.githubusercontent.com/20635839/110702673-d8058b00-8218-11eb-8205-b216341e4640.png)


## Steps to create the Project
1. Create a Folder Dating App
2. Create new solution File (dotnet new sln)
3. Create a WEB API Project inside a new folder API (dotnet new webapi -o API)
4. Add api project to sln (dotnet sln add API)
5. Make the browser trust the https certificate provided by the dotnet sdk (dotnet dev-certs https --trust)


Angular:
1. Indtall Angular CLI globally
2. 
Troubleshoot
1. fatal: unable to access 'https://github.com/suniladhya/DatingApp.git/': SSL certificate problem: self signed certificate in certificate chain: git config --global http.sslbackend schannel
2. fatal: unable to access 'https://github.com/suniladhya/DatingApp.git/': schannel: next InitializeSecurityContext failed: Unknown error (0x80092012) -
The revocation function was unable to check revocation for the certificate.: git config --global http.sslVerify false
