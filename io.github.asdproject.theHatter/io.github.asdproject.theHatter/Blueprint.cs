namespace io.github.asdproject.theHatter
{
    using interfaces;

    public class Blueprint<T> : IBlueprint<T>
    {
        private string _sourceCode;
        
        public T Object { get; private set; }
        
        public Blueprint()
        {
            
        }
    }
}
