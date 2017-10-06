/*UserInterface.cs
 *Author: Jared Wolfe
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rhyme_Generator
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_Click(object sender, EventArgs e)
        {
            string input = uxInput.Text;
            if (input.Length > 0)
            {
                uxOutput.Text = FindRhyme(input);
            }
            else
            {
                uxOutput.Text = "";
            }
        }

        /// <summary>
        /// Finds a rhyme to the given input.
        /// </summary>
        /// <param name="input">A string to find a rhyme for.</param>
        /// <returns>A string rhyme.</returns>
        private string FindRhyme(string input)
        {
            string output = input.ToLower().Trim();
            string end = findEnding(output);
            if (end == null)
            {
                return "";
            }
            string[] words = File.ReadAllLines(@"C: \Users\bigba_000\Documents\dictionary.txt");
            StringBuilder sb = new StringBuilder();
            int count = 0;
            string vowels = "aeiouy";
            foreach (string s in words)
            {
                if (s.Length >= end.Length)
                {
                    sb.Clear();
                    sb.Append(s, s.Length - end.Length, end.Length);
                    if (sb.ToString() == end)
                    {
                        count++;
                    }
                }
            }
            string[] rhymes = new string[count];
            int secondCount = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= end.Length)
                {
                    sb.Clear();
                    sb.Append(words[i], words[i].Length - end.Length, end.Length);
                    if (sb.ToString() == end)
                    {
                        rhymes[secondCount] = words[i];
                        secondCount++;
                    }
                }
            }
            if (rhymes.Length > 0)
            {
                Random rnd = new Random();
                return rhymes[rnd.Next(rhymes.Length)];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Searches for the vowel in the string that creates the rhyme.
        /// </summary>
        /// <param name="s">The word to analyze.</param>
        /// <returns>End of the word that creates the rhyme.</returns>
        private string findEnding(string s)
        {
            StringBuilder sb = new StringBuilder();
            string vowels = "aeiouy";
            bool onlyVowel = false;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(s[i]))
                {
                    if (i != 0)
                    {
                        if (vowels.Contains(s[i - 1])) // if there are two vowels side by side, start with the first one.
                        {
                            i--;
                        }
                    }
                    if (!(i == s.Length - 1))
                    {
                        onlyVowel = false;
                        for (int k = i; k < s.Length; k++)
                        {
                            sb.Append(s[k]);
                        }
                        return sb.ToString();
                    }
                    else
                    {
                        onlyVowel = true;
                    }
                }
            }
            if (onlyVowel)
            {
                return s;
            }
            return null;
        }
    }
}
