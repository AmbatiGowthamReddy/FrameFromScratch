# Code Structure, Usage and Best Practice 

This document outlines code structure, how to implement existing element and best practices for adding tests.

## ScreenObjects object model (similar to PageObject Model)

* All discovered elements should be stored in an appropriately named 'ScreenObjects'. (see existing ScreenObjects for format)
* name the objects appropropriately.
* When accessing elements for tests, instances of the appropriate 'ScreenObjects' will be created giving the test access to all contained elements

## Common Methods / Actions

* Where possible, these should be stored in the 'Page' upon which they act.
* If the method accesses an external class, these methods should be stored in an appropriately named extension method.

## Individual settings

* The app.config file contains key/value pairs for identifiers that will be unique to your system (e.g. 'host url')
* These values are mapped to public variables in `Settings.cs`
* When adding values to app.config, ensure that an appropriate entry is also made in `Settings.cs`

## Test format 

* Think about re-use of code and add common methods to shared classes (i.e. "Pages")
* True false assertions shouldBe made using Shouldly to make sure they are more readable

## Test tagging

* To group tests of a similar type together, you should use `[TestCategory("Smoke Test")]`
* This will go on the line after `[TestMethod]`

## Run Tests

* Run tests using Visual Studio > Test Explorer

## Output

* A detailed test result file will be available in project folder -> bin -> debug -> BDDfy.html