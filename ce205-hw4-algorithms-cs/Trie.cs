/**
* @file ce205-hw4-algorithms-cs
* @author Sema Nur Ersoy
* @author Rumeysa Er
* @date 30 Dec 2022
*
* @brief <b> HW-4 Functions </b>
*
* HW-4 Sample Lib Functions
*
* @see http://bilgisayar.mmf.erdogan.edu.tr/en/
*
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ce205_hw4_algorithms_cs
{
    public class Trie
    {
        public static TrieNode _root;

        static Trie()
        {
            _root = new TrieNode();
        }

        /**
        * @name Insert 
        * @param [in] word [\b string]
        * This function is used to add a node.
        **/
        public static void Insert(string word)
        {
            TrieNode current = _root;
            foreach (char c in word)
            {
                current = current.GetOrAddChild(c);
            }

            current.IsEndOfWord = true;
        }

        /**
        * @name Search 
        * @param [in] word [\b string]
        * @retval [\b bool]
        * This function helps us to find the string text we entered when we search for it in our application.
        * It is the search function.
        **/
        public static bool Search(string word)
        {
            TrieNode current = _root;

            foreach (char c in word)
            {
                TrieNode child = current.GetChild(c);
                if (child == null)
                {
                    return false;
                }

                current = child;
            }

            return current.IsEndOfWord;
        }

        /**
        * @name StartsWith 
        * @param [in] prefix [\b string]
        * @retval [\b bool]
        * Controls which child the function starts with.
        **/
        public static bool StartsWith(string prefix)
        {
            TrieNode current = _root;

            foreach (char c in prefix)
            {
                TrieNode child = current.GetChild(c);
                if (child == null)
                {
                    return false;
                }

                current = child;
            }

            return true;
        }

        public class TrieNode
        {
            public bool IsEndOfWord { get; set; }

            public Dictionary<char, TrieNode> Children { get; } = new Dictionary<char, TrieNode>();
            public string Word { get; set; }

            /**
            * @name GetChild 
            * @param [in] c [\b char]
            * This functions get child.
            **/
            public TrieNode GetChild(char c)
            {
                if (Children.TryGetValue(c, out TrieNode child))
                {
                    return child;
                }

                return null;
            }

            /**
            * @name GetOrAddChild 
            * @param [in] c [\b char]
            * This functions get or add child.
            **/
            public TrieNode GetOrAddChild(char c)
            {
                if (!Children.TryGetValue(c, out TrieNode child))
                {
                    child = new TrieNode();
                    Children.Add(c, child);
                }

                return child;
            }
        }
    }
}
