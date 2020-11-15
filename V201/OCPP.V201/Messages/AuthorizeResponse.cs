using System;
using OCPP.V201.Core;

namespace OCPP.V201
{
    public partial class AuthorizeResponse : ResponseBase<AuthorizeRequest, AuthorizeResponse>
    {
        /// <summary>
        /// The identification token info.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("idTokenInfo", Required = Newtonsoft.Json.Required.Always)]
        public IdTokenInfo IdTokenInfo { get; set; } = new IdTokenInfo();

        //[Newtonsoft.Json.JsonProperty("certificateStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //[Newtonsoft.Json.JsonConverter(of(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizeCertificateStatus CertificateStatus { get; set; }

        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        /// <summary>
        /// Create an authorize response.
        /// </summary>
        /// <param name="request">The authorize request leading to this response.</param>
        /// <param name="idTokenInfo">The identification token info.</param>
        /// <param name="customData">An optional custom data object to allow to store any kind of customer specific data.</param>
        public AuthorizeResponse(AuthorizeRequest request, IdTokenInfo idTokenInfo, CustomData customData = null) : base(request, Result.OK())
        {
            IdTokenInfo = idTokenInfo;
            CustomData = customData;
        }

        /// <summary>
        /// Create an authorize response.
        /// </summary>
        /// <param name="request">The authorize request leading to this response.</param>
        /// <param name="result">The result.</param>
        public AuthorizeResponse(AuthorizeRequest request, Result result) : base(request, result)
        {
            this.IdTokenInfo = new IdTokenInfo(AuthorizationStatus.Unknown);
        }

        /// <summary>
        /// The authentication failed.
        /// </summary>
        /// <param name="Request">The authorize request leading to this response.</param>
        public static AuthorizeResponse Failed(AuthorizeRequest request) => new AuthorizeResponse(request,new IdTokenInfo(AuthorizationStatus.Invalid));

        /// <summary>
        /// Compares two authorize responses for equality.
        /// </summary>
        /// <param name="AuthorizeResponse">A authorize response to compare with.</param>
        /// <returns>True if both match; False otherwise.</returns>
        //public override bool Equals(AuthorizeResponse AuthorizeResponse)
        //{

        //    if (AuthorizeResponse is null)
        //        return false;

        //    return IdTokenInfo.Equals(AuthorizeResponse.IdTokenInfo);

        //}
    }
}