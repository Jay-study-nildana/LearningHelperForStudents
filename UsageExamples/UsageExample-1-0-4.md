# Usage Example (Version 1.0.4)

some usage examples created when testing Version 1.0.4

## Code

```

using Jay.LearningHelperForStudents.Utilities;

var trie = new Trie();

var lh = new Lh();

var words = lh.GenerateRandomRepeatedWords(null, 20, 2, 10, null, true, true);
lh.DisplayWordsList(words);

// insert words; optionally insert duplicates to simulate frequency
foreach (var w in words)
{
    trie.Insert(w);
}

//lets display frequency of all words in the trie

var wordsunique = words.Distinct().ToList() ;
lh.DisplayListOfStringsNow(wordsunique, "Unique Words in Trie:");

var input = lh.GetStringInput();

Console.WriteLine($"Search(\"{input}\") => {trie.Search(input)}");
Console.WriteLine();
Console.WriteLine($"Frequency of \"{input}\" => {trie.WordFrequency(input)}");

// autocomplete / suggestions
var prefix = lh.GetStringInput();

lh.DisplayListOfStringsNow(trie.GetWordsWithPrefix(prefix).OrderBy(s => s).ToList(), $"Words with prefix \"{prefix}\":");

// demonstrate deletion
var deleteterm = lh.GetStringInput();
Console.WriteLine($"Deleting '{deleteterm}'...");
trie.Delete(deleteterm);
Console.WriteLine($"Search(\"{deleteterm}\") => {trie.Search(deleteterm)}");
lh.DisplayListOfStringsNow(trie.GetWordsWithPrefix(prefix).OrderBy(s => s).ToList(), $"Words with prefix \"{prefix}\" after deletion of '{deleteterm}':");

public class TrieNode
{
    // children map; use Dictionary<char, TrieNode> for sparse alphabets
    public readonly Dictionary<char, TrieNode> Children = new();
    public bool IsWord;
    // optional: store frequency/count or payload
    public int Frequency; // e.g., how many times the word was inserted (0 if not a word)
}

public class Trie
{
    private readonly TrieNode _root = new();

    // Insert a word; increments Frequency at the final node.
    public void Insert(string word)
    {
        if (string.IsNullOrEmpty(word)) return;
        var node = _root;
        foreach (var ch in word)
        {
            if (!node.Children.TryGetValue(ch, out var next))
            {
                next = new TrieNode();
                node.Children[ch] = next;
            }
            node = next;
        }
        node.IsWord = true;
        node.Frequency++; // optional: track frequency
    }

    // Exact match
    public bool Search(string word)
    {
        if (string.IsNullOrEmpty(word)) return false;
        var node = _root;
        foreach (var ch in word)
        {
            if (!node.Children.TryGetValue(ch, out node)) return false;
        }
        return node.IsWord;
    }

    public int WordFrequency(string word)
    {
        if (string.IsNullOrEmpty(word)) return 0;
        var node = _root;
        foreach(var ch in word)
        {
            if (!node.Children.TryGetValue(ch, out node)) return 0;
        }
        return node.IsWord ? node.Frequency : 0;
    }

    // Does any word start with the given prefix?
    public bool StartsWith(string prefix)
    {
        if (string.IsNullOrEmpty(prefix)) return true;
        var node = _root;
        foreach (var ch in prefix)
        {
            if (!node.Children.TryGetValue(ch, out node)) return false;
        }
        return true;
    }

    // Enumerate all words that start with the given prefix.
    public IEnumerable<string> GetWordsWithPrefix(string prefix)
    {
        var node = _root;
        foreach (var ch in prefix)
        {
            if (!node.Children.TryGetValue(ch, out node)) yield break;
        }
        foreach (var word in Collect(node, prefix)) yield return word;
    }

    // Depth-first collect (simple recursion)
    private IEnumerable<string> Collect(TrieNode node, string current)
    {
        if (node.IsWord) yield return current;
        foreach (var kvp in node.Children)
        {
            foreach (var w in Collect(kvp.Value, current + kvp.Key))
                yield return w;
        }
    }

    // Optional: delete a word; returns true if deleted
    public bool Delete(string word)
    {
        return DeleteInternal(_root, word, 0);
    }

    private bool DeleteInternal(TrieNode node, string word, int depth)
    {
        if (node == null) return false;
        if (depth == word.Length)
        {
            if (!node.IsWord) return false;
            node.IsWord = false;
            node.Frequency = 0;
            // If node has no children, signal to parent it can remove this child.
            return node.Children.Count == 0;
        }

        var ch = word[depth];
        if (!node.Children.TryGetValue(ch, out var child)) return false;
        var shouldDeleteChild = DeleteInternal(child, word, depth + 1);
        if (shouldDeleteChild)
        {
            node.Children.Remove(ch);
            return !node.IsWord && node.Children.Count == 0;
        }
        return false;
    }
}

```