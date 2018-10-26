// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SharepointSite.
    /// </summary>
    public static partial class SharepointSiteExtensions
    {
            /// <summary>
            /// Delete entity from SharepointSite
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            public static void Delete(this ISharepointSite operations, string sharepointsiteid, string ifMatch = default(string))
            {
                operations.DeleteAsync(sharepointsiteid, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete entity from SharepointSite
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid
            /// </param>
            /// <param name='ifMatch'>
            /// ETag
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISharepointSite operations, string sharepointsiteid, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(sharepointsiteid, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Get entity from SharepointSite by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMSharepointSite GetByKey(this ISharepointSite operations, string sharepointsiteid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetByKeyAsync(sharepointsiteid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get entity from SharepointSite by key
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMSharepointSite> GetByKeyAsync(this ISharepointSite operations, string sharepointsiteid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByKeyWithHttpMessagesAsync(sharepointsiteid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update entity in SharepointSite
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            public static void Update(this ISharepointSite operations, string sharepointsiteid, MicrosoftDynamicsCRMSharepointSite body)
            {
                operations.UpdateAsync(sharepointsiteid, body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update entity in SharepointSite
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sharepointsiteid'>
            /// key: sharepointsiteid
            /// </param>
            /// <param name='body'>
            /// New property values
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this ISharepointSite operations, string sharepointsiteid, MicrosoftDynamicsCRMSharepointSite body, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(sharepointsiteid, body, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
