using System.Collections.Generic;

namespace Synaptic.NET;

public interface ICallResponse<T>
{
    public T Result { get; set; }
    public bool IsSuccessful { get; set; }
    public IEnumerable<CallError> Errors { get; set; }
    public CallMetadata CallMetadata { get; set; }
}
