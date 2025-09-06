using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using EconomyNet.Entity;
using Newtonsoft.Json;

namespace EconomyNet.Repository
{
    public class UserRepository : IRepository
    {
        private List<User> _users;
        private readonly string _fileName;

        public UserRepository()
        {
            var directory = Path.Combine(Environment.CurrentDirectory, DateTime.Now.ToString("yyyy"));

            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            _fileName = Path.Combine(directory, $"{nameof(UserRepository)}.json");

            _users = new List<User>();
            Read();
        }

        public void Read()
        {
            try
            {
                using (var r = new StreamReader(_fileName))
                {
                    var json = r.ReadToEnd();
                    _users = JsonConvert.DeserializeObject<List<User>>(json);
                }
            }
            catch
            {
                //Ignore
            }
        }

        public void Write()
        {
            try
            {
                using (var file = File.CreateText(_fileName))
                {
                    var serializer = new JsonSerializer();
                    serializer.Serialize(file, _users);
                }
            }
            catch
            {
                //Ignore
            }
        }

        public void Save(User user)
        {
            var u = _users.FirstOrDefault(r => string.Equals(r.UserName, user.UserName, StringComparison.CurrentCultureIgnoreCase));

            if (u == null)
                _users.Add(user);
            else
                u.Password = user.Password;

            Write();
        }

        public void Delete(User user)
        {
            var u = _users.FirstOrDefault(r => string.Equals(r.UserName, user.UserName, StringComparison.CurrentCultureIgnoreCase));

            if (u == null)
                throw new Exception("Registo não encontrado...");

            _users.Remove(u);

            Write();
        }

        public User Find(string userName, string password)
        {
            Read();

            return _users.FirstOrDefault(u => string.Equals(u.UserName, userName, StringComparison.CurrentCultureIgnoreCase) && u.Password == password);
        }

        public List<User> All()
        {
            Read();

            return _users;
        }
    }
}
