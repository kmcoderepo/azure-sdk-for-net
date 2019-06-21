// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// The DevTest Labs Client.
    /// </summary>
    public partial class DevTestLabsClient : ServiceClient<DevTestLabsClient>, IDevTestLabsClient, IAzureClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Client API version.
        /// </summary>
        public string ApiVersion { get; private set; }

        /// <summary>
        /// The subscription ID.
        /// </summary>
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default value is
        /// 30.
        /// </summary>
        public int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When set to
        /// true a unique x-ms-client-request-id value is generated and included in
        /// each request. Default is true.
        /// </summary>
        public bool? GenerateClientRequestId { get; set; }

        /// <summary>
        /// Gets the IProviderOperations.
        /// </summary>
        public virtual IProviderOperations ProviderOperations { get; private set; }

        /// <summary>
        /// Gets the ILabsOperations.
        /// </summary>
        public virtual ILabsOperations Labs { get; private set; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        public virtual IOperations Operations { get; private set; }

        /// <summary>
        /// Gets the IGlobalSchedulesOperations.
        /// </summary>
        public virtual IGlobalSchedulesOperations GlobalSchedules { get; private set; }

        /// <summary>
        /// Gets the IArtifactSourcesOperations.
        /// </summary>
        public virtual IArtifactSourcesOperations ArtifactSources { get; private set; }

        /// <summary>
        /// Gets the IArmTemplatesOperations.
        /// </summary>
        public virtual IArmTemplatesOperations ArmTemplates { get; private set; }

        /// <summary>
        /// Gets the IArtifactsOperations.
        /// </summary>
        public virtual IArtifactsOperations Artifacts { get; private set; }

        /// <summary>
        /// Gets the ICostsOperations.
        /// </summary>
        public virtual ICostsOperations Costs { get; private set; }

        /// <summary>
        /// Gets the ICustomImagesOperations.
        /// </summary>
        public virtual ICustomImagesOperations CustomImages { get; private set; }

        /// <summary>
        /// Gets the IFormulasOperations.
        /// </summary>
        public virtual IFormulasOperations Formulas { get; private set; }

        /// <summary>
        /// Gets the IGalleryImagesOperations.
        /// </summary>
        public virtual IGalleryImagesOperations GalleryImages { get; private set; }

        /// <summary>
        /// Gets the INotificationChannelsOperations.
        /// </summary>
        public virtual INotificationChannelsOperations NotificationChannels { get; private set; }

        /// <summary>
        /// Gets the IPolicySetsOperations.
        /// </summary>
        public virtual IPolicySetsOperations PolicySets { get; private set; }

        /// <summary>
        /// Gets the IPoliciesOperations.
        /// </summary>
        public virtual IPoliciesOperations Policies { get; private set; }

        /// <summary>
        /// Gets the ISchedulesOperations.
        /// </summary>
        public virtual ISchedulesOperations Schedules { get; private set; }

        /// <summary>
        /// Gets the IServiceRunnersOperations.
        /// </summary>
        public virtual IServiceRunnersOperations ServiceRunners { get; private set; }

        /// <summary>
        /// Gets the IUsersOperations.
        /// </summary>
        public virtual IUsersOperations Users { get; private set; }

        /// <summary>
        /// Gets the IDisksOperations.
        /// </summary>
        public virtual IDisksOperations Disks { get; private set; }

        /// <summary>
        /// Gets the IEnvironmentsOperations.
        /// </summary>
        public virtual IEnvironmentsOperations Environments { get; private set; }

        /// <summary>
        /// Gets the ISecretsOperations.
        /// </summary>
        public virtual ISecretsOperations Secrets { get; private set; }

        /// <summary>
        /// Gets the IServiceFabricsOperations.
        /// </summary>
        public virtual IServiceFabricsOperations ServiceFabrics { get; private set; }

        /// <summary>
        /// Gets the IServiceFabricSchedulesOperations.
        /// </summary>
        public virtual IServiceFabricSchedulesOperations ServiceFabricSchedules { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachinesOperations.
        /// </summary>
        public virtual IVirtualMachinesOperations VirtualMachines { get; private set; }

        /// <summary>
        /// Gets the IVirtualMachineSchedulesOperations.
        /// </summary>
        public virtual IVirtualMachineSchedulesOperations VirtualMachineSchedules { get; private set; }

        /// <summary>
        /// Gets the IVirtualNetworksOperations.
        /// </summary>
        public virtual IVirtualNetworksOperations VirtualNetworks { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DevTestLabsClient.Dispose(). False: will not dispose provided httpClient</param>
        protected DevTestLabsClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DevTestLabsClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DevTestLabsClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DevTestLabsClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DevTestLabsClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DevTestLabsClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DevTestLabsClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DevTestLabsClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DevTestLabsClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DevTestLabsClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DevTestLabsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Credentials needed for the client to connect to Azure.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DevTestLabsClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        /// </summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            ProviderOperations = new ProviderOperations(this);
            Labs = new LabsOperations(this);
            Operations = new Operations(this);
            GlobalSchedules = new GlobalSchedulesOperations(this);
            ArtifactSources = new ArtifactSourcesOperations(this);
            ArmTemplates = new ArmTemplatesOperations(this);
            Artifacts = new ArtifactsOperations(this);
            Costs = new CostsOperations(this);
            CustomImages = new CustomImagesOperations(this);
            Formulas = new FormulasOperations(this);
            GalleryImages = new GalleryImagesOperations(this);
            NotificationChannels = new NotificationChannelsOperations(this);
            PolicySets = new PolicySetsOperations(this);
            Policies = new PoliciesOperations(this);
            Schedules = new SchedulesOperations(this);
            ServiceRunners = new ServiceRunnersOperations(this);
            Users = new UsersOperations(this);
            Disks = new DisksOperations(this);
            Environments = new EnvironmentsOperations(this);
            Secrets = new SecretsOperations(this);
            ServiceFabrics = new ServiceFabricsOperations(this);
            ServiceFabricSchedules = new ServiceFabricSchedulesOperations(this);
            VirtualMachines = new VirtualMachinesOperations(this);
            VirtualMachineSchedules = new VirtualMachineSchedulesOperations(this);
            VirtualNetworks = new VirtualNetworksOperations(this);
            BaseUri = new System.Uri("https://management.azure.com");
            ApiVersion = "2018-09-15";
            AcceptLanguage = "en-US";
            LongRunningOperationRetryTimeout = 30;
            GenerateClientRequestId = true;
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            SerializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
            DeserializationSettings.Converters.Add(new TransformationJsonConverter());
            DeserializationSettings.Converters.Add(new CloudErrorJsonConverter());
        }
    }
}