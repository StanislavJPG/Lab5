namespace TestProject
{
    internal interface IMyDictionary<Tkey, Tval>
    {
        Tval this[Tkey key] { get; }

        int Counter { get; }

        void Add(Tkey key, Tval val);
    }
}