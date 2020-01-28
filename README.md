# EventViewer.BL - Build Steps:

Open up EventViewer.Data\EventContext.cs and replace <b>Enter_Connection_String_Here</b> with the connection string

From Package Manager Console run the following commands

`add-migration InitialCommitment -p EventViewer.Data`
	
`update-database -p EventViewer.Data`
