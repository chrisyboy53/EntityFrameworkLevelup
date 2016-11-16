# Demo of Entity Framework using Relationships

[![Build Status](https://travis-ci.org/chrisyboy53/EntityFrameworkLevelup.svg?branch=master)](https://travis-ci.org/chrisyboy53/EntityFrameworkLevelup)

This is a further example of Entity Framework using Relationships.

This also uses the migration tool. Which should allow developers to
be able to work on any type of database that is compatible with
Entity Framework.

## How to get this working

```bash

dotnet restore;
dotnet ef database update;
dotnet run;

# you can pass in arguments
# dotnet run firstname lastname age teamname  

``` 