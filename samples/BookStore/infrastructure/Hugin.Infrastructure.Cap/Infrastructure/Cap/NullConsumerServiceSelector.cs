using DotNetCore.CAP.Internal;
using System.Collections.Generic;

namespace LG.NetCore.Infrastructure.Cap
{
    public class NullConsumerServiceSelector : IConsumerServiceSelector
    {
        public IReadOnlyList<ConsumerExecutorDescriptor> SelectCandidates()
        {
            return new List<ConsumerExecutorDescriptor>();
        }

        public ConsumerExecutorDescriptor SelectBestCandidate(string key, IReadOnlyList<ConsumerExecutorDescriptor> candidates)
        {
            return new ConsumerExecutorDescriptor();
        }
    }
}
