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
        private string calle;
        private string delegacion;
        private string cp;

        private bool polen;
        private bool acaros;
        private bool latex;
        private bool medicamento;
        private string nombreMedicamento;
        private bool alimento;
        private string nombreAlimento;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public byte DiaNacimiento { get => diaNacimiento; set => diaNacimiento = (value < 1 || value > 31) ? (byte)1 : value; }
        public byte MesNacimiento { get => mesNacimiento; set => mesNacimiento = (value < 1 || value > 12) ? (byte)1 : value; }
        public int AñoNacimiento { get => añoNacimiento; set => añoNacimiento = (value < 1900 || value > 2023) ? 2000 : value; }
        public byte Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public float Peso { get => peso; set => peso = (value < 1 ? peso = 70 : peso = value); }
        public float Altura { get => altura; set => altura = (value < 1) ? 1.7f : value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public float FrecuenciaRespiratoria { get => frecuenciaRespiratoria; set => frecuenciaRespiratoria = value; }
        public float FrecuenciaCardiaca { get => frecuenciaCardiaca; set => frecuenciaCardiaca = value; }
        public string PresionArterial { get => presionArterial; set => presionArterial = value; }
        public string Calle { get => calle; set => calle = value; }
        public string Delegacion { get => delegacion; set => delegacion = value; }
        public string Cp { get => cp; set => cp = value; }
        public bool Polen { get => polen; set => polen = value; }
        public bool Acaros { get => acaros; set => acaros = value; }
        public bool Latex { get => latex; set => latex = value; }
        public bool Medicamento { get => medicamento; set => medicamento = value; }
        public string NombreMedicamento { get => nombreMedicamento; set => nombreMedicamento = (!Medicamento) ? "NA" : value; }
        public bool Alimento { get => alimento; set => alimento = value; }
        public string NombreAlimento { get => nombreAlimento; set => nombreAlimento = (!Alimento) ? "NA" : value; }

        #endregion

        #region Constructores
        public Paciente()
        {
            Nombre = "";
            Peso = 0;
            Altura = 0;
            Temperatura = 0;
            FrecuenciaRespiratoria = 0;
            FrecuenciaCardiaca = 0;
            PresionArterial = "";
            DiaNacimiento = 0;
            MesNacimiento = 0;
            AñoNacimiento = 0;
            Edad = 0;
            Sexo = "";
            Telefono = "";

        }
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
