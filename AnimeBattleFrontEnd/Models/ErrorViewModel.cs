using System;
using System.Diagnostics.CodeAnalysis;

namespace AnimeBattleFrontEnd.Models
{
    [ExcludeFromCodeCoverage]
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
