using System;

namespace Synaptic.NET
{
    public record class CallError(CallErrorType ErrorType, int StatusCode, string ErrorMessage, Exception Exception = null);
}


