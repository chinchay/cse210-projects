using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("Michael", "my song", 200);
        Comment comment1a = new Comment("Junior",  "That was an awesome song!");
        Comment comment1b = new Comment("Anali",   "I want to sing like you!");
        Comment comment1c = new Comment("Gustavo", "Can you teach me, please?");
        video1.AppendToComments(comment1a);
        video1.AppendToComments(comment1b);
        video1.AppendToComments(comment1c);
        
        Video video2 = new Video("Nelbino", "How to make a stove", 800);
        Comment comment2a = new Comment("Junior",  "Can I hire you?");
        Comment comment2b = new Comment("Anali",   "What an incredible man!");
        Comment comment2c = new Comment("Gustavo", "Not bad");
        video2.AppendToComments(comment2a);
        video2.AppendToComments(comment2b);
        video2.AppendToComments(comment2c);

        Video video3 = new Video("Gustavo", "Here in my first English class", 500);
        Comment comment3a = new Comment("Junior",  "Where is that?");
        Comment comment3b = new Comment("Anali",   "What books do you use?");
        Comment comment3c = new Comment("Gustavo", "Thanks for your questions!");
        video3.AppendToComments(comment3a);
        video3.AppendToComments(comment3b);
        video3.AppendToComments(comment3c);

        List<Video> listVideo = new List<Video>();
        listVideo.Add(video1);
        listVideo.Add(video2);
        listVideo.Add(video3);

        foreach (Video video in listVideo){
            video.Display();
        }



    }
}