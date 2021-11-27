using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Services.Sessions;
using Newtonsoft.Json;
using System;

namespace InvoiceIssuer.Services.Sessions
{
    public class LoginStorage
    {
        private readonly SessionStorage _session;
        private string _key = "Login.Provider";

        public LoginStorage(SessionStorage session) => _session = session;

        public void SignIn(Provider provider)
        {
            string providerJson = JsonConvert.SerializeObject(provider);
            _session.Create(_key, providerJson);
        }

        public Provider GetProvider()
        {
            try
            {
                string providerJson = _session.Read(_key);
                return JsonConvert.DeserializeObject<Provider>(providerJson);
            }
            catch (ArgumentNullException)
            {
                // throw new NullSessionException("Your session has ended!");
                return null;
            }
        }

        public Guid ProviderId
        {
            get { return this.GetProvider().Id; }
        }

        public void Exit()
        {
            _session.RemoveAll();
        }
    }
}