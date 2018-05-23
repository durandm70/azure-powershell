// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Version2016_09_01
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DomainRegistrationProviderOperations.
    /// </summary>
    public static partial class DomainRegistrationProviderOperationsExtensions
    {
            /// <summary>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </summary>
            /// <remarks>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<CsmOperationDescription> ListOperations(this IDomainRegistrationProviderOperations operations)
            {
                return operations.ListOperationsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </summary>
            /// <remarks>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CsmOperationDescription>> ListOperationsAsync(this IDomainRegistrationProviderOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </summary>
            /// <remarks>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<CsmOperationDescription> ListOperationsNext(this IDomainRegistrationProviderOperations operations, string nextPageLink)
            {
                return operations.ListOperationsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </summary>
            /// <remarks>
            /// Implements Csm operations Api to exposes the list of available Csm Apis
            /// under the resource provider
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<CsmOperationDescription>> ListOperationsNextAsync(this IDomainRegistrationProviderOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListOperationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
