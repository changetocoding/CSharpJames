# Unit testing
This was funny - http://web.archive.org/web/20160521015258/https://lostechies.com/derickbailey/2009/02/11/solid-development-principles-in-motivational-pictures/

## Why we test
Confidence


## TDD - Test driven development
Write tests first code after

1. Write test (failing)
2. Write the code that passes the test
3. Refactor


## Triple 'A' - Arrange, Act, Assert
How to write test code

## Nunit
Project setup
![image](https://user-images.githubusercontent.com/63453969/182658297-e364890f-de66-4439-8199-c5a4660462aa.png)
Or update your csproj with
```
  <ItemGroup>
    <PackageReference Include="Microsoft.NET.Test.Sdk" Version="16.11.0" />
    <PackageReference Include="NUnit" Version="3.13.2" />
    <PackageReference Include="NUnit3TestAdapter" version="4.1.0" />
    <PackageReference Include="coverlet.collector" Version="3.1.0" />
    <PackageReference Include="NUnit.Analyzers" Version="3.2.0" />
  </ItemGroup>
```


# Homework
From now on when sumbitting your homework you are expected to have a unit test with each one.

Secondly in this course homeworks will be similar to work. Where you gradually work on a project over several weeks and sometimes we'll leave an assignment and come back to it weeks later. This will teach you how to write good maintainable code.
