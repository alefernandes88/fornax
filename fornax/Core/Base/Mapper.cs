namespace fornax.Core.Base
{
    public abstract class Mapper<I, O>
    {
        public abstract O mapFrom(I param);
        public abstract I mapTo(O param);
    }
}
