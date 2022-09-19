# NICMananger

## Introduction
<img align="right" src="https://raw.githubusercontent.com/exteran/nicmanager/main/img/nicmanager_queryform.jpg" alt="NICManager">This software is designed to digitize law enforcement records on local systems and servers for ease of access by personnel needing access to NCIC NIC file entries for records look-up, file maintenance, and hit confirmation request and response purposes. Many agencies still use hard copies (paper filing) for its NIC entry files, and personnel must search--by hand--the archive in order to find the relevant records. Digitizing these records can speed up the process of locating valid files quickly and easily.

## About

This application was designed as a Windows desktop application using Visual Studio. It is written in the C# programming language and uses a MySQL database back end for data storage and retrieval.

#### Target Version Information

Visual Studio Community 2022
C# .NET Framework 4.7.2
MySQL 8.0.30

#### Server Deployment Testing Environment

Database: 10.4.24-MariaDB - mariadb.org binary distribution
Charset: UTF-8 Unicode (utf8mb4)

## Changelog

### Version 0.01 - 09/19/2022
- Improved status feedback system to user for input validation.
- Query tool input validation for valid input.
- Complete first build. 0 errors.
- Connect to back end database from solution.
- Setup solution for MySQL connectivity.
- Setup database server for test environment (MariaDB 10.4.24).
- Build SQL export (genesis file) from MySQL Workbench (8.0.30).
- Design of initial database complete.
- Primary form design for query tool.
- Solution creation in Visual Studio Community 2022.

## To-Do

### Version 0.02 - anticipated before 10/01/2022
- Design and code supporting document attachment system for entries. TODO
- Design and code user authentication system. TODO
- Design and code queries and returns for sample data set. TODO

## Known Issues
As this is the first release, many issues are known and too numerous to list here. This will be refined as time goes on.
