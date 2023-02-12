public class Word {
    bool _isHidden;
    string _text;
    string _renderedText;

    public Word(string text) {
        _isHidden = false;
        _text = text;
        _renderedText = text;
    }

    public void Hide(){
        _isHidden = true;
    }

    public void Show() {
        _isHidden = false;
    }

    public string GetRenderedText() {
        
        if (_isHidden) {
            int length = _text.Length;

            _renderedText = "";
            for (int i = 0; i < length; i++) {
                _renderedText += "_";
            }
        }
        return _renderedText;
    }

    public string GetString(){
        return _text;
    }
}