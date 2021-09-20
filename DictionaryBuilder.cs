using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class DictionaryBuilder : IKeyValueCollectionBuilder
    {
        private Dictionary<string, string> Dictionary = new Dictionary<string, string>();
        public IKeyValueCollectionBuilder Add(string key, string value)
        {
            Dictionary[key] = value;
            return this;
        }
        public Dictionary<string, string> Build()
        {
            return Dictionary;
        }
    }
}
