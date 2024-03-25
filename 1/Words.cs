using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Words : IEnumerable<string>
    {
        private string[] words;

        public Words(string[] words)
        { 
            this.words = words; 
        }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var w in words)
                if (w.Length >= 5)
                    yield return w;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var w in words)
                if (w.Length >= 5)
                    yield return w;
        }
    }
}
