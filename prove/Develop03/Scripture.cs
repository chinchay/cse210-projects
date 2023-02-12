public class Scripture {
    string _text;
    Reference _reference;
    List<Word> _listWord;
    bool _isCompletelyHidden;



    public Scripture(Reference reference) {
        _reference = reference;
    }

    public void String2Word(){
        string text = _reference.GetSCriptureText();

        List<Word> listWord = new List<Word>();
        foreach (string wordString in text.Split(" ") ) {
            Word w = new Word(wordString);
            listWord.Add(w);
        }
        // Console.WriteLine( listWord[0].GetString() );
        _listWord = listWord;
        // return listString;

    }

    public void HideWords(){

    }

    public void GetRenderedText(){
        
    }
}