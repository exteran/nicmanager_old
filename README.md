# NICMananger

## Introduction 
<img align="right" src="https://raw.githubusercontent.com/exteran/nicmanager/main/img/nicmanager_queryform.jpg" alt="NICManager">This software is designed to digitize law enforcement records on local systems and servers for ease of access by personnel needing access to NCIC NIC file entries for records look-up, file maintenance, and hit confirmation request and response purposes. Many agencies still use hard copies (paper filing) for its NIC entry files, and personnel must search--by hand--the archive in order to find the relevant records. Digitizing these records can speed up the process of locating valid files quickly and easily.

## About

This application was designed as a Windows desktop application using Visual Studio. It is written in the C# programming language and uses a MySQL database back end for data storage and retrieval.

#### Target Version Information

- Windows 10 or 11

- C# .NET Framework 4.7.2 or newer

- MySQL 8.0.30 or newer (or equivalent MariaDB)

#### Server Deployment Testing Environment

- Database: 10.4.24-MariaDB - mariadb.org binary distribution

- Charset: UTF-8 Unicode (utf8mb4)

## Changelog

### Version 0.03 - 9/23/2022 

- Converting simple forms to MDI application.

### Version 0.02 - 09/20/2022

- Create one-way digest algorithm encryption for user passwords (SHA256).
  - Authenticator uses SHA256 encryption by default.
- Create authenticator class.
- Design login form in Visual Studio.
- Login and authentication system.

### Version 0.01 - 09/19/2022

Video presentation of early features in this build: [YouTube: NICManager - Query Tool](https://youtu.be/TfylPKEYULI)

- Complete Build #2. 0 errors.
- Improved status feedback system to user for input validation.
- Query tool input validation for valid input.
- Complete Build #1. 0 errors.
- Connect to back end database from solution.
- Setup solution for MySQL connectivity.
- Setup database server for test environment (MariaDB 10.4.24).
- Build SQL export (genesis file) from MySQL Workbench (8.0.30).
- Design of initial database complete.
- Primary form design for query tool.
- Solution creation in Visual Studio Community 2022.

## To Do/In Progress

- Design and code user authentication system.
  - Create password recovery/forgot password functionality.

## Roadmap

### Anticipated before 10/01/2022
- Design and code supporting document attachment system for entries. TODO

- Design and code queries and returns for sample data set. TODO

### Anticipated by 10/15/2022
- Version 1.0 - production-ready release candidate.

### Future Additions
- Explore Microsoft SQL database deployment.
- Explore other database drivers.

## Known Issues
As this is the first release, many issues are known and too numerous to list here. This will be refined as time goes on.
