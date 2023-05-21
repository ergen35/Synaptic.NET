namespace Synaptic.NET;

public interface ICallResponse<T>
{
    public T Result { get; set; }
    public bool IsSuccessfull { get; set; }

    public object Errors { get; set; }
    public object CallData { get; set; }
}
