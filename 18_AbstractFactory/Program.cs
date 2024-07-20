namespace _18_AbstractFactory
{
    public abstract class Processor
    {
        public string Name { get; set; }
        public Processor(string name)
        {
            Name = name;
        }
        virtual public void Print()
        {
            Console.WriteLine($"I am a Processor  . My name : {Name}");
        }
    }
    public abstract class MainBoard
    {
        public string Name { get; set; }
        public MainBoard(string name)
        {
            Name = name;
        }
        virtual public void Print()
        {
            Console.WriteLine($"I am a MainBoard . My name : {Name}");
        }
    }
    public abstract class Box
    {
        public string Name { get; set; }
        public Box(string name)
        {
            Name = name;
        }
        virtual public void Print()
        {
            Console.WriteLine($"I am a Box . My name : {Name}");
        }
    }
    public abstract class Hdd
    {
        public string Name { get; set; }
        public Hdd(string name)
        {
            Name = name;
        }
        virtual public void Print()
        {
            Console.WriteLine($"I am a Hdd . My name : {Name}");
        }
    }
    public abstract class Memory
    {
        public string Name { get; set; }
        public Memory(string name)
        {
            Name = name;
        }
        virtual public void Print()
        {
            Console.WriteLine($"I am a Memory . My name : {Name}");
        }
    }

    public class AmdProcessor : Processor
    {
        public AmdProcessor(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a AmdProcessor . My name : {Name}");
        }
    }
    public class IntelProcessor : Processor
    {
        public IntelProcessor(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a IntelProcessor . My name : {Name}");
        }
    }
    public class AsusMainBoard : MainBoard
    {
        public AsusMainBoard(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a AsusMainBoard . My name : {Name}");
        }
    }
    public class MSIMainBoard : MainBoard
    {
        public MSIMainBoard(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a MSIMainBoard . My name : {Name}");
        }
    }
    public class BlackBox : Box
    {
        public BlackBox(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a BlackBox . My name : {Name}");
        }
    }
    public class SilverBox : Box
    {
        public SilverBox(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a SilverBox . My name : {Name}");
        }
    }
    public class LGHDD : Hdd
    {
        public LGHDD(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a LGHDD . My name : {Name}");
        }
    }
    public class SamsungHDD : Hdd
    {
        public SamsungHDD(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a SamsungHDD . My name : {Name}");
        }
    }
    public class DdrMemory : Memory
    {
        public DdrMemory(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a DdrMemory . My name : {Name}");
        }
    }
    public class Ddr2Memory : Memory
    {
        public Ddr2Memory(string name) : base(name) { }

        public override void Print()
        {
            Console.WriteLine($"I am a Ddr2Memory . My name : {Name}");
        }
    }


    public interface IPCFactory
    {
        Processor CreateProcessor();
        MainBoard CreateMainBoard();
        Box CreateBox();
        Hdd CreateHdd();
        Memory CreateMemory();
    }
    public class OfficePcFactory : IPCFactory
    {
        public Processor CreateProcessor()
        {
            return new AmdProcessor("AmdProcessor");
        }
        public MainBoard CreateMainBoard()
        {
            return new AsusMainBoard("AsusMainBoard");
        }
        public Box CreateBox()
        {
            return new BlackBox("BlackBox");
        }

        public Hdd CreateHdd()
        {
            return new LGHDD("LGHDD");
        }
        public Memory CreateMemory()
        {
            return new DdrMemory("DdrMemory");
        }
    }
    public class HomePcFactory : IPCFactory
    {
        public Processor CreateProcessor()
        {
            return new IntelProcessor("IntelProcessor");
        }
        public MainBoard CreateMainBoard()
        {
            return new MSIMainBoard("MSIMainBoard");
        }
        public Box CreateBox()
        {
            return new SilverBox("SilverBox");
        }

        public Hdd CreateHdd()
        {
            return new SamsungHDD("SamsungHDD");
        }
        public Memory CreateMemory()
        {
            return new Ddr2Memory("DdrMemory");
        }
    }

    public class Pc
    {
        public Processor Processor { get; set; }
        public MainBoard MainBoard { get; set; }
        public Box Box { get; set; }
        public Hdd Hdd { get; set; }
        public Memory Memory { get; set; }
        public void Print()
        {
            Processor.Print();
            MainBoard.Print();
            Box.Print();
            Hdd.Print();
            Memory.Print();
        }
    }
    public class PcConfigurator
    {
        IPCFactory IPCFactory { get; set; }
        public PcConfigurator(IPCFactory iPCFactory)
        {
            IPCFactory = iPCFactory;
        }
        public void Configurator(Pc pc)
        {
            pc.Processor = IPCFactory.CreateProcessor();
            pc.MainBoard = IPCFactory.CreateMainBoard();
            pc.Box = IPCFactory.CreateBox();
            pc.Hdd = IPCFactory.CreateHdd();
            pc.Memory = IPCFactory.CreateMemory();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IPCFactory pCFactory = new OfficePcFactory();
            Pc pc = new Pc();
            PcConfigurator configurator = new PcConfigurator(pCFactory);
            configurator.Configurator(pc);
            pc.Print();
            Console.WriteLine();
            pCFactory = new HomePcFactory();
            configurator = new PcConfigurator(pCFactory);
            configurator.Configurator(pc);
            pc.Print();

        }
    }
}
