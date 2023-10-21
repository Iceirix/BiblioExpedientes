using System;


namespace BiblioExpedientes
{
    public class Paciente : Usuario
    {
        #region atributos
        private string Nombre;
        #endregion
        public Paciente(string user, string password, string email)
        {
            User = user;
            Password = password;
            Email = email;
        }
    }
}
