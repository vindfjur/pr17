using System;

namespace task3
{
    [Flags]
    enum FileAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }

    struct File
    {
        public FileAccess Permissions { get; set; }

        public bool CanRead()
        {
            return (Permissions & FileAccess.Read) == FileAccess.Read;
        }

        public bool CanWrite()
        {
            return (Permissions & FileAccess.Write) == FileAccess.Write;
        }
    }

    class Program
    {
        static void Main()
        {
            var f = new File { Permissions = FileAccess.Read | FileAccess.Write };
            Console.WriteLine(f.CanRead());
            Console.WriteLine(f.CanWrite());
        }
    }
}
