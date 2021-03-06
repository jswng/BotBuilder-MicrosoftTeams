// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// O365 connector card action base
    /// </summary>
    public partial class O365ConnectorCardActionBase
    {
        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardActionBase
        /// class.
        /// </summary>
        public O365ConnectorCardActionBase() { }

        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardActionBase
        /// class.
        /// </summary>
        /// <param name="type">Type of the item</param>
        public O365ConnectorCardActionBase(string type = default(string))
        {
            Type = type;
        }

        /// <summary>
        /// Gets or sets type of the item
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "@type")]
        public string Type { get; set; }

    }
}
