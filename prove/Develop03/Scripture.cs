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
        int nWords = _listWord.Count;
        int count = 0;
        int countMax = 100;
        int hiddenWords = 0;
        Random random = new Random();
        int index     = random.Next(nWords);
        while ( (count < countMax) & (hiddenWords < 3) ) {
            count += 1;
            if ( !_listWord[index].IsHidden() ) {
                hiddenWords += 1;
                _listWord[index].Hide();
            }
            index = random.Next(nWords);
        }
    }

    public bool IsCompletelyHidden() {
        int count = 0;
        foreach (Word w in _listWord) {
            if (w.IsHidden()) {
                count += 1;
            }
        }
        if (count == _listWord.Count) {
            _isCompletelyHidden = true;
        }
        return _isCompletelyHidden;
    }

    public string GetRenderedText(){
        int nWords = _listWord.Count;
        string text = "";
        foreach (Word w in _listWord) {
            text += w.GetRenderedText();
            text += " ";
            
        }
        return text;
    }

    public void Display(){
        string toDisplay = _reference.GetBook();
        toDisplay += " " + _reference.GetChapter().ToString();
        string verseStart = _reference.GetVerseStart().ToString();
        string verseEnd   = _reference.GetVerseEnd().ToString();
        toDisplay += ":" + verseStart;
        if (verseStart != verseEnd) {
            toDisplay += "-" + verseEnd;
        }
        toDisplay += " " + GetRenderedText();
        //
        Console.WriteLine(toDisplay);
    }
}