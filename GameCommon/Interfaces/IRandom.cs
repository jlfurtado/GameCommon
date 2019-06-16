namespace GameCommon.Interfaces
{
    public interface IRandom<T>
    {
        T Next(T min, T max);
    }
}
