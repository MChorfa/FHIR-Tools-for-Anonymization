﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MicrosoftFhir.Anonymizer.Core
{
    public interface IFhirDataConsumer<T>
    {
        Task<int> ConsumeAsync(IEnumerable<T> data);

        Task CompleteAsync();
    }
}
