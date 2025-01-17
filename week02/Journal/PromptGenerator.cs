using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public void Prompts()
    {
        _prompts.Add("How did you see the hand of the Lord in your life today?");
        _prompts.Add("How did you hear Him today?");
        _prompts.Add("What did you accomplish today?");
        _prompts.Add("Describe three blessings received today?");
        _prompts.Add("Describe something that you learned today?");        
    }



    public string GetRandomPrompt()
    {
        Random inspiration = new Random();
        int question = inspiration.Next(_prompts.Count);

        return _prompts[question];
    }

}
