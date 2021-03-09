# DatingApp
VS Code Extension
GitHub Pull Requests and Issues

Troubleshoot
1. fatal: unable to access 'https://github.com/suniladhya/DatingApp.git/': SSL certificate problem: self signed certificate in certificate chain: git config --global http.sslbackend schannel
2. fatal: unable to access 'https://github.com/suniladhya/DatingApp.git/': schannel: next InitializeSecurityContext failed: Unknown error (0x80092012) -
The revocation function was unable to check revocation for the certificate.: git config --global http.sslVerify false
