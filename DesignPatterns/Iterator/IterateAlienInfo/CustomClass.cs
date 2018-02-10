using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDP
{
    public class CustomClass : IEnumerable<string>
    {

        public string Name { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }

        public IEnumerator<string> GetEnumerator()
        {
            yield return Name;
            yield return Age;
            yield return Email;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
