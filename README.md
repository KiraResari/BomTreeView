# BomTreeView
A project for importing a BOM and displaying it in a Tree View

To run the BomTreeView:

1. Go to the `SQL Server Container` folder and run the included SQL Server Docker container using either the `Start SQL Server Container.bat` file or by using `docker-compose up` in thsi folder from the console. (Docker must be installed and running on your machine)
2. Go to the `BomTreeView\bin\Debug` folder and run `BomTreeView.exe`

* Once the program is running, you can import the embedded sample data using the "Import BOM Data" button.
* The imported data is stored in the running SQL Database.
* Once the data has been imported, you can navigate through the parts in the tree view and view the children of the currently selected part (if the part has any) in the "Children" table.
* For demonstration purposes, the "Children" table is populated from the database. 
* You can delete the imported data again using the "Delete BOM Data button".
* You can exit the program using the "Exit BOM Displayer" button, which is conveniently located in a position where it will most likely not be clicked on accident.
* If you close the BOM Displayer after importing data (without deleting it), the BOM Displayer will automatically load the imported data from the database again on its next startup.
