using System;
public class Reference {
    private string _book;
    private int _chapter;
    private int _verse;
    private int endVerse;

      public Reference(string book, int chapter, int verse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        this.endVerse = endVerse;
    }

    public string GetDisplayText() {

        if (_verse == endVerse) {
            return $"{_book} {_chapter}:{_verse}";
        }

        return $"{_book} {_chapter}:{_verse}-{endVerse}";
    }

}