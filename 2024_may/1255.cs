public class Solution {
    public int MaxScoreWords(string[] words, char[] letters, int[] score) {
        int[] letterCounts = new int[26];
        foreach (char letter in letters) {
            letterCounts[letter - 'a']++;
        }

        return MaxScore(words, letterCounts, score, 0);
    }

    private int MaxScore(string[] words, int[] letterCounts, int[] score, int index) {
        if (index == words.Length) {
            return 0;
        }

        int maxScoreWithoutCurrentWord = MaxScore(words, letterCounts, score, index + 1);

        int wordScore = 0;
        bool canFormWord = true;
        foreach (char c in words[index]) {
            if (--letterCounts[c - 'a'] < 0) {
                canFormWord = false;
            }
            wordScore += score[c - 'a'];
        }

        int maxScoreWithCurrentWord = 0;
        if (canFormWord) {
            maxScoreWithCurrentWord = wordScore + MaxScore(words, letterCounts, score, index + 1);
        }

        foreach (char c in words[index]) {
            letterCounts[c - 'a']++;
        }

        return Math.Max(maxScoreWithoutCurrentWord, maxScoreWithCurrentWord);
    }
}