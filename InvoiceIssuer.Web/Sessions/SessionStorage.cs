using Microsoft.AspNetCore.Http;

namespace InvoiceIssuer.Services.Sessions
{
    public class SessionStorage
    {
        private readonly IHttpContextAccessor _context;
        public SessionStorage(IHttpContextAccessor context) => _context = context;

        public void Create(string key, string value) => _context.HttpContext.Session.SetString(key, value);
        public void Update(string key, string value)
        {
            if (this.Exists(key))
                _context.HttpContext.Session.Remove(key);

            _context.HttpContext.Session.SetString(key, value);
        }

        public void Remove(string key) => _context.HttpContext.Session.Remove(key);
        public string Read(string key) => _context.HttpContext.Session.GetString(key);
        public bool Exists(string key) => (this.Read(key) != null) ? true : false;
        public void RemoveAll() => _context.HttpContext.Session.Clear();
    }
}