﻿/*
 * Copyright 2011 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.ServiceModel.Channels;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;

using Pyro.ADHA.mcaR32.ProviderSearchHIProviderDirectoryForOrganisation;
using Pyro.ADHA.VendorLibrary.Common;

namespace Pyro.ADHA.VendorLibrary.HI
{
    /// <summary>
    /// An implementation of a client for the Medicare Healthcare Identifiers service. This class may be used to 
    /// connect to Medicare's service to perform organisation searches, for provider information already
    /// published to the HPD.
    /// </summary>
    public class ProviderSearchHIProviderDirectoryForOrganisationClient : IDisposable
    {
            internal ProviderSearchHIProviderDirectoryForOrganisationPortType providerSearchHIProviderDirectoryForOrganisationClient;

            /// <summary>
            /// SOAP messages for the last client call.
            /// </summary>
            public HIEndpointProcessor.SoapMessages SoapMessages { get; set; }

            /// <summary>
            /// The ProductType to be used in all searches.
            /// </summary>
            ProductType product;

            /// <summary>
            /// The User to be used in all searches.
            /// </summary>
            QualifiedId user;

            /// <summary>
            /// The hpio of the organisation.
            /// </summary>
            QualifiedId hpio;

            /// <summary>
            /// Gets the timestamp for the soap request.
            /// </summary>
            public TimestampType LastSoapRequestTimestamp { get; private set; }

            /// <summary>
            /// HI service name.
            /// </summary>
            public const string HIServiceOperation = "ProviderSearchHIProviderDirectoryForOrganisation";

            /// <summary>
            /// HI service version.
            /// </summary>
            public const string HIServiceVersion = "3.2.0";

            #region Constructors

            /// <summary>
            /// Initializes an instance of the organisation search client.
            /// </summary>
            /// <param name="endpointUri">Web service endpoint for Medicare's organisation search service.</param>
            /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
            /// <param name="user">Identifier for the application that is calling the service.</param>
            /// <param name="signingCert">Certificate to sign the soap message with.</param>
            /// <param name="tlsCert">Certificate for establishing TLS connection to the service.</param>
            public ProviderSearchHIProviderDirectoryForOrganisationClient(Uri endpointUri, ProductType product, QualifiedId user, QualifiedId hpio, X509Certificate2 signingCert, X509Certificate2 tlsCert)
            {
                Validation.ValidateArgumentRequired("endpointUri", endpointUri);

                InitializeClient(endpointUri.ToString(), null, signingCert, tlsCert, product, user, hpio);
            }

            /// <summary>
            /// Initializes an instance of the organisation search client.
            /// </summary>
            /// <param name="endpointConfigurationName">Endpoint configuration name for the organisation search endpoint.</param>
            /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
            /// <param name="user">Identifier for the application that is calling the service.</param>
            /// <param name="signingCert">Certificate to sign the soap message with.</param>
            /// <param name="tlsCert">Certificate for establishing TLS connection to the service.</param>
            public ProviderSearchHIProviderDirectoryForOrganisationClient(string endpointConfigurationName, ProductType product, QualifiedId user, QualifiedId hpio, X509Certificate2 signingCert, X509Certificate2 tlsCert)
            {
                Validation.ValidateArgumentRequired("endpointConfigurationName", endpointConfigurationName);

                InitializeClient(null, endpointConfigurationName, signingCert, tlsCert, product, user, hpio);
            }

            #endregion

            /// <summary>
            /// Perform a identifier search on the organisation search service.  
            /// </summary>
            /// <param name="request">
            /// The search criteria. The following fields are expected:
            /// <list type="bullet">
            /// <item><description>hpioNumber (Mandatory)</description></item>
            /// <item><description>linkSearchType (Conditional)</description></item>
            /// </list>
            /// All other fields are to be null.
            /// </param>
            /// <returns>
            /// A response instance containing the result of the search:
            /// <list type="bullet">
            /// <item><description>serviceMessages</description></item>
            /// <item>
            ///     <description><b>organisationProviderDirectoryEntries</b> 
            ///     <list type="bullet">
            ///         <item><description>hpioNumber</description></item>
            ///         <item><description>organisationName</description></item>
            ///         <description><b>organisationDetails</b> 
            ///         <list type="bullet">
            ///             <item><description>australianBusinessNumber</description></item>
            ///             <item><description>australianCompanyNumber</description></item>
            ///         </list>
            ///         </description>  
            ///         <item><description>organisationService</description></item>
            ///         <item><description>address</description></item>
            ///         <item><description>electronicCommunicationRecord</description></item>
            ///         <item><description>endpointLocatorService</description></item>
            ///         <item><description>linkedProviders</description></item>
            ///         <item><description>linkedOrganisations</description></item>
            ///         <item><description>additionalComments</description></item>
            ///         <item><description>priorityNumber</description></item>
            ///     </list>
            ///     </description>
            /// </item>
            /// </list>
            /// </returns>
            public searchHIProviderDirectoryForOrganisationResponse IdentifierSearch (searchHIProviderDirectoryForOrganisation request)
            {
                Validation.ValidateArgumentRequired("request.hpioNumber", request.hpioNumber);
                Validation.ValidateArgumentNotAllowed("request.australianAddressCriteria", request.australianAddressCriteria);
                Validation.ValidateArgumentNotAllowed("request.internationalAddressCriteria", request.internationalAddressCriteria);
                Validation.ValidateArgumentNotAllowed("request.name", request.name);
                Validation.ValidateArgumentNotAllowed("request.organisationDetails", request.organisationDetails);
                Validation.ValidateArgumentNotAllowed("request.organisationType", request.organisationType);
                Validation.ValidateArgumentNotAllowed("request.serviceType", request.serviceType);
                Validation.ValidateArgumentNotAllowed("request.unitType", request.unitType);
    
                return HISearch(request);
            }

            /// <summary>
            /// Perform a demographic details search on the organisation search service. 
            /// </summary>
            /// <param name="request">
            /// The search criteria. The following fields can be provided:
            /// <list type="bullet">
            /// <item><description>name (Conditional)</description></item>
            /// <item><description>organisationType (Optional)</description></item>
            /// <item><description>serviceType (Optional)</description></item>
            /// <item><description>unitType (Optional)</description></item>
            /// <item><description>organisationDetails (Optional)</description></item>
            /// <item>
            ///     <description><b>australianAddressCriteria</b> (Conditional)
            ///     <list type="bullet">
            ///         <item>
            ///             <description><b>unitGroup</b> (Optional)
            ///             <list type="bullet">
            ///                 <item><description>unitType (Conditional)</description></item>
            ///                 <item><description>unitNumber (Conditional)</description></item>
            ///             </list>
            ///             </description>
            ///         </item>
            ///         <item>
            ///             <description><b>levelGroup</b> (Optional)
            ///             <list type="bullet">
            ///                 <item><description>levelType (Conditional)</description></item>
            ///                 <item><description>levelNumber (Optional)</description></item>
            ///             </list>
            ///             </description>
            ///         </item>
            ///         <item><description>addressSiteName (Optional)</description></item>
            ///         <item><description>streetNumber (Optional)</description></item>
            ///         <item><description>lotNumber (Optional)</description></item>
            ///         <item><description>streetName (Optional)</description></item>
            ///         <item><description>streetType (Conditional on if streetTypeSpecified is set to true)</description></item>
            ///         <item><description>streetTypeSpecified (Mandatory)</description></item>
            ///         <item><description>streetSuffix (Conditional on if streetSuffixSpecified is set to true)</description></item>
            ///         <item><description>streetSuffixSpecified (Mandatory)</description></item>
            ///         <item>
            ///             <description><b>postalDeliveryGroup</b> (Optional)
            ///             <list type="bullet">
            ///                 <item><description>deliveryType (Mandatory)</description></item>
            ///                 <item><description>deliveryNumber (Optional)</description></item>
            ///             </list>
            ///             </description>
            ///         </item>
            ///         <item><description>unstructuredAddressLine (Conditional)</description></item> 
            ///         <item><description>suburb (Mandatory)</description></item>
            ///         <item><description>state (Mandatory)</description></item>
            ///         <item><description>postcode (Mandatory)</description></item>
            ///     </list>
            ///     </description>
            /// </item>
            /// <item>
            ///     <description><b>internationalAddress</b> (Optional)
            ///     <list type="bullet">
            ///         <item><description>internationalAddressLine (Mandatory)</description></item>
            ///         <item><description>internationalStateProvince (Mandatory)</description></item>
            ///         <item><description>internationalPostcode (Mandatory)</description></item>
            ///         <item><description>country (Mandatory)</description></item>
            ///     </list>
            ///     </description>
            /// </item>
            /// </list>
            /// All other fields are to be null.
            /// </param>
            /// <returns>
            /// A response instance containing the result of the search:
            /// <list type="bullet">
            /// <item><description>serviceMessages</description></item>
            /// <item>
            ///     <description><b>organisationProviderDirectoryEntries</b> 
            ///     <list type="bullet">
            ///         <item><description>hpioNumber</description></item>
            ///         <item><description>organisationName</description></item>
            ///         <description><b>organisationDetails</b> 
            ///         <list type="bullet">
            ///             <item><description>australianBusinessNumber</description></item>
            ///             <item><description>australianCompanyNumber</description></item>
            ///         </list>
            ///         </description>  
            ///         <item><description>organisationService</description></item>
            ///         <item><description>address</description></item>
            ///         <item><description>electronicCommunicationRecord</description></item>
            ///         <item><description>endpointLocatorService</description></item>
            ///         <item><description>linkedProviders</description></item>
            ///         <item><description>linkedOrganisations</description></item>
            ///         <item><description>additionalComments</description></item>
            ///         <item><description>priorityNumber</description></item>
            ///     </list>
            ///     </description>
            /// </item>
            /// </list>
            /// </returns>
            public searchHIProviderDirectoryForOrganisationResponse DemographicSearch(searchHIProviderDirectoryForOrganisation request)
            {
                Validation.ValidateArgumentNotAllowed("request.hpioNumber", request.hpioNumber);
                Validation.ValidateArgumentNotAllowed("request.linkSearchType", request.linkSearchType);

                if (request.australianAddressCriteria != null)
                {
                    Validation.ValidateArgumentNotAllowed("request.internationalAddressCriteria", request.internationalAddressCriteria);
                    Validation.ValidateArgumentRequired("request.australianAddressCriteria.suburb", request.australianAddressCriteria.suburb);
                    Validation.ValidateArgumentRequired("request.australianAddressCriteria.state", request.australianAddressCriteria.state);
                    Validation.ValidateArgumentRequired("request.australianAddressCriteria.postcode", request.australianAddressCriteria.postcode);
                }

                if (request.internationalAddressCriteria != null)
                {
                    Validation.ValidateArgumentNotAllowed("request.australianAddressCriteria", request.australianAddressCriteria);
                    Validation.ValidateArgumentRequired("request.internationalAddressCriteria.internationalAddressLine", request.internationalAddressCriteria.internationalAddressLine);
                    Validation.ValidateArgumentRequired("request.internationalAddressCriteria.internationalStateProvince", request.internationalAddressCriteria.internationalStateProvince);
                    Validation.ValidateArgumentRequired("request.internationalAddressCriteria.internationalPostcode", request.internationalAddressCriteria.internationalPostcode);
                    Validation.ValidateArgumentRequired("request.internationalAddressCriteria.country", request.internationalAddressCriteria.country);
                }

                return HISearch(request);
            }

            /// <summary>
            /// Perform the service call.
            /// </summary>
            /// <param name="request">The search criteria in a searchHIProviderDirectoryForOrganisation object.</param>
            /// <returns>The search results in a searchHIProviderDirectoryForOrganisationResponse object.</returns>
            private searchHIProviderDirectoryForOrganisationResponse HISearch(searchHIProviderDirectoryForOrganisation request)
            {
                searchHIProviderDirectoryForOrganisationRequest envelope = new searchHIProviderDirectoryForOrganisationRequest();

                envelope.searchHIProviderDirectoryForOrganisation = request;
                envelope.product = product;
                envelope.user = user;
                envelope.hpio = hpio;
                envelope.signature = new SignatureContainerType();

                envelope.timestamp = new TimestampType()
                {
                    created = DateTime.Now,
                    expires = DateTime.Now.AddDays(30),
                    expiresSpecified = true
                };

                // Set LastSoapRequestTimestamp
                LastSoapRequestTimestamp = envelope.timestamp;

                searchHIProviderDirectoryForOrganisationResponse1 response1 = null;

                try
                {
                    response1 = providerSearchHIProviderDirectoryForOrganisationClient.searchHIProviderDirectoryForOrganisation(envelope);
                }
                catch (Exception ex)
                {
                    // Catch generic FaultException and call helper to throw a more specific fault
                    // (FaultException<ServiceMessagesType>
                    FaultHelper.ProcessAndThrowFault<ServiceMessagesType>(ex);
                }

                if (response1 != null && response1.searchHIProviderDirectoryForOrganisationResponse != null)
                    return response1.searchHIProviderDirectoryForOrganisationResponse;
                else
                    throw new ApplicationException(Properties.Resources.UnexpectedServiceResponse);
            }

            #region Private and internal methods

            /// <summary>
            /// Initialization for the Medicare organisation search client.
            /// </summary>
            /// <param name="endpointUrl">Web service endpoint for the Medicare organisation search.</param>
            /// <param name="endpointConfigurationName">Endpoint configuration name for the Medicare's organisation search endpoint.</param>
            /// <param name="signingCert">Certificate to sign the soap message with.</param>
            /// <param name="tlsCert">Certificate for establishing TLS connection to the service.</param>
            /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
            /// <param name="user">Identifier for the application that is calling the service.</param>
            /// <param name="hpio">Identifier for the organisation</param>
            private void InitializeClient(string endpointUrl, string endpointConfigurationName, X509Certificate2 signingCert, X509Certificate2 tlsCert, ProductType product, QualifiedId user, QualifiedId hpio)
            {
                Validation.ValidateArgumentRequired("product", product);
                Validation.ValidateArgumentRequired("user", user);
                Validation.ValidateArgumentRequired("signingCert", signingCert);
                Validation.ValidateArgumentRequired("tlsCert", tlsCert);

                this.product = product;
                this.user = user;
                this.hpio = hpio;

                SoapMessages = new HIEndpointProcessor.SoapMessages();

                CustomBinding tlsBinding = GetBinding();

                ProviderSearchHIProviderDirectoryForOrganisationPortTypeClient client = null;

                if (!string.IsNullOrEmpty(endpointUrl))
                {
                    EndpointAddress address = new EndpointAddress(endpointUrl);

                    client = new ProviderSearchHIProviderDirectoryForOrganisationPortTypeClient(tlsBinding, address);
                }
                else if (!string.IsNullOrEmpty(endpointConfigurationName))
                {
                    client = new ProviderSearchHIProviderDirectoryForOrganisationPortTypeClient(endpointConfigurationName);
                }

                if (client != null)
                {
                    HIEndpointProcessor.ProcessEndpoint(client.Endpoint, signingCert, SoapMessages);

                    if (tlsCert != null) client.ClientCredentials.ClientCertificate.Certificate = tlsCert;
                    providerSearchHIProviderDirectoryForOrganisationClient = client;
                }
            }

            /// <summary>
            /// Gets the binding configuration for the client.
            /// </summary>
            /// <returns>Configured customBinding instance.</returns>
            internal CustomBinding GetBinding()
            {
                // Set up binding
                CustomBinding tlsBinding = new CustomBinding();

                TextMessageEncodingBindingElement tlsEncoding = new TextMessageEncodingBindingElement();
                tlsEncoding.ReaderQuotas.MaxDepth = 2147483647;
                tlsEncoding.ReaderQuotas.MaxStringContentLength = 2147483647;
                tlsEncoding.ReaderQuotas.MaxArrayLength = 2147483647;
                tlsEncoding.ReaderQuotas.MaxBytesPerRead = 2147483647;
                tlsEncoding.ReaderQuotas.MaxNameTableCharCount = 2147483647;

                HttpsTransportBindingElement httpsTransport = new HttpsTransportBindingElement();
                httpsTransport.RequireClientCertificate = true;
                httpsTransport.MaxReceivedMessageSize = 2147483647;
                httpsTransport.MaxBufferSize = 2147483647;

                tlsBinding.Elements.Add(tlsEncoding);
                tlsBinding.Elements.Add(httpsTransport);

                return tlsBinding;
            }

            #endregion

            #region IDisposable Members

            /// <summary>
            /// Closes and disposes the client.
            /// </summary>
            public void Dispose()
            {
                ClientBase<ProviderSearchHIProviderDirectoryForOrganisationPortType> lClient;

                if (providerSearchHIProviderDirectoryForOrganisationClient is ClientBase<ProviderSearchHIProviderDirectoryForOrganisationPortType>)
                {
                    lClient = (ClientBase<ProviderSearchHIProviderDirectoryForOrganisationPortType>)providerSearchHIProviderDirectoryForOrganisationClient;
                    if (lClient.State != CommunicationState.Closed)
                        lClient.Close();
                }
            }

            #endregion
    }
 }