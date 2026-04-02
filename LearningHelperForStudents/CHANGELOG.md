
# Changelog

All notable changes to this project will be documented in this file.

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

