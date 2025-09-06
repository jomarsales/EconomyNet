using System;

namespace EconomyNet.Service
{
    internal class AutenticateManager
    {
        internal static bool Login(string userName, string password)
        {
            var rep = new Repository.UserRepository();

            rep.Read();

            var user = rep.Find(userName, password);

            if(user == null)
                throw new Exception("Usuário não localizado...");

            return true;
        }
    }
}