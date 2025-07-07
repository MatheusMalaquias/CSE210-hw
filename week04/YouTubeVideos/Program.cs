using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();
       videos.Add(new Video("Learn Classes in JavaScript", "Bruce Banner", 10000, new List<Comment> { 
        new Comment("josh123", "Great video!"), 
        new Comment("Julye", "Thanks for sharing!"), 
        new Comment("Daniel King", "I shared this with my colleagues, very useful!"), 
        new Comment("Charlotte Lewis", "Please make more content like this!"), 
        new Comment("Brandon", "Great Content!"), 
        }));

        videos.Add(new Video("Mastering Next.js in 30 Days", "Daniel Carter", 106000, new List<Comment> { 
        new Comment("Michael Brown","Great explanation, this really helped me understand the topic!"), 
        new Comment("Jessica Lee", "I love the way you break things down, super clear"), 
        new Comment("Sophia Taylor ", "Wow, I didn't know this before! Thanks for sharing."), 
        }));

        videos.Add(new Video("Understanding SQL for Data Science", "Robert Wilson", 5000000, new List<Comment> { 
        new Comment("Ethan Walker", "I learned so much from this, thank you!"), 
        new Comment("Mia Allen", "Can you make a tutorial for beginners on this topic?"), 
        new Comment("Ava Hall", "How long did it take you to prepare this video?"), 
        }));

        foreach (Video video in videos) {
            Console.WriteLine(video.GetIntroduction());
            Console.WriteLine($"Number of comments: {video.NumberOfComments()}");
            Console.WriteLine(video.GetComments());
            Console.WriteLine("=====================================");
        }
    }
}