// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Microsoft.PowerBI;
    using Microsoft.PowerBI.Api;
    using Microsoft.PowerBI.Api.V2;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Power BI Clone Report Request
    /// </summary>
    public partial class CloneReportRequest
    {
        /// <summary>
        /// Initializes a new instance of the CloneReportRequest class.
        /// </summary>
        public CloneReportRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloneReportRequest class.
        /// </summary>
        /// <param name="name">The requested report name</param>
        /// <param name="targetWorkspaceId">Optional parameter for specifying
        /// the target workspace id</param>
        /// <param name="targetModelId">Optional parameter for specifying the
        /// target associated model (dataset) id</param>
        public CloneReportRequest(string name = default(string), string targetWorkspaceId = default(string), string targetModelId = default(string))
        {
            Name = name;
            TargetWorkspaceId = targetWorkspaceId;
            TargetModelId = targetModelId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the requested report name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets optional parameter for specifying the target workspace
        /// id
        /// </summary>
        [JsonProperty(PropertyName = "targetWorkspaceId")]
        public string TargetWorkspaceId { get; set; }

        /// <summary>
        /// Gets or sets optional parameter for specifying the target
        /// associated model (dataset) id
        /// </summary>
        [JsonProperty(PropertyName = "targetModelId")]
        public string TargetModelId { get; set; }

    }
}
