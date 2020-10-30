using System;
using System.Collections.Generic;

using OCCP.Core;

namespace OCPP.V201
{
    public partial class AuthorizeRequest : RequestBase<AuthorizeRequest>
    {
        //[Newtonsoft.Json.JsonProperty("idToken", Required = Newtonsoft.Json.Required.Always)]
        public IdToken IdToken { get; set; } = new IdToken();

        /// <summary>
        /// The X.509 certificated presented by EV and encoded in PEM format.
        /// </summary>
        //[Newtonsoft.Json.JsonProperty("certificate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Certificate { get; set; }

        //[Newtonsoft.Json.JsonProperty("iso15118CertificateHashData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ICollection<OCSPRequestData> Iso15118CertificateHashData { get; set; }

        /// <summary>
        /// The custom data object to allow to store any kind of customer specific data.
        /// </summary>
        public CustomData CustomData { get; }

        /// <summary>
        /// Create an authorize request.
        /// </summary>
        /// <param name="idToken">The identifier that needs to be authorized.</param>
        /// <param name="certificate">An optional X.509 certificated presented by the electric vehicle/user (PEM format).</param>
        /// <param name="iso15118CertificateHashData">Optional information to verify the electric vehicle/user contract certificate via OCSP.</param>
        /// <param name="customData">The custom data object to allow to store any kind of customer specific data.</param>
        public AuthorizeRequest(IdToken idToken, string certificate = null, ICollection<OCSPRequestData> iso15118CertificateHashData = null, CustomData customData = null)
        {
            IdToken = idToken ?? throw new ArgumentNullException(nameof(idToken), "The identification token must not be null!");
            Certificate = certificate;
            Iso15118CertificateHashData = iso15118CertificateHashData ?? new OCSPRequestData[0];
            CustomData = customData;
        }

        /// <summary>
        /// Compares two AuthorizeRequests for equality.
        /// </summary>
        /// <param name="AuthorizeRequest">An authorize request to compare with.</param>
        /// <returns>True if both match; False otherwise.</returns>
        //public override bool Equals(AuthorizeRequest AuthorizeRequest)
        //{

        //    if (AuthorizeRequest is null)
        //        return false;

        //    return IdToken.Equals(AuthorizeRequest.IdToken);
        //}
    }
}