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



## 26-Jul-2021

* Now continuing with this
* Last time I created a test view for displaying a TreeView and a TableView that is structurally more or less identical to the UI requested in the project - at least from a UI perspective
* Now, I'll start with the actual project



# ⚓
