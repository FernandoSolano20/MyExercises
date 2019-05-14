Julie Lerman for Pluralsight
www.learnentityframework.com
www.pluralsight.com

Sample solution for "Querying Entity Framework Overview" 

This project contains the model and the tests used to explore querying with the Entity Framework.

The connection string in the app.config files points to a SQL Server instance of the database. Modify the connection string as necessary based on where you create this sample database.

There is also a sql script for creating the database, AdventureWorksLT which is used for this solution.  Here's how to use that script:
	(1) Open the SQL file in In Visual Studio using File/Open from Visual Studio's main menu. Visual Studio will recognized this as a SQL file and provide additional context menu commands.
	(2) Find in the beginning of the SQL file,  two file creation instructions that will create the database file and it's log file e.g.  E:\databases\Pluralsight\AdventureWorksSuperLT_Data.mdf').
	(3) Modify the paths to point to an existing folder on your computer where the files can be created.
	(4) Right click in the file's editor window and select Connection. Choose Connect to ensure that you are connected to an existing server -- SQL Server, SQL Express, SQL Server 2012 LocalDB -- whatever is available on your machine.
	(5) After setting the connection, right click again in the editor window and select Execute.
	(6) After the script has executed, use one of the following two methods to verify that the database, it's tables and their data exists:
			o In Visual Studio 2008 or 2010, open the Server Explorer. Use the Connect to Database wizard to connect to the AdventureWorksSuperLT database and explore the objects and data.
			o In Visual Studio 2012, open SQL Server Object Explorer. The new database should be listed. You can poke around to see the tables and data.

Julie Lerman
twitter.com/julielerman
