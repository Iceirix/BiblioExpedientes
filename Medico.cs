using System;


namespace BiblioExpedientes
{
    public class Medico : Usuario
    {
        #region atributos
        private string Nombre;
        #endregion

        public Medico(string user, string password)
        {
            User = user;
            Password = password;
        }
    }
}
