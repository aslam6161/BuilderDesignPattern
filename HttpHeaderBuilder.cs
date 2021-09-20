using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class HttpHeaderBuilder : IKeyValueCollectionBuilder
    {
        private StringBuilder _queryStringBuilder = new StringBuilder();
        public IKeyValueCollectionBuilder Add(string key, string value)
        {
            _queryStringBuilder.Append(key);
            _queryStringBuilder.Append(":");
            _queryStringBuilder.Append(value);
            _queryStringBuilder.AppendLine();
            return this;
        }
        public string Build()
        {
            return _queryStringBuilder.ToString();
        }
    }
}
