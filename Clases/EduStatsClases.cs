using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduStatsProyecto.Clases
{
    internal class PersonalBibliotecario
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public PersonalBibliotecario(string usuario, string clave)
        {
            Usuario = usuario;
            Clave = clave;
        }
        public static List<PersonalBibliotecario> personal = new List<PersonalBibliotecario>() { };

        public static void GuardarDatos(string rutaArchivo)
        {
            using (var writer = new BinaryWriter(File.Open(rutaArchivo, FileMode.Create)))
            {
                writer.Write(personal.Count);
                foreach (var usuario in personal)
                {
                    writer.Write(usuario.Usuario);
                    writer.Write(usuario.Clave);
                }
            }
        }
        public static void CargarDatos(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
                return;

            using (var reader = new BinaryReader(File.Open(rutaArchivo, FileMode.Open)))
            {
                int cantidad = reader.ReadInt32();
                personal.Clear();

                for (int i = 0; i < cantidad; i++)
                {
                    string usuario = reader.ReadString();
                    string clave = reader.ReadString();
                    personal.Add(new PersonalBibliotecario(usuario, clave));
                }
            }
        }
    }
    public static class Constantes
    {
        public const string usuarioMaestro = "garciaenrique";
        public const string claveMaestra = "250294";

        public static int[] Generos = new int[10];
        public static int[] Horas = new int[13];
        public static int[] Meses = new int[12];
        public static int[] Carreras = new int[17];
        public static void GuardarEstadisticas(string rutaArchivo)
        {
            using (var writer = new BinaryWriter(File.Open(rutaArchivo, FileMode.Create)))
            {
                foreach (var valor in Generos) writer.Write(valor);
                foreach (var valor in Horas) writer.Write(valor);
                foreach (var valor in Meses) writer.Write(valor);
                foreach (var valor in Carreras) writer.Write(valor);
            }
        }
        public static void CargarEstadisticas(string rutaArchivo)
        {
            if (!File.Exists(rutaArchivo))
                return;

            using (var reader = new BinaryReader(File.Open(rutaArchivo, FileMode.Open)))
            {
                for (int i = 0; i < Generos.Length; i++) Generos[i] = reader.ReadInt32();
                for (int i = 0; i < Horas.Length; i++) Horas[i] = reader.ReadInt32();
                for (int i = 0; i < Meses.Length; i++) Meses[i] = reader.ReadInt32();
                for (int i = 0; i < Carreras.Length; i++) Carreras[i] = reader.ReadInt32();
            }
        }
    }
}