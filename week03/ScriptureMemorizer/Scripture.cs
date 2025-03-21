using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
        public class Scripture
        {
            private Reference Reference { get; }
            private List<Word> Words { get; }
            private Random random = new Random();

            public Scripture(Reference reference, string text)
            {
            Reference = reference;
            Words = text.Split(' ').Select(w => new Word(w)).ToList();
            }

            public void HideRandomWords(int count)
            {
            var visibleWords = Words.Where(w => !w.IsHidden).ToList();
            if (visibleWords.Count == 0) return;

            for (int i = 0; i < count && visibleWords.Count > 0; i++)
            {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
            }
        }

        public bool IsCompletelyHidden()
        {
        return Words.All(w => w.IsHidden);
        }

        public string GetDisplayText()
        {
        return $"{Reference}\n{string.Join(" ", Words)}";
        }
    }
}