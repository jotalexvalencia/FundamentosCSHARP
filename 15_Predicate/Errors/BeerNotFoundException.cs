namespace _15_Predicate.Errors
{
    public class BeerNotFoundException : Exception
    {
        public BeerNotFoundException() : base() { }
        public BeerNotFoundException(string message) : base(message) { }
        public BeerNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
