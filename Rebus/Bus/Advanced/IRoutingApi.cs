using System.Collections.Generic;
using System.Threading.Tasks;
using Rebus.Routing;

namespace Rebus.Bus.Advanced
{
    /// <summary>
    /// Provides a raw API for explicitly routing messages to other endpoints
    /// </summary>
    public interface IRoutingApi
    {
        /// <summary>
        /// Explicitly routes the <paramref name="explicitlyRoutedMessage"/> to the destination specified by <paramref name="destinationAddress"/>
        /// </summary>
        Task Send(string destinationAddress, object explicitlyRoutedMessage, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Sends the message as a routing slip that will visit the destinations specified by the given <see cref="Itinerary"/>
        /// </summary>
        Task SendRoutingSlip(Itinerary itinerary, object message, Dictionary<string, string> optionalHeaders = null);
    }
}