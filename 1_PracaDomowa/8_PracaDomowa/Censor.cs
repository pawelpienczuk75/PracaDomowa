using System;
using System.Collections.Generic;
using System.Text;

namespace _8_PracaDomowa
{
    public class Censor
    {
        public List<string> listBadWords = new List<string>();
        public Censor()
        {
            listBadWords.Add("dupa");
            listBadWords.Add("kupa");

        }
        public int Check(string inputData)
        {
            string[] tab = inputData.Split(' ');
            int u = 0;

            foreach (string word1 in tab)
            {
                foreach (string word2 in listBadWords)
                {
                    if (word1 == word2)
                    {
                        u = u + 1;
                    }
                }
            }
            return u;

        }

        public string Censorship(string inputData)
        {
            string[] tab = inputData.Split(' ');

            for (int i = 0; i < tab.Length; i++)
            {
                foreach (string word2 in listBadWords)
                {
                    if (tab[i] == word2)
                    {
                        tab[i] = "****";
                    }
                }
            }
            return String.Join(" ", tab);


        }
    }
}