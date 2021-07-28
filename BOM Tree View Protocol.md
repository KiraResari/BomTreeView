# 24-Jul-2021

* Now getting started with the CAD Link Programming Challenge, also known as the QBuild Challenge
* As far as I understand it, the objective of this challenge is to build a desktop applications that imports and fuses the two files `bom.csv` and `part.csv` into a Database (ideally MS Access or SQL Server) and displays the imported data in a tree view.
  * In addition, when an item in the tree view is selected, information about the component parts of whatever part is currently selected in the tree view should be displayed in a table view that holds the following columns:
    * COMPONENT_NAME
    * PART_NUMBER
    * TITLE
    * QUANTITY
    * TYPE
    * ITEM
    * MATERIAL
  * The import should be performed by means of a "Populate Data" button that con only be clicked once and will then be disabled once the import is complete
* This is quite complex, and the main issue is that I haven't done an UI-Application in C# yet as far as I remember
* So, first I want to see if I can find a tutorial for how to create a Tree View in C#
  * This might be a good place to start:
    * https://www.c-sharpcorner.com/article/treeview-control-in-C-Sharp/
      * Unfortunately, I am unable to follow this tutorial past the first code sample, since it starts talking about some code without specifying where that code is supposed to be located
  * Maybe this will be better?
    * https://www.dotnetperls.com/treeview
      * **SUCCESS**: Using this tutorial I now managed to create my first, tentative working TreeView, and I am already getting ideas for how I can use this for the project
  * I am now spending some time experimenting with the tree view to get a good feeling for how it works and how I can populate it with data from a source
  * I have now gotten to a point where I feel reasonably comfortable in dealing with the Tree View
* I figure it makes sense to use this as a base to try and add the table view too
  * Let's see if I can find a good tutorial on this here
  * Since I had a good experience with dotnetperls, why not try this one?
    * https://www.dotnetperls.com/datatable
      * **SUCCESS:** Using this tutorial I now managed to add a Table View, and already have a relatively good idea of how to populate it using the children data
  * Experimenting with this, I now managed to create logic that displays the children of whatever character is selected in the data table
* This is as far as I'm getting with this today
* Elapsed time: ~3 hours



# 26-Jul-2021

* Now continuing with this

* Last time I created a test view for displaying a TreeView and a TableView that is structurally more or less identical to the UI requested in the project - at least from a UI perspective

* Now, I'll start with the actual project

* Because it's so similar and the above test project is effectively free of dead weight, I'll start by copying over the test project and then making adjustments as necessary
  * Visual Studio did not make this easy, but I managed to do it after all
  
* So, the first thing I now want to do is to change the Game Character sample data structure into one that can hold the BOM

* So for that, I'll first analyze the `bom.csv` and `part.csv` files to get an idea of which fields this data structure will need
  * The `bom.csv` is effectively defining the tree view. All it contains are parent-child relationships with specifications of how many of a child exist within a parent
    * The `VALVE` is implicitly defined as the top-level element since it has no parent
    * Apart from that, one interesting property to import from this file would be the `QUANTITY`
    
  * The `part.csv` effectively contains all the remaining information for all of the parts, namely:
  
    * NAME (this is the equivalent of the COMPONENT_NAME column in the `bom.csv`)
    * TYPE
    * ITEM
    * PART_NUMBER
    * TITLE
    * MATERIAL
  
  * As such, I think the `BomEntry`-class (how I'm probably going to call it) should hold these fields:
  
    * ````
      string ComponentName
      string ParentName
      int Quantity
      string Type
      string Item
      string PartNumber
      string Title
      string Material
      List<BomEntry> Children
      ````
  
    * Optionally, the Type might be implemented as an Enum, and I could probably also add an `BomEntry Parent` link, but I currently don't see the effective use of these things, so I'll just keep it in mind for later
  
* Next, I'll re-create the data structure and use dummy-data to make sure it is displayed correctly

  * According to the `QBuild Developer Programming Challenge.docx`, the Children-Table should display the following columns:
    * COMPONENT_NAME
    * PART_NUMBER
    * TITLE
    * QUANTITY
    * TYPE
    * ITEM
    * MATERIAL
  * I now finished creating a small dummy data-structure and was able to confirm that this results in the desired data being displayed
  * I also played around with the UI a bit until I came up with something that will do for now

* Next, I'm going to add the buttons for importing data and exiting from the application

  * I'll start with the exit button first since that one is easier, and that way I won't risk forgetting it later
    * As expected, this was straightforward and easy
  * Next, the import button
    * This is going to be more complicated since I'll first have to write the importer  
      * I realize that I'll effectively have to create three "Importers" here, along with probably some interim classes to keep it all clean:
        * One `BomImporter` to import the `bom.csv`
          * This will create a list of `BomBaseEntry`
        * One `PartImporter` to import the `part.csv`
          * This will create a list of `PartBaseEntry`
        * One `CombinedImporter` to combine both imports into a `BomEntry`
      * I'll start with the BomImporter
        * Since CSV import is something pretty basic I'm sure there'll be some utilities for this already, so I'll look for a tutorial on that
          * Maybe this one will help?
            * https://zetcode.com/csharp/csv/
              * The problem with this one is that the CsvHelper used inside is apparently an external resource
              * However, since I will need external resources at the latest when I add a database, I suppose I'll have to figure out how to use these anyway, so might as well do that now
                * So, apparently the Gradle-Equivalent to JAva in C# is NuGet (I remember dealing with that before when I worked for Netfira), and the page for the CsvHelper there is: https://www.nuget.org/packages/CsvHelper/
                  * I also note that the CsvHelper has 53,703,318 downloads, so odds are that this is a good package to work with 
                * Now I just need to figure out what the equivalent for the `buidl.gradle` is with NuGet
                  * It says here (https://docs.microsoft.com/en-us/nuget/consume-packages/package-references-in-project-files) that I can simply add a package reference in my project file using an XML syntax, but I can't find a single XML file in the whole project
                  * Ah, I figured it out. What you need to do is right-click on "References" and then click "Manage NuGet Packages"
                    * Actually, it feels like I already did this, but that was many years ago
              * At any rate, now I have the CsvHelper package successfully imported and have learned/remembered how to add additional packages if I need them
              * Using this tutorial I now managed to set up the importers for the `bom.csv` and the `part.csv`
              * However, I do not yet know if they work as intended
              * This is where tests come in! Thus far my code was missing those anyway, so I'm looking forward to adding a few tests to ascertain that the imports work as intended
  
* This is as far as I'm getting today

* Elapsed time today: ~3 hours

* Total elapsed time: ~6 hours



# 27-Jul-2021

* Now continuing with this

* Last time, I prepared the BomImporter and PartImporter, which are supposed to import the `bom.csv` and the `part.csv` into the program, so I can then combine them

* Before I do that, however, I want to test if this import is working the way I expect it to

  * So, how did that work again in C#?

  * This looks like it ought to explain that:

    * https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019

  * I now managed to get the test running, and it turns out it's a good thing I wrote it, because the import of the `bom.csv` currently fails with an error

  * Apparently, the importer looks for headers that either match the field names or the parameter names of the constructor of the object that I want to import, and since in the csv the headers are written in SCREAMING_SNAKE_CASE while the class fields are in HappyCamelCase and the parameter names are in sadCamelCase, no match is found

  * I now managed to fix this by adding attributes for the Header Names (`[Name("PARENT_NAME")]`)

  * However, that didn't fix the problem. It only made it more annoying:

    * ````
          Test method BomTreeViewTest.BomImporterTest.ImportingBomShouldCreateBomImporterResultWithCorrectNumberOfEntries threw exception: 
          CsvHelper.HeaderValidationException: Header with name 'parentName'[0] was not found.
          Header with name 'quantity'[0] was not found.
          Header with name 'componentName'[0] was not found.
          Header with name 'PARENT_NAME'[0] was not found.
          Header with name 'QUANTITY'[0] was not found.
          Header with name 'COMPONENT_NAME'[0] was not found.
          If you are expecting some headers to be missing and want to ignore this validation, set the configuration HeaderValidated to null. You can also change the functionality to do something else, like logging the issue.
         
      ````

    * ...which right now is simply wrong since the `bom.csv` clearly has those headers:

    * ````
      PARENT_NAME,QUANTITY,COMPONENT_NAME
      VALVE,1,BODY
      ````

  * However, I could imagine that this behavior happens due to a culture shock, since the CSV Importer is opened like this:

    * `CsvReader csvReader = new CsvReader(streamReader, CultureInfo.CurrentCulture);`

  * ...and I just so happen to know that some programs follow the anti-pattern of separating COMMA SEPARATED VALUES with SEMICOLONS in some countries, and Germany happens to be one of those countries

  * So before I even go to any length of effort to ascertain that this is the problem, I'm just gonna see what happens if I replace the CultureInfo in the CsvReader with the Canadian one

    * As expected, this was EXACTLY the problem

  * Now it still complains that it can't find the sadCamelCaseHeaders, which I'm going to interpret as "the Import Entries shouldn't have constructors"

  * **SUCCESS!** Now the `BomImporterTest` passes!

  * Now I'll just write an equivalent `PartImporterTest`

    * I now did that and got it to pass too

* Now that I know that the individual importers work as intended, I can next work on combining the two imported data sets into one

  * There, I should keep in mind that the resulting data object should be SQL-Friendly, meaning I can't directly pass around Object references like I currently do in the 
  * I now did that, but in testing the importer I found a discrepancy between the two files
    * The `bom.csv` specifies in Line 45 that the `BODY` should have a child component with the name `WELD_TOPCONE2SPOOL`
    * However, the `part.csv` does not specify such a part with such a name
    * I suppose that is where this part in the Specification comes in:
      * "Most of the COMPONENT_NAME data crosses over to a record in the PART file with NAME= COMPONENT_NAME. If there is no record in the PART file, you can leave the fields blank."
    * I now adjusted the logic accordingly, and now the test passes

* So, now I have a tested working import infrastructure that generates me a DB-Friendly `BomDbEntryList`

* The next step will be translating that `BomDbEntryList` into a `BomDisplayEntryList` that I can then use as data source for the `BomDisplayer`

  * I now did that, complete with tests

* With that, I should now have everything in place to allow the import via button

* I now got the import to work per se, but there's still a problem

  * I haven't figured out how to make it so that the files are automatically put into the debug/bin folder, or whatever folder the project is exported to, so I had to hard-code the file paths
  * I'll have to tackle that next time

* This is as far as I'm getting today

* Elapsed time today: ~4 hours

* Total elapsed time: ~10 hours



# 28-Jul-2021

* Now continuing with this

* Currently I have to problem that the file paths are hard-coded as absolute paths, which will not work on other machines
  * I'll see if I can do something about that
  * Currently I import the files by name, but I figure if I can import them as resources it will be better for this use case
  * Of course, in an actual project, there would most likely a file selector for that, and then the absolute paths wouldn't be a problem, but that would create its own whole set of problems and blow the scope of this challenge
  * So resources it is
  * I now figured out how to do this
  
* Next, and this is a minor thing, I'll make it so that no data is displayed at first, and also remove the hard-coded sample data
  * I now did that
  
* So, now there's only one thing left to do: The Database
  * The Challenge suggests MS Access or SQL Server
  
  * I was going to try out MS Access, but since I can't seem to find a docker image of MS Access, but I've found one of SQL Server right here, I suppose I'll be using SQL Server after all
  
  * Oh, and it also looks like I'll have to install Docker on this machine
    * While this is happening, I am already going to have a look at which framework I'm going to use to talk to the database
      * It seems that these days ADO.NET is all the rage, so I maybe this is a good place to start working with:
        *  https://docs.microsoft.com/en-us/visualstudio/data-tools/create-a-simple-data-application-by-using-adonet?view=vs-2019
    
  * Anyway, I now managed to get the MS SQL Server container running
  
    * This looks like a good tutorial for how to communicate between a dockerized SQL Server and ADO.NET:
      * https://docs.docker.com/samples/aspnet-mssql-compose/
  
  * Now as for writing the Data into the Database...
  
  * The first thing I'll have to do is create the datatable
  
    * Specifically, since I figure that the point of having a database is that it will be able to store data between sessions, I'll have to check if the datatable exists and create it if not
      * This may be helpful for that:
        * https://www.completecsharptutorial.com/ado-net/c-ado-net-create-select-rename-and-delete-database-by-c-program.php
          * Hmm, actually, I'm not so sure about that
      * Since I'm already working with the DataTable class, it feels like there must be an easier way for that
      * Now, this looks great for _reading_ data tables:
        * https://stackoverflow.com/questions/6073382/read-sql-table-into-c-sharp-datatable
      * This looks like a good start:
        * https://stackoverflow.com/questions/9075159/how-to-insert-a-data-table-into-sql-server-database-table
      * I'm still confused, maybe this will help?
        * https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlbulkcopy?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0
          * Mmm, no. That's only more complicated and confusing
      * So, from what I read I need to create the table first anyway
  
  * Dragon, I've been working with MongoDB for so long now that I forgot how horrible working with SQL was, and this is a painful reminder of this
  
  * Aaanyway, I have now created a test, and it fails because it can't connect to the SQL DB. Apparently the database connection string is wrong
  
    * I'm currently using: `@"Server=db;Database=master;User=sa;Password=PizzaIsMagic=^,^=;"`
  
    * I have now posted a help request about this on StackOverflow:
  
      * https://stackoverflow.com/questions/68564532/connecting-to-sql-database-in-docker-instance-from-c-sharp-fails
  
    * If I'm not getting a reply to this or figure it out on my own by tomorrow, I'll forget about Docker and just install a local MS SQL Server for this project
  
    * If I use this connection string: `@"Server=localhost,1433;Database=master;User=sa;Password=PizzaIsMagic=^,^=;"` the error message changes to:
  
      * ````
        System.ComponentModel.Win32Exception: The Remote Host refused the network connection
        ````
  
    * I'll now download and install SQLSMS. Odds are that this will be needing this anyway to check on the database
  
    * I now figured it out
  
    * The error was that the `docker-compose.yml` was still missing this small, but essential part:
  
      * ````
                ports:
                    - "1433:1433"
        ````
  
    * With that, now the first SQL Connection test works
  
* This is as far as I'm getting today

* As I feared, the database logic ate the majority of my time today, and I barely made any progress (which is why I saved the database logic for last)

* However, in the end I was able to establish a connection, and execute the first query, which at the very least is solid groundwork for me to continue with tomorrow

* Elapsed time today: ~4 hours

* Total elapsed time: ~14 hours



# ⚓
