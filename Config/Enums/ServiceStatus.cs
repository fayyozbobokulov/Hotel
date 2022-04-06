namespace Hotel.Config.Enums
{
    [Flags]
    public enum ServiceStatus
    {
        AVAILABLE,
        NOTAVAILABLE,
        MAINTENANCE,
        CHANGED,
        REMOVED
    }
}
