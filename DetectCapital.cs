public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == word.ToUpper()){
            return true;
        } 
        else return false;
    }
}
