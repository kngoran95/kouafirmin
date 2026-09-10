using System;
using System.Collections.Generic;



public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of my day?",
        "Who helped I today?",
        "What did I learn today?",
        "What challenge did I overcome today?",
        "How did I see the hand of the Lord in my life today?"
    };

    private Random _random = new Random();
    
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}