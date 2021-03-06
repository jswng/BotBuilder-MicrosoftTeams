// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    /// <summary>
    /// O365 connector card image
    /// </summary>
    public partial class O365ConnectorCardImage
    {
        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardImage class.
        /// </summary>
        public O365ConnectorCardImage() { }

        /// <summary>
        /// Initializes a new instance of the O365ConnectorCardImage class.
        /// </summary>
        /// <param name="image">URL for the image</param>
        public O365ConnectorCardImage(string image = default(string))
        {
            Image = image;
        }

        /// <summary>
        /// Gets or sets URL for the image
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

    }
}
