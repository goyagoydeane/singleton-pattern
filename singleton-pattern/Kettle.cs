using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton_pattern
{
    public class Kettle
    {
        private static readonly Lazy<Kettle> singleton = new Lazy<Kettle>(() => new Kettle());
        public static Kettle GetInstance() => singleton.Value;

        private Type type;

        private Kettle()
        {
            Console.WriteLine("Starting");
            type = Type.Empty;
        }

        public void Fill()
        {
            if (!IsEmpty) return;
            Console.WriteLine("Filling...");
            type = Type.InProgress;
        }

        public void Drain()
        {
            if (!IsBoiled) return;
            Console.WriteLine("Draining...");
            type = Type.Empty;
        }

        public void Boil()
        {
            if (IsBoiled || IsEmpty) return;
            Console.WriteLine("Boiling...");
            type = Type.Boiled;
        }

        private bool IsEmpty => (type == Type.Empty);
        private bool IsBoiled => (type == Type.Boiled);

        private enum Type
        {
            Empty,
            InProgress,
            Boiled
        }
    }
}
