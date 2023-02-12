public class Reference {
    string _book;
    int _chapter;
    int _verse_start;
    int _verse_end;
    
    Dictionary<string, Dictionary<int, Dictionary<int, string>>> _dict =
        new Dictionary<string, Dictionary<int, Dictionary<int, string>>> {
            {
                "Proverbs", new Dictionary<int, Dictionary<int, string>> {
                    {
                        3, new Dictionary<int, string> {
                            {
                                1, ""
                            },
                            {
                                2, ""
                            },
                            {
                                3, ""
                            },
                            {
                                4, ""
                            },
                            {
                                5, "Trust in the Lord with all thine bheart; and lean not unto thine cown dunderstanding."
                            },
                            {
                                6, "In all thy ways aacknowledge him, and he shall bdirect thy cpaths."
                            }
                        }
                    }
                }
            },
            {
                "Matthew", new Dictionary<int, Dictionary<int, string>> {
                    {
                        1, new Dictionary<int, string> {
                            {
                                1, ""
                            },
                            {
                                2, ""
                            }
                        }
                    }
                }
            }
        };
    //    

    public Reference( string book, int chapter, int verse_start){
        //
        _book = book;
        _chapter = chapter;
        _verse_start = verse_start;
        _verse_end   = verse_start;
    }

    public Reference( string book, int chapter, int verse_start, int verse_end){
        //
        _book = book;
        _chapter = chapter;
        _verse_start = verse_start;
        _verse_end   = verse_end;
    }

    public string GetSCriptureText(){
        string text = "";
        for (int i = _verse_start; i <= _verse_end; i++) {
            text += _dict[_book][_chapter][i] + " ";
        }
        return text;
    }
}