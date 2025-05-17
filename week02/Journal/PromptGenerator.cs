public class PromptGenerator
{
   public List<string> _prompts = new List<string>();

   public PromptGenerator()
   {
        _prompts.Add("What made me feel most proud of myself today?");
        _prompts.Add("Where do I want to be in 1 year? What can I do today to move toward that?");
        _prompts.Add("What emotion is strongest in me right now? Why?");
        _prompts.Add("What does success mean to me personally?");
        _prompts.Add("What are 3 things I’m grateful for today?");
        _prompts.Add("If my mind were a room, what would it look like right now?");
        _prompts.Add("What’s one good thing that happened today?");
        _prompts.Add("What’s something I need to hear today?");
        _prompts.Add("How did I handle stress today? Would I change anything?");
        _prompts.Add("What are 3 small goals I can set this week?");
        _prompts.Add("Who in my life has made a difference for me lately?");
        _prompts.Add("What’s a story I’d like to live?");
        _prompts.Add("What is something beautiful I noticed recently?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
   }
     


   public  string GetRandomPrompt()
   {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
   }
}