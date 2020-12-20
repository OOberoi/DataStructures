using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instance) //to prevent multi-threading
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }

    public class SingletonLazy
    {
        private static Lazy<SingletonLazy> _instance = new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {
        }

        public static SingletonLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }

    }
}
