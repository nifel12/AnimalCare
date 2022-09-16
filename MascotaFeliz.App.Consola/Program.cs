using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using System.Collections.Generic;

namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioDueno _repoDueno = new RepositorioDueno(new Persistencia.AppContext());

        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*add*/
            //AddDueno();
            //AddVeterinario();
            //AddMascota();

            /*Buscar*/
            //BuscarMascota(1);
            //BuscarDueno(1);
            //BuscarVeterinario(3);

            /*Listar*/
            //ListarMascotas();
            //ListarDuenos();
            //ListarVeterinarios();
        }

        private static void AddDueno()
        {
            var dueno = new Dueno
            {
                //Cedula = "1212",
                Nombres = "Carlos",
                Apellidos = "Aponte",
                Direccion = "En el techo",
                Telefono = "123000",
                Correo = "caa-pon@gmail.com"
            };
            _repoDueno.AddDueno(dueno);
        }


        

        private static void AddVeterinario()
        {
            var veterinario = new Veterinario
            {
                //Cedula = "1212",
                Nombres = "Santiago",
                Apellidos = "Valderrama",
                Direccion = "CASA 3",
                Telefono = "78945655",
                TarjetaProfesional = "51613854"
            };
            _repoVeterinario.AddVeterinario(veterinario);
        }

        

        private static void AddMascota() 
        {
            var mascota = new Mascota
            {
                Nombre = "TT",
                Color = "Blanco",
                Especie = "Cánido",
                Raza = "Poodle"

            };
            _repoMascota.AddMascota(mascota);
        } 

        private static void BuscarMascota(int idMascota)
        {
            var mascota = _repoMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre + " " + mascota.Color + " " + mascota.Especie + " " + mascota.Raza);
        }

        private static void BuscarDueno(int idDueno)
        {
            var dueno = _repoDueno.GetDueno(idDueno);
            Console.WriteLine(dueno.Nombres + " " + dueno.Apellidos + " " + dueno.Direccion + " " + dueno.Telefono + " " + dueno.Correo);
        }

        private static void BuscarVeterinario(int idVeterinario)
        {
            var veterinario = _repoVeterinario.GetVeterinario(idVeterinario);
            Console.WriteLine(veterinario.Nombres + " " + veterinario.Apellidos + " " + veterinario.Direccion + " " + veterinario.Telefono + " " + veterinario.TarjetaProfesional);
        }

        private static void ListarMascotas()
        {
            var mascotas = _repoMascota.GetAllMascotas();
            foreach (Mascota d in mascotas)
            {
                Console.WriteLine(d.Nombre + " " + d.Color);
            }
        }

        private static void ListarDuenos()
        {
            var duenos = _repoDueno.GetAllDuenos();
            foreach (Dueno d in duenos)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        private static void ListarVeterinarios()
        {
            var veterinarios = _repoVeterinario.GetAllVeterinarios();
            foreach (Veterinario d in veterinarios)
            {
                Console.WriteLine(d.Nombres + " " + d.Apellidos);
            }
        }

        
        
    }
}
