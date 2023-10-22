using System;


namespace BiblioExpedientes
{
    public class Paciente : Usuario
    {
        #region atributos
        private string nombre;

        private float peso;
        private float altura;
        private float temperatura;
        private float frecuenciaRespiratoria;
        private float frecuenciaCardiaca;
        private string presionArterial;

        private byte diaNacimiento;
        private byte mesNacimiento;
        private int añoNacimiento;
        private byte edad;

        private string sexo;
        private string telefono;
        
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public byte DiaNacimiento { get => diaNacimiento; set => diaNacimiento = (value < 1 || value > 31 ? diaNacimiento = 1 : diaNacimiento = value); }
        public byte MesNacimiento { get => mesNacimiento; set => mesNacimiento = (value < 1 || value > 12 ? mesNacimiento = 1 : mesNacimiento = value); }
        public int AñoNacimiento { get => añoNacimiento; set => añoNacimiento = (value < 1900 || value > 2023 ? añoNacimiento = 2000 : añoNacimiento = value); }
        public byte Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public float Peso { get => peso; set => peso = (value < 0 ? peso = 70 : peso = value); }
        public float Altura { get => altura; set => altura = (value < 0 ? altura = (float)1.7 : altura = value); }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float FrecuenciaRespiratoria { get => frecuenciaRespiratoria; set => frecuenciaRespiratoria = value; }
        public float FrecuenciaCardiaca { get => frecuenciaCardiaca; set => frecuenciaCardiaca = value; }
        public string PresionArterial { get => presionArterial; set => presionArterial = value; }
        #endregion

        #region Constructores
        
        public Paciente(string user, string password, string email)
        {
            User = user;
            Password = password;
            Email = email;
        }

        public Paciente(string nombre, float peso, float altura, float temperatura, float frecuenciaRespiratoria, float frecuenciaCardiaca, string presionArterial)
        {
            Nombre = nombre;
            Peso = peso;
            Altura = altura;
            Temperatura = temperatura;
            FrecuenciaRespiratoria = frecuenciaRespiratoria;
            FrecuenciaCardiaca = frecuenciaCardiaca;
            PresionArterial = presionArterial;
        }
        #endregion

        public string concatenarFecha()
        {
            return DiaNacimiento.ToString() + "/" + MesNacimiento.ToString() + "/" + AñoNacimiento.ToString();
        }
        public float calculoIMC()
        {
            return (float)Math.Round(Peso / (float)(Math.Pow(Altura, 2)) * 100)/100;
        }
    }
}
