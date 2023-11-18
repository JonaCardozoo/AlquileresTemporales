using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using WindowsFormsApp2.Clases;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    [Serializable]
    internal class Empresa
    {
        List<Reserva> listaReservas=new List<Reserva>();

        List<Casa> listaCasas=new List<Casa>();
        List<Hotel> listaHoteles = new List<Hotel>();


        List<CasaFinde> listaCasaFinde = new List<CasaFinde>();



        List<Cliente> listaClientes= new List<Cliente>();

        Administrador admin;

        public Administrador Admin { get { return admin; } }


        public List<Cliente> ListaClientes { get { return listaClientes; } }
        public List<Reserva> ListaReservas { get { return listaReservas; } }



        public List<Casa> ListaCasas { get { return listaCasas; } }

        public List<CasaFinde> ListaCasaFin { get { return listaCasaFinde; } }


        public List<Hotel> ListaHoteles { get { return listaHoteles; } }

        public void Administrador(string nombre, long dni, string contraseña)
        {
            admin = new Administrador(nombre, contraseña, dni);
        }

        public Cliente AgregarCliente(string nombre, string apellido, int dni, double telefono)
        {

            Cliente cli = null;
                if (dni >10000000 && dni<99999999)
                {
                    cli = new Cliente(nombre, apellido, dni, telefono);
                    listaClientes.Add(cli);
                }
                else
                {
                    throw new DniExcepction("El Dni no cumple los requisitos (8 digitos)");
                }
            return cli;
            
        }
        public void ModificarCasa(int indice, bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase)
        {
            listaCasas[indice].Cochera = cochera;
            listaCasas[indice].Pileta = pileta;
            listaCasas[indice].Wifi = wifi;
            listaCasas[indice].Limpieza = limpieza;
            listaCasas[indice].Desayuno = desayuno;
            listaCasas[indice].Mascotas = mascotas;
            listaCasas[indice].Direccion = direccion;
            listaCasas[indice].Nropropiedad = nro;
            listaCasas[indice].MinimoDias = minimodias;
            listaCasas[indice].PrecioBase = preciobase;
            listaCasas[indice].CantidadCamas = cantcamas;
        }


        public void ModificarHotel(int indice, bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase)
        {
            listaCasas[indice].Cochera = cochera;
            listaCasas[indice].Pileta = pileta;
            listaCasas[indice].Wifi = wifi;
            listaCasas[indice].Limpieza = limpieza;
            listaCasas[indice].Desayuno = desayuno;
            listaCasas[indice].Mascotas = mascotas;
            listaCasas[indice].Direccion = direccion;
            listaCasas[indice].Nropropiedad = nro;
            listaCasas[indice].MinimoDias = minimodias;
            listaCasas[indice].PrecioBase = preciobase;
            listaCasas[indice].CantidadCamas = cantcamas;
        }



        public void EliminarCasa(int indice)
        {
            listaCasas.RemoveAt(indice);
            listaCasas.TrimExcess();
        }
        public void EliminarHotel(int indice)
        {
            listaHoteles.RemoveAt(indice);
            listaHoteles.TrimExcess();
        }

        public void EliminarCasaFinde(int indice)
        {
            listaCasaFinde.RemoveAt(indice);
            listaCasaFinde.TrimExcess();
        }

        public void AgregarCasa(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase,calendario calen, int cantImagenes, string[] directorioImagenes,string lugar)
        {
            Casa cas = new Casa(cochera, pileta, wifi, limpieza, desayuno, mascotas, direccion, nro, minimodias, cantcamas, preciobase,calen,cantImagenes,directorioImagenes,lugar);
            listaCasas.Add(cas);
        }

        public void AgregarCasaFinde(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase, calendario calen, int cantImagenes, string[] directorioImagenes, string lugar)
        {
            CasaFinde casafinde = new CasaFinde(cochera, pileta, wifi, limpieza, desayuno, mascotas, direccion, nro, minimodias, cantcamas, preciobase, calen, cantImagenes, directorioImagenes, lugar);
            listaCasaFinde.Add(casafinde);
        }

        public void CancelarReserva(Reserva res)
        {
            foreach (Reserva ras in listaReservas)
            {
                if (ras.Equals(res))
                {
                    if (ras.Casa != null)
                    {
                        res.Casa.ReservasCasa.Remove(ras);
                    }
                    else res.Hotel.ReservaHotel.Remove(ras);
                    listaReservas.Remove(ras);
                    listaReservas.TrimExcess();
                    break;
                }
            }
        }

        public bool AgregarReservaCasaFinde(Cliente cliente, DateTime ingreso, DateTime reserva, int dias, int cant,CasaFinde casafinde)
        {
            Reserva res = new Reserva(cliente, ingreso,reserva, dias, cant,casafinde);
            listaReservas.Add(res);
            casafinde.AgregarReservaCasaFinde(res);
            cliente.ReservasCliente.Add(res);
            return true;
        }

        public void AgregarReservaHabitacion(Hotel hotel, DateTime posesion, DateTime FechadeReservacion, int cant, Cliente cliente, int numHab, int dias)
        {
            Reserva res = new Reserva(cliente, posesion, FechadeReservacion,dias,cant,hotel.ListaDeHabitacion[numHab],hotel);
            hotel.AgregarReservaHotel(res);
            listaReservas.Add(res);
            cliente.ReservasCliente.Add(res);
        }

        public bool AgregarReservaCasa(Casa casa, Cliente cliente,DateTime FechadeReservacion,int cant, DateTime posesion, int dias)
        {
                Reserva res = new Reserva(cliente, posesion,FechadeReservacion,dias,cant, casa);
                listaReservas.Add(res); 
                casa.AgregarReservaCasa(res);
                cliente.ReservasCliente.Add(res);
                return true;
        }

        





        public void AgregarHotel(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas,string nombre, Hotel.HotelEstrella tipo, double valorBase, int cantImagenes, string[] directorioImagenes,string lugar, string direccion, int nro)
        {
            Hotel hot = new Hotel(cochera, pileta, wifi, limpieza,  desayuno,  mascotas,nombre, tipo, valorBase, cantImagenes, directorioImagenes,lugar, direccion, nro);
            listaHoteles.Add(hot);

        }


        //public CasaFinde[] FiltrarLugarCasaFinde(string lugar)
        //{
        //    int aux = 0;
        //    List<CasaFinde> lista = new List<CasaFinde>();
        //    while (aux < listaCasaFinde.Count)
        //    {
        //        if (lugar == ListaCasas[aux].Lugar)
        //        {
        //            CasaFinde casaFinde = listaCasaFinde[aux];
        //            lista.Add(casaFinde);
        //        }
        //        aux++;
        //    }
        //    return lista.ToArray();
        //}


        public Casa[] FiltroLugarCasas(string lugar)
        {
            int aux = 0;
            List<Casa>lista=new List<Casa>();
            while (aux < ListaCasas.Count)
            {
                if (lugar == ListaCasas[aux].Lugar)
                {
                    Casa cas = ListaCasas[aux];
                    lista.Add(cas);
                }
                aux++;
            }
            return lista.ToArray();
        }

        public Hotel[] FiltroLugarHoteles(string lugar)
        {
            int aux = 0;
            List<Hotel> lista = new List<Hotel>();  
            int i = 0;            
            while(aux<ListaHoteles.Count)
            {   
                if(lugar == ListaHoteles[aux].Lugar)
                {
                    Hotel hot = ListaHoteles[aux];
                    lista.Add(hot);              
                }
                aux++;
            }
            return lista.ToArray();
        }

        public Casa[] FiltroCantPasajerosCasa(int cantPers)
        {
            int aux = 0;
            List<Casa> lista = new List<Casa>();
            while (aux<ListaCasas.Count)
            {
                if (cantPers == listaCasas[aux].CantidadCamas)
                {
                    lista.Add(listaCasas[aux]);
                }
                else if(listaCasas[aux].CantidadCamas>cantPers)
                {
                    lista.Add(listaCasas[aux]);
                }
                aux++;
            }
            return lista.ToArray();
        }
        
    }
}

        