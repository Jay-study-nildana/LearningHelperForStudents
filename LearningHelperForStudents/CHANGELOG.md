
# Changelog

All notable changes to this project will be documented in this file.

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

