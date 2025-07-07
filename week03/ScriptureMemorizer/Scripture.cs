using System;

public class Scripture {
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words) {
        _reference = reference;
        _words = words;
    }

    public void HideRandomWord(int nuumberToHide) {
        Random random = new Random();
  // this is to hide 3 line per time
        for (int i = 0; i < nuumberToHide; i++) {
            int index = random.Next(_words.Count);
            bool isHiden = _words[index].IsHidden();
            if (isHiden) {
                i--;
            } else {
                _words[index].Hide();
            }
        }
        

    }

    public string GetDisplayText() {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words) {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden() {
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                return false;
            }
        }
        return true;
    }
}