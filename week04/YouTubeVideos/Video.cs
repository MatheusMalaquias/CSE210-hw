public class Video {
 private string _title;    
 private string _author;    
 private int _length;
 private List<Comment> _comments = new List<Comment>();    

 public Video(string title, string author, int length, List<Comment> comments) {
    _title = title;
    _author = author;
    _length = length;
    _comments = comments;
 }
 public int NumberOfComments() {
     return _comments.Count;
 }
 public void AddComment(Comment comment) {
     _comments.Add(comment);
 }

 public string GetIntroduction() {
    return $"{_title} by {_author}, length: {_length} seconds\n";
 }

 public string GetComments() {
     string comments = "Comments:\n";
     foreach (Comment comment in _comments) {
         comments += $"{comment.GetAuthor()}: {comment.GetText()}\n";
     }
     return comments;
 }   

}