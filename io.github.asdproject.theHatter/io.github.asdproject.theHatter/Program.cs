namespace io.github.asdproject.theHatter
{
    using System;
    using interfaces;

    public class Test
    {
        private readonly IBlueprint<IInterface> _blueprint;
        
        public Test()
        {
            // Arrange
            _blueprint = new Blueprint<IInterface>();
            
            NotNull();
            ObjectNotNull();
        }
        
        public void NotNull()
        {
            // Assert
            if(_blueprint == null)
                throw new Exception();
        }
        
        public void ObjectNotNull()
        {
            // Assert
            if(_blueprint.Object == null)
                throw new NullReferenceException(nameof(_blueprint.Object));
        }
    }
    
    public interface IInterface
    {
        
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var test = new Test();
                        
            Console.WriteLine("SUCESS");
        }
    }
}
