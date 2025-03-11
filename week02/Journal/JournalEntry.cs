using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class JournalEntry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public JournalEntry(string prompt, string response)
        {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
        }

        public override string ToString()
        {
        return $"{Date.ToString("yyyy-MM-dd HH:mm:ss")}\nPrompt: {Prompt}\nResponse: {Response}\n";
        }
    }