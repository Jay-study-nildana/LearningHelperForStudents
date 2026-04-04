
# Changelog

All notable changes to this project will be documented in this file.

## [1.0.7] - 2026-04-04

### Added

- Added DC Comics data. 
	- This is similar to the SQL Query Practice Sample, https://github.com/Jay-study-nildana/Azure-CSharp-Corp-Trainer-Syllabus/tree/main/SQLFundamentals/DCComics
	- The idea is for my students to practice SQL. Then, they can come here, and practice the same with LINQ, but without having to worry about a DB.
	- Later when they move to a real database which has the DC Comics data, it will be easier to run LINQ queries
	- Essentially, this is like an inmemory DB for practising linq
	- There is the original class (which can be used as a model for EF if need be)
	- Then, collections with data. The data respects the foreign key relations
	- Further students can make side by side comparisons between how the queries would look in SQL and in LINQ as the table and columns names math.
	- However, the data might be slightly different because, I was unable to map the actual data between the SQL file and the local collection. 

## [1.0.5] - 2026-04-04

### Added

- Upgraded the nuget package so that it will support .Net 9.X
- Upgraded the nuget package so that it will support .Net 10.X
- Upgraded the test proejct also to support .Net 9.X
- Upgraded the test proejct also to support .Net 10.X

## [1.0.4] - 2026-04-02

### Added

- Created a new 'Utility' class 'Lh' 
	- which now contains all the utility functions.
	- I added this because, if I keep creating new classes for each and every interface method, it will beat the whole point of this utility
	- now each and every utility method will fall under 'Lh' class. This way, the student can created one single object using 'Lh' and call all the utility functions. 
	- I made the name smaller because it will reduce typing space. 
	- Although, this means, the 'Lh' class will implement more and more interfaces as time goes. We need to see how to solve this. but for now, we will stick to this sytem
- AddSimpleConsoleDividerDash
	- Adds a simple dashed line to be used for display dividers
- DisplayListOfStrings
	- Displays a list of strings. 
	- allows the display of a prefix to indicate what is there in the collection
- DisplayWordsListWithJoin
	- Displays words using join.
	- Like, if you have a list of words, but in a single line. 
- GiveMeStringInput
	- Collect input from user and return the input as a string

## [1.0.1] - 2026-04-02

### Added
- XML documentation comments for the public API:
	- `Interfaces.IRandomRepeatedWordsGenerator` and its `GenerateRandomRepeatedWords` method.
	- `RandomRepeatedWordsGenerator` and its `GenerateRandomRepeatedWords` method.
	- `Data.SourceWords` and `SourceWords.List`.
- Removed the requirement for words list to be supplied.
	- The `RandomRepeatedWordsGenerator` now uses a default list of words defined in `SourceWords.List` if no custom list is provided.
	- I thought, this will make it easy for the student so that they don't have to build their own word list

## [1.0.0] - 2026-04-02

- Initial public package contents and API surface.

