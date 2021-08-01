using System;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Services.Sessions;
using Newtonsoft.Json;

namespace InvoiceIssuer.Web.Sessions
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
                return null;
            }
        }

        public void Exit()
        {
            _session.RemoveAll();
        }
    }
}