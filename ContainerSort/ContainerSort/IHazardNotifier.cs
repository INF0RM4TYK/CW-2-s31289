namespace ContainerSort;

public interface IHazardNotifier
{
    public void NotifyHazard(string message, string containerSerialNumber);
}