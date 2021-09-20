using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueryBuilder builder = new QueryBuilder();
            //HttpHeaderBuilder builder = new HttpHeaderBuilder();
            //FormBuilder builder = new FormBuilder();
            DictionaryBuilder builder = new DictionaryBuilder();
            ConstructProcess(builder);
            var data= builder.Build();

        }

        public static void ConstructProcess(IKeyValueCollectionBuilder builder)
        {
            builder.Add("name", "aslam").Add("age", "21").Add("dob", 1990.ToString());
        }
    }
}
