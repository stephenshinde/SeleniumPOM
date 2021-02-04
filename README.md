# SeleniumPOM

This project is developed with page object module 

**IDE** : Visual Studio 2019,<br />
**Programming Language** : C#,<br />
**Library Used** : Selenium, Selenium Extras, Nunit<br />
**ChromerDriver Version** : 88.0.4324.96<br />
**Chromer Version** :  88.0.4324.146

## How to Clone project:
1. Download and Install Git from https://git-scm.com/downloads,<br />
2. Open Commaand prompt,<br />
3. Enter command git clone https://github.com/stephenshinde/SeleniumPOM.git

## How to Run Project:
1. Go to Visual Studio <br />
2. Setup the project in visual studio
3. Click on Build => Clean Solution <br />
3. Click on Build => Build Solution <br />
4. Click on Test => Test Explorer <br />
5. Run SearchLaptop Test Case <br />

## Project Structure:

1. Base: Base folder contains initiazlization of Webdriver in DriverFactory class and Browser initialization and teardown methods in TestBase class<br />
2. Driver : Driver folder contains chromedrive exe<br />
3. Helpers : Helpers folder contains helper and utility classes that contains re usable methods<br />
4. Pages : All the locators (object) will stored under each page class<br />
5. TestCases : All the testcases are written under TestCases folder<br />

