using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {


          // Make a new list
List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

//You want to track the following about each word:
    //     word, definition, part of speech, example sentence
    // Example of one dictionary in the list:

//     {
//         "word": "excited",
//         "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
//         "part of speech": "adjective",
//         "example sentence": "I am excited to learn C#!"
//     }
// */

// Create dictionary to represent a few word

Dictionary<string, string> excitedWord = new Dictionary<string, string>();

// Add each of the 4 bits of data about the word to the Dictionary

excitedWord.Add("word", "Shu");
excitedWord.Add("definition", "minty fresh developer");
excitedWord.Add("part of speech", "adjective");
excitedWord.Add("example of speech", "shu has the minty fresh smell");



// Add Dictionary to your `dictionaryOfWords` list

dictionaryOfWords.Add(excitedWord);

// create another Dictionary and add that to the list


Dictionary<string, string> anotherWord = new Dictionary<string, string>();


anotherWord.Add("word", "hi");
anotherWord.Add("definition", "nope");
anotherWord.Add("part of speech", "noun");
anotherWord.Add("example of speech", "hi how are you");



dictionaryOfWords.Add(anotherWord);
/*
    Iterate your list of dictionaries and output the data

*/

// Iterate the List of Dictionaries
foreach (Dictionary <string,string> word in dictionaryOfWords)
{
    // Iterate the KeyValuePairs of the Dictionary
    foreach (KeyValuePair<string, string> wordData in word)
    {
        Console.WriteLine($"{wordData.Key}: {wordData.Value}");
    }

}
        }
    }
}
