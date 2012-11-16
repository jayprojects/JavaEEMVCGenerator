JavaEEMVCGenerator
======================

This is a Visual Studio 2010 Project C# language.
I created this project to make a tool that can create basic dynamic web project for Java EE, mostly on eclipse project. 
The tool takes database information of a table and creates necessary files that can be added to a new eclipse project (Dynamic Web Project).
The website has complete CRUD functionality on the table supplied.
It creates necessary Model View(s) and Controller as well as some helper classes.
If the table name is "Students" and given Java package name is "edu" then it creates followings files

Generated Files
==================
	"Output Dir"\crud
	"Output Dir"\crud\src
	"Output Dir"\crud\src\edu\Student.java
	"Output Dir"\crud\src\edu\DBConnection.java
	"Output Dir"\crud\src\edu\StudentControll.java
	"Output Dir"\crud\src\edu\StudentDbUtill.java
	"Output Dir"\crud\WebContent
	"Output Dir"\crud\WebContent\StudentAdd.jsp
	"Output Dir"\crud\WebContent\StudentUpdate.jsp
	"Output Dir"\crud\WebContent\StudentView.jsp
	"Output Dir"\crud\WebContent\Index.jsp
	"Output Dir"\crud\WebContent\WEB-INF
	"Output Dir"\crud\WebContent\WEB-INF\web.xml


How to add to a new Eclipse project:
====================================
	First create a new "Dynamic Web Project"
	File > New >Dynamic Web Project >Type Name >click Finish
	Right Click on the project(from project explorer) > Import >Import ...
	Under general select "File System" > Next > Browse to "crud" folder that were just created
	Expand "crud", check both "src" and "WebContent" folders > Click Finish
	
If you want to add generated coed to an existing project
=============================================================
	Copy and paste files to appropriate locations.
	you may also copy some portion of the code
	
Limitations
============
	works on SQL server database only	
	for now it only works for int and varchar. for other datatype, they works! but treated as string.
	no sql injection checker
	if its a date filed, make sure the input is correctly formated on the Add or Update page (YYYY-MM-DD) it will be insert as string!

Comments 
=========
	This is not an application, rather just a tool, meant to be used by a developer. 
	So please use you judgment before you use generated files of any part of the codes
