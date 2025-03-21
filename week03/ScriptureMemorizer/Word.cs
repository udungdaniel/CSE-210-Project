using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    public class Word
    {
       public string Text { get; }
        public bool IsHidden { get; private set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public override string ToString()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }
}