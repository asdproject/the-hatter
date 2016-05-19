namespace io.github.asdproject.theHatter
{
    using interfaces;

    public class Blueprint<T> : IBlueprint<T>
    {
        public T Object { get; private set; }
    }
}
