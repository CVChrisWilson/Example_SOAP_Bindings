            SecurityBindingElement SecurityElement = SecurityBindingElement.CreateUserNameOverTransportBindingElement();
            SecurityElement.IncludeTimestamp = false;
            TextMessageEncodingBindingElement EncodingElement = new TextMessageEncodingBindingElement(MessageVersion.Soap11, Encoding.UTF8);
            HttpsTransportBindingElement TransportElement = new HttpsTransportBindingElement();
            TransportElement.MaxBufferSize = 20000000;
            TransportElement.MaxReceivedMessageSize = 20000000;
            TransportElement.MaxBufferPoolSize = 200000000;

            CustomBinding CustomBinding = new CustomBinding(SecurityElement, EncodingElement, TransportElement);
            CustomBinding.ReceiveTimeout = TimeSpan.FromMinutes(1);
            EndpointAddress EndPoint = new EndpointAddress("http://endpoint.com/service_name?wsdl");

            GetExperienceSummaryPortTypeClient _getExperienceSummaryPortTypeClient = new GetExperienceSummaryPortTypeClient(CustomBinding, EndPoint);
            _getExperienceSummaryPortTypeClient.ClientCredentials.UserName.UserName = "username";
            _getExperienceSummaryPortTypeClient.ClientCredentials.UserName.Password = "password";
            getExperienceSummaryPortTypeClient = _getExperienceSummaryPortTypeClient;
