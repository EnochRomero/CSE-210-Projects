using System;
using System.Collections.Generic;
using RandomPrompt;

namespace Entry
{
    public class UserEntry

    {
        public DateTime _currentDateTime = DateTime.Now;

        public string _userTextEntry = "";

        public string _userMood = "";

        public string _givenPrompt = RandomPromptGenerator.GetRandomPrompt();

        public string MakeEntry()
        {
            string entry = $"{_currentDateTime}\nRandom Prompt: {_givenPrompt}\n{_userTextEntry}\nToday's Mood: {_userMood}";

            return entry;
        }



    } 
}