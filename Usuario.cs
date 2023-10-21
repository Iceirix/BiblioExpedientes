﻿using System;

namespace BiblioExpedientes
{
    public abstract class Usuario
    {
        #region Atributos
        private string user;
        private string password;
        private string email;
        #endregion

        #region Propiedades
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        #endregion

    }
}
