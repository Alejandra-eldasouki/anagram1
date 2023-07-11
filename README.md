<!-- Co-authored-by: Austin Papritz <austinpapritz@users.noreply.github.com> -->

public bool IsPalindrome(string word)
{
string lowerCaseWord = word.ToLower();
char[] charArray = lowerCaseWord.ToCharArray();
Array.Reverse(charArray);

    string reversedWord = new string(charArray);
    return lowerCaseWord == reversedWord;

}
