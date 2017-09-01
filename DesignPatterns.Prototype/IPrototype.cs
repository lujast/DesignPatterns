namespace DesignPatterns.Prototype
{
    public  interface IPrototype
    {
       
        IPrototype Clone(bool deepCopy);

    }
}