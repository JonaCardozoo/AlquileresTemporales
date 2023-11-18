using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;
using System.Messaging;
using static System.Windows.Forms.LinkLabel;
using WindowsFormsApp2.Formularios;
using System.ComponentModel.Design;
using System.Globalization;
using WindowsFormsApp2.Clases;
using GeneradorQR_LIB;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form, iImportExport
    {
        static Random rd = new Random();
        private int filas = 7;
        private int columnas = 7;
        private int[,] dias;
        Empresa empresa = new Empresa();
        Cliente cliente;
        string startup = "";
        int controladorImagenes = 0;
        string[] huesped;
        int PaginaActual = 0;


        void RealizarReserva()
        {
            if (cliente != null)
            {
                CargarDatosReserva cd = new CargarDatosReserva();
                Freserva vReserva = new Freserva();
                int dia, final;
                bool correcto = true;
                int inicial = 0;
                int[,] aux = new int[40, 2];
                int indice = cbLista.SelectedIndex;

                if (btnVerCasas.Enabled == false)
                {

                    if (vReserva.ShowDialog() == DialogResult.OK)
                    {
                        if (vReserva.dTPReserva.Value.Month == 11)
                        {
                            dias = empresa.ListaCasas[indice].Calendario.DiaaMes1;
                        }
                        else if (vReserva.dTPReserva.Value.Month == 12) { dias = empresa.ListaCasas[indice].Calendario.DiaaMes2; } else { dias = empresa.ListaCasas[indice].Calendario.DiaaMes3; }
                        Array.Copy(dias, aux, 80);

                        if (Convert.ToInt16(vReserva.tDias.Text) >= empresa.ListaCasas[indice].MinimoDias)
                        {
                            dia = vReserva.dTPReserva.Value.Day;


                            final = Convert.ToInt32(vReserva.tDias.Text);



                            while (dias[inicial, 0] != dia)
                                inicial++;

                            for (int d = inicial; d < final + inicial; d++)
                            {
                                if (aux[d, 1] == 0) aux[d, 1] = 1;
                                else correcto = false;
                            }
                            if (correcto)
                            {
                                Array.Copy(aux, dias, 80);
                                if (vReserva.dTPReserva.Value.Month == 11)
                                {
                                    empresa.ListaCasas[indice].Calendario.DiaaMes1 = dias;
                                }
                                else if (vReserva.dTPReserva.Value.Month == 12) { empresa.ListaCasas[indice].Calendario.DiaaMes2 = dias; } else { empresa.ListaCasas[indice].Calendario.DiaaMes3 = dias; }
                                MessageBox.Show("Se reservo con exito!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                mostrar();
                                Array.Clear(aux, 0, 80);
                                int cant = Convert.ToInt16(vReserva.textBox1.Text);
                                int i = 0;
                                empresa.AgregarReservaCasa(empresa.ListaCasas[indice], cliente, DateTime.Now, cant, vReserva.dTPReserva.Value, final);
                                huesped = new string[cant];
                                cd.label3.Text = i.ToString() + 1;
                                while (cd.ShowDialog() == DialogResult.OK && i != cant)
                                {
                                    huesped[i] = cd.textBox1.Text + " " + cd.textBox2.Text + " " + cd.dateTimePicker1.Value.ToShortDateString();
                                    i++;
                                    cd.label3.Text = i.ToString() + 1;
                                    if (i == cant)
                                    {
                                        break;
                                    }
                                }
                            }
                            else MessageBox.Show("Fecha no disponible!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Debe reservar por mas de " + empresa.ListaCasas[indice].MinimoDias + " dias para reservar este alojamiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }
                else
                {
                    int indice2 = empresa.ListaHoteles[indice].ListaDeHabitacion[cbNroHabitacion.SelectedIndex].NumeroHabitacion;

                    if (indice != -1)
                    {
                        if (indice2 != -1)
                        {
                            if (vReserva.ShowDialog() == DialogResult.OK)
                            {
                                if (vReserva.dTPReserva.Value.Month == 11)
                                {
                                    dias = empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes1;
                                }
                                else if (vReserva.dTPReserva.Value.Month == 12) { dias = empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes2; } else { dias = empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes3; }
                                dia = vReserva.dTPReserva.Value.Day;
                                final = Convert.ToInt32(vReserva.tDias.Text);
                                int numbHab = Convert.ToInt32(cbNroHabitacion.SelectedIndex);
                                Array.Copy(dias, aux, 80);
                                while (dias[inicial, 0] != dia)
                                    inicial++;
                                for (int d = inicial; d < final + inicial; d++)
                                {
                                    if (aux[d, 1] == 0) aux[d, 1] = 1;
                                    else correcto = false;
                                }
                                if (correcto)
                                {
                                    Array.Copy(aux, dias, 80);
                                    if (vReserva.dTPReserva.Value.Month == 11)
                                    {
                                        empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes1 = dias;
                                    }
                                    else if (vReserva.dTPReserva.Value.Month == 12) { empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes2 = dias; } else { empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes3 = dias; }
                                    MessageBox.Show("Se reservo con exito!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    mostrar();
                                    Array.Clear(aux, 0, 80);
                                    int cant = Convert.ToInt16(vReserva.textBox1.Text);
                                    int i = 0;
                                    empresa.AgregarReservaHabitacion(empresa.ListaHoteles[indice], vReserva.dTPReserva.Value, DateTime.Now, cant, cliente, numbHab, final);
                                    huesped = new string[cant];
                                    cd.label3.Text = i.ToString() + 1;
                                    while (cd.ShowDialog() == DialogResult.OK && i != cant)
                                    {
                                        huesped[i] = cd.textBox1.Text + " " + cd.textBox2.Text + " " + cd.dateTimePicker1.Value.ToShortDateString();
                                        i++;
                                        cd.label3.Text = i.ToString() + 1;
                                        if (i == cant)
                                        {
                                            break;
                                        }
                                    }
                                }
                                else MessageBox.Show("Fecha no disponible!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else MessageBox.Show("Debes ingresar una habitacion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            else MessageBox.Show("Debes ingresar un cliente antes de reservar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }


        void CancelarReserva()
        {

            FCancelar fCancelar = new FCancelar();

            if (cliente != null)
            {
                if (cliente.ReservasCliente.Count != 0)
                {
                    if (cliente.ReservasCliente.Count > 1)
                    {
                        fCancelar.comboBox1.Items.Clear();
                        for (int i = 0; i < cliente.ReservasCliente.Count; i++)
                        {
                            if (cliente.ReservasCliente[i].Casa != null)
                            {
                                fCancelar.comboBox1.Items.Add(cliente.ReservasCliente[i].Casa.Direccion + " " + cliente.ReservasCliente[i].Casa.Nropropiedad);
                            }
                            else { fCancelar.comboBox1.Items.Add(cliente.ReservasCliente[i].Hotel.Nombre + " " + "Habitacion " + cliente.ReservasCliente[i].Habitacion.NumeroHabitacion); }
                        }
                        if (fCancelar.ShowDialog() == DialogResult.OK)
                        {
                            Reserva res = cliente.ReservasCliente[fCancelar.comboBox1.SelectedIndex];
                            int inicial = 0;
                            int dia = res.Ingreso.Day;
                            int final = res.Salida.Day;
                            int suma = dia + final;
                            if (suma > 39)
                            {
                                suma = 39;
                            }
                            if (res.Casa != null)
                            {
                                if (res.Ingreso.Month == 11)
                                {
                                    dias = res.Casa.Calendario.DiaaMes1;
                                }
                                else if (res.Ingreso.Month == 12)
                                {
                                    dias = res.Casa.Calendario.DiaaMes2;
                                }
                                else dias = res.Casa.Calendario.DiaaMes3;

                            }
                            else if (res.Ingreso.Month == 11)
                            {
                                dias = res.Habitacion.Calendario.DiaaMes1;
                            }
                            else if (res.Ingreso.Month == 12)
                            {
                                dias = res.Habitacion.Calendario.DiaaMes2;
                            }
                            else dias = res.Habitacion.Calendario.DiaaMes3;
                            while (dias[inicial, 0] != dia)
                                inicial++;
                            for (int d = inicial; d < suma; d++)
                            {
                                if (dias[d, 1] == 1) dias[d, 1] = 0;
                            }
                            cliente.ReservasCliente.RemoveAt(fCancelar.comboBox1.SelectedIndex);
                            empresa.CancelarReserva(res);
                            mostrar();
                        }

                    }
                    else
                    {
                        if (cliente.ReservasCliente[0].Casa != null)
                        {
                            if (MessageBox.Show("Casa" + "\nDireccion: " + cliente.ReservasCliente[0].Casa.Direccion + " " + cliente.ReservasCliente[0].Casa.Nropropiedad, "Cancelar Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                Reserva res;
                                if (fCancelar.comboBox1.SelectedIndex == -1)
                                {
                                    res = cliente.ReservasCliente[fCancelar.comboBox1.SelectedIndex + 1];
                                }
                                else { res = cliente.ReservasCliente[fCancelar.comboBox1.SelectedIndex]; }

                                int inicial = 0;
                                int dia = res.Ingreso.Day;
                                int final = res.Salida.Day;
                                int suma = dia + final;
                                if (suma > 39)
                                {
                                    suma = 39;
                                }
                                if (res.Ingreso.Month == 11)
                                {
                                    dias = res.Casa.Calendario.DiaaMes1;
                                }
                                else if (res.Ingreso.Month == 12)
                                {
                                    dias = res.Casa.Calendario.DiaaMes2;
                                }
                                else dias = res.Casa.Calendario.DiaaMes3;
                                while (dias[inicial, 0] != dia)
                                    inicial++;
                                for (int d = inicial; d < suma; d++)
                                {
                                    if (dias[d, 1] == 1) dias[d, 1] = 0;
                                }
                                cliente.ReservasCliente.RemoveAt(fCancelar.comboBox1.SelectedIndex + 1);
                                empresa.CancelarReserva(res);
                                mostrar();
                            }
                        }
                        else if (MessageBox.Show("Hotel" + "\nNombre: " + cliente.ReservasCliente[0].Hotel.Nombre + " " + cliente.ReservasCliente[0].Hotel.TipoHotel + "\n Habitacion: " + cliente.ReservasCliente[0].Habitacion.TípoPlaza, "Cancelar Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            Reserva res = cliente.ReservasCliente[0];
                            int inicial = 0;
                            int dia = res.Ingreso.Day;
                            int final = res.Salida.Day;
                            int suma = dia + final;
                            if (suma > 39)
                            {
                                suma = 39;
                            }
                            if (res.Ingreso.Month == 11)
                            {
                                dias = res.Habitacion.Calendario.DiaaMes1;
                            }
                            else if (res.Ingreso.Month == 12)
                            {
                                dias = res.Habitacion.Calendario.DiaaMes2;
                            }
                            while (dias[inicial, 0] != dia)
                                inicial++;
                            for (int d = inicial; d < suma; d++)
                            {
                                if (dias[d, 1] == 1) dias[d, 1] = 0;
                            }
                            cliente.ReservasCliente.RemoveAt(0);
                            empresa.CancelarReserva(res);
                            mostrar();
                        }

                    }
                }
                else MessageBox.Show("El cliente no ha realizado ninguna reserva!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else MessageBox.Show("Debes ingresar un cliente antes de reservar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        public Form1()
        {
            InitializeComponent();

        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarCliente ag = new AgregarCliente();
                if (ag.ShowDialog() == DialogResult.OK)
                {
                    empresa.AgregarCliente(ag.txtNombre.Text, ag.txtApellido.Text, Convert.ToInt32(ag.txtDNI.Text), Convert.ToDouble(ag.txtTelefono.Text));
                }
                else
                {
                    ag.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message + ex.InnerException); }
        }

        private void logearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Ingresar_Cliente ingresar = new Ingresar_Cliente();
                bool aux = false;
                if (ingresar.ShowDialog() == DialogResult.OK)
                {
                    if (ingresar.textBox1.Text == empresa.Admin.Nombre && Convert.ToInt32(ingresar.textBox2.Text) == empresa.Admin.Dni)
                    {
                        IngresarContraseña ing = new IngresarContraseña();
                        int intentos = 0; bool Ingresado = false;
                        while (intentos != 3 && Ingresado == false && ing.ShowDialog() == DialogResult.OK)
                        {
                            intentos++;
                            if (empresa.Admin.Contraseña == ing.textBox1.Text)
                            {
                                MessageBox.Show("Se ha ingresado Correctamente!\nADMINISTRADOR", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                Ingresado = true;
                                TSnombreCliente.Text = "Administrador";
                                toolStripStatusLabel2.Text = "Nicolas Collaud";
                                reservarToolStripMenuItem.Visible = false;
                                verRegistroToolStripMenuItem.Visible = true;
                                alojamientoToolStripMenuItem.Visible = true;
                                importarClientesToolStripMenuItem1.Visible = true;
                                exportarClientesToolStripMenuItem.Visible = true;


                            }
                            else MessageBox.Show("Constraseña Incorrecta!\nIntentos " + intentos + "/3", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        ing.Dispose(); ingresar.Dispose();
                    }
                    else
                    {
                        for (int i = 0; i < empresa.ListaClientes.Count; i++)
                        {
                            if (empresa.ListaClientes[i].Nombre == ingresar.textBox1.Text && empresa.ListaClientes[i].Dni == Convert.ToInt32(ingresar.textBox2.Text))
                            {
                                cliente = empresa.ListaClientes[i];
                                TSnombreCliente.Text = "Cliente:";
                                toolStripStatusLabel2.Text = cliente.Nombre;

                                reservarToolStripMenuItem.Visible = true;
                                verRegistroToolStripMenuItem.Visible = false;
                                alojamientoToolStripMenuItem.Visible = false;
                                importarClientesToolStripMenuItem1.Visible = false;
                                exportarClientesToolStripMenuItem.Visible = false;
                                ayudaToolStripMenuItem.Visible = true;
                                aux = true;
                                MessageBox.Show("Se ha ingresado Correctamente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        }
                        if (!aux) MessageBox.Show("Error al encontrar al cliente. \nIntentelo nuevamente.", "Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else ingresar.Dispose();
            }
            catch (Exception ex) { MessageBox.Show("Error al Ingresar Datos\n" + ex.Message); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cbLista.Items.Clear();
            btnVerCasas.Enabled = false;
            ServicioCasa.Visible = true;
            cbNroHabitacion.Visible = false;
            label16.Visible = false;
            foreach (Casa cas in empresa.ListaCasas)
                cbLista.Items.Add(cas.Direccion + " " + cas.Nropropiedad);
            BtnVerHoteles.Enabled = true;
            DetalleHotel.Visible = false;
        }

        private void VerHotel_Click(object sender, EventArgs e)
        {
            cbLista.Items.Clear();
            btnVerCasas.Enabled = true;
            ServicioCasa.Visible = false;
            cbNroHabitacion.Visible = true;
            label16.Visible = true;
            foreach (Hotel cas in empresa.ListaHoteles)
                cbLista.Items.Add(cas.Nombre + " " + cas.TipoHotel);

            BtnVerHoteles.Enabled = false;
            DetalleHotel.Visible = true;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //registrarToolStripMenuItem.Enabled = true;
            //reservarToolStripMenuItem.Visible = false;
            //acercaDeToolStripMenuItem.Visible = false;
            //ayudaToolStripMenuItem.Visible = false;
            //alojamientoToolStripMenuItem.Visible = false;
            //verRegistroToolStripMenuItem.Visible = false;

            TSnombreCliente.Text = " Cliente :";
            toolStripStatusLabel2.Text = "No se ha ingresado";
            int año = DateTime.Now.Year;
            int mes = DateTime.Now.Month;

            int largo = columnas * 20;
            int alto = filas * 15;
            DataGridCalendario.Width = largo + 70;
            DataGridCalendario.Height = alto + 70;
            DataGridCalendario.ColumnCount = columnas;
            DataGridCalendario.RowCount = filas;
            for (int i = 0; i < columnas; i++) { DataGridCalendario.Columns[i].Width = 30; }
            for (int i = 0; i < filas; i++) { DataGridCalendario.Rows[i].Height = 25; }
            DataGridCalendario[0, 0].Value = "D";
            DataGridCalendario[1, 0].Value = "L";
            DataGridCalendario[2, 0].Value = "M";
            DataGridCalendario[3, 0].Value = "M";
            DataGridCalendario[4, 0].Value = "J";
            DataGridCalendario[5, 0].Value = "V";
            DataGridCalendario[6, 0].Value = "S";

            //DESERIALIZACION
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"Backup\Guardado.dat", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                if (fs.Length != 0)
                {
                    empresa = (Empresa)bf.Deserialize(fs);
                }
                empresa.Administrador("Jonatan", 45552753, "Jonatan");
            }
            catch (SerializationException ex)
            { MessageBox.Show("ERROR AL DESERIALIZAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (IOException ex) { MessageBox.Show("Error de fichero"); }
            catch (Exception ex) { MessageBox.Show("Error al iniciar el sistema"); }
            finally { if (fs != null) fs.Close(); }

        }


        void limpiar()
        {
            for (int f = 1; f < filas; f++)
                for (int c = 0; c < columnas; c++)
                {
                    DataGridCalendario[c, f].Value = "";
                    DataGridCalendario[c, f].Style.BackColor = Color.Gray;
                }
        }


        void mostrar()
        {
            int c;
            int f;
            for (int d = 0; d < dias.GetLength(0); d++)
            {
                c = d % columnas;
                f = 1 + (d / columnas);
                if (dias[d, 0] != 0)
                {
                    DataGridCalendario[c, f].Value = dias[d, 0].ToString("00");
                    if (dias[d, 1] == 0) DataGridCalendario[c, f].Style.BackColor = Color.Aquamarine;
                    else DataGridCalendario[c, f].Style.BackColor = Color.Red;
                }
            }
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            int indice = cbLista.SelectedIndex;
            if (btnVerCasas.Enabled == false)
            {
                if (indice != -1)
                {
                    if (cBMes.SelectedIndex == 0)
                    {
                        dias = empresa.ListaCasas[indice].Calendario.DiaaMes1;
                    }
                    else if (cBMes.SelectedIndex == 1)
                    { dias = empresa.ListaCasas[indice].Calendario.DiaaMes2; }
                    else { dias = empresa.ListaCasas[indice].Calendario.DiaaMes3; }
                    limpiar();
                    mostrar();
                }
                else MessageBox.Show("Seleccione un alojamiento de ver su calendario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int indice2 = empresa.ListaHoteles[indice].ListaDeHabitacion[cbNroHabitacion.SelectedIndex].NumeroHabitacion;
                if (indice != -1)
                {
                    if (indice2 != -1)
                    {
                        if (cBMes.SelectedIndex == 0)
                        {
                            dias = empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes1;
                        }
                        else if (cBMes.SelectedIndex == 1)
                        { dias = empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes2; }
                        else { dias = empresa.ListaHoteles[indice].ListaDeHabitacion[indice2].Calendario.DiaaMes3; }
                        limpiar();
                        mostrar();
                    }
                    else MessageBox.Show("Seleccione una habitacion para ver su calendario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else MessageBox.Show("Seleccione un alojamiento para ver su calendario!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (BtnVerHoteles.Enabled == false)
                {
                    int indice = cbLista.SelectedIndex;
                    CrearHotel sds = new CrearHotel();
                    sds.Text = "Modificar Hotel " + empresa.ListaHoteles[indice].Nombre;
                    bool aux = false;
                    while (sds.ShowDialog() == DialogResult.OK && aux == false)
                    {

                        empresa.ListaHoteles[indice].Nombre = sds.txtNombreHotel.Text;
                        empresa.ListaHoteles[indice].TipoHotel = (Hotel.HotelEstrella)sds.cbEstrellas.SelectedIndex;
                        empresa.ListaHoteles[indice].ValorBase = Convert.ToDouble(sds.nudValorBase.Value);
                        cbLista.Items.Clear();
                        foreach (Hotel hotel in empresa.ListaHoteles) { cbLista.Items.Add(hotel.Nombre + " " + hotel.TipoHotel); }
                        break;
                    }


                }
                else
                {
                    CrearCasa Mcasa = new CrearCasa();
                    int indice = cbLista.SelectedIndex;
                    Mcasa.Text = "Modificar Casa " + empresa.ListaCasas[indice].Direccion + " " + empresa.ListaCasas[indice].Nropropiedad;
                    bool aux = false;
                    while (Mcasa.ShowDialog() == DialogResult.OK && aux == false)
                    {
                        empresa.ModificarCasa(indice, Mcasa.rBcochera.Checked, Mcasa.rBPileta.Checked, Mcasa.rBWifi.Checked, Mcasa.rBLimpieza.Checked, Mcasa.rBDesayuno.Checked,
                        Mcasa.rBMascota.Checked, Mcasa.txtDireccion.Text, Convert.ToInt32(Mcasa.nudNroPropiedad.Value), Convert.ToInt32(Mcasa.nudDiaMinimo.Value),
                        Convert.ToInt32(Mcasa.nudCamas.Value), Convert.ToInt32(Mcasa.nudPrecioPropiedad.Value));
                        cbLista.Items.Clear();
                        foreach (Casa hotel in empresa.ListaCasas) { cbLista.Items.Add(hotel.Direccion + " " + hotel.Nropropiedad); }
                        break;
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show("Error al Cargar Datos!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CrearHotel crearhotel = new CrearHotel();

                while (crearhotel.ShowDialog() == DialogResult.OK)
                {
                    if (crearhotel.txtNombreHotel.Text != "")
                    {
                        calendario calendar = new calendario(DateTime.Now.Month + 1, DateTime.Now.Year);
                        empresa.AgregarHotel(crearhotel.rBcochera.Checked, crearhotel.rBPileta.Checked, crearhotel.rBWifi.Checked, crearhotel.rBLimpieza.Checked, crearhotel.rBDesayuno.Checked, crearhotel.rBMascota.Checked,
                            crearhotel.txtNombreHotel.Text, (Hotel.HotelEstrella)crearhotel.cbEstrellas.SelectedIndex, Convert.ToDouble(crearhotel.nudValorBase.Value), crearhotel.Cantidad, crearhotel.Directorio,
                            crearhotel.txtDestino.Text.ToLower(), crearhotel.txtDireccion.Text, Convert.ToInt32(crearhotel.txtNroPropiedad.Text));
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar el Nombre del Hotel!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (BtnVerHoteles.Enabled == false)
                {
                    cbLista.Items.Clear();
                    foreach (Hotel cas in empresa.ListaHoteles)
                        cbLista.Items.Add(cas.Nombre + " " + cas.TipoHotel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void casaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CrearCasa crearCasa = new CrearCasa();
                while (crearCasa.ShowDialog() == DialogResult.OK)
                {
                    if (crearCasa.txtDireccion.Text != "")
                    {
                        calendario calendar = new calendario(DateTime.Now.Month + 1, DateTime.Now.Year);
                        empresa.AgregarCasa(crearCasa.rBcochera.Checked, crearCasa.rBPileta.Checked, crearCasa.rBWifi.Checked, crearCasa.rBLimpieza.Checked, crearCasa.rBDesayuno.Checked, crearCasa.rBMascota.Checked, crearCasa.txtDireccion.Text, Convert.ToInt32(crearCasa.nudNroPropiedad.Value), Convert.ToInt32(crearCasa.nudDiaMinimo.Value), Convert.ToInt32(crearCasa.nudCamas.Value), Convert.ToDouble(crearCasa.nudPrecioPropiedad.Value), calendar, crearCasa.Cantidad, crearCasa.Directorio, crearCasa.txtDestino.Text.ToLower());
                    }
                    else MessageBox.Show("Direccion Invalida o error de formato!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (btnVerCasas.Enabled == false)
                {
                    cbLista.Items.Clear();
                    foreach (Casa casa in empresa.ListaCasas)
                    {
                        cbLista.Items.Add(casa.Direccion + " " + casa.Nropropiedad);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void casaFindeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                FagregarCasaFinde crearCasaFinde = new FagregarCasaFinde();
                while (crearCasaFinde.ShowDialog() == DialogResult.OK)
                {
                    if (crearCasaFinde.txtDireccionCasaFinde.Text != "")
                    {
                        calendario calendar = new calendario(DateTime.Now.Month + 1, DateTime.Now.Year);
                        
                        empresa.AgregarCasaFinde(crearCasaFinde.rBcochera.Checked, crearCasaFinde.rBPileta.Checked, crearCasaFinde.rBWifi.Checked,
                            crearCasaFinde.rBLimpieza.Checked, crearCasaFinde.rBDesayuno.Checked, crearCasaFinde.rBMascota.Checked,
                            crearCasaFinde.txtDireccionCasaFinde.Text, Convert.ToInt32(crearCasaFinde.nudNroPropiedadCasaFinde.Value),
                            Convert.ToInt32(crearCasaFinde.nudDiaMinimoCasaFinde.Value), Convert.ToInt32(crearCasaFinde.nudCamasCasaFinde.Value),
                            Convert.ToDouble(crearCasaFinde.nudPrecioPropiedadCasaFinde.Value), calendar, crearCasaFinde.Cantidad, crearCasaFinde.Directorio,
                            crearCasaFinde.txtDestinoCasaFinde.Text.ToLower());
                    }
                    else MessageBox.Show("Direccion Invalida o error de formato!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (btnVerCasasFinde.Enabled == false)
                {
                    cbLista.Items.Clear();
                    foreach (CasaFinde casafinde in empresa.ListaCasaFin)
                    {
                        cbLista.Items.Add(casafinde.Direccion + " " + casafinde.Nropropiedad);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }




        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BtnVerHoteles.Enabled == false)
            {
                int indice = cbLista.SelectedIndex;
                if (indice != -1)
                {
                    if (MessageBox.Show("Seguro que quiere eliminar el Hotel " + empresa.ListaHoteles[indice].Nombre, "Eliminar Alojamiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        empresa.EliminarHotel(indice);
                        cbLista.Items.RemoveAt(indice);

                    }
                }
                else MessageBox.Show("Debe seleccionar un alojamiento desde la Lista para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int indice = cbLista.SelectedIndex;
                if (indice != -1)
                {
                    if (MessageBox.Show("Seguro que quiere eliminar la Casa " + empresa.ListaCasas[indice].Direccion + " " + empresa.ListaCasas[indice].Nropropiedad, "Eliminar Alojamiento", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        empresa.EliminarCasa(indice);
                        cbLista.Items.RemoveAt(indice);
                    }
                }
                else MessageBox.Show("Error, Debe seleccionar un alojamiento desde la Lista para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void realizarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = cbLista.SelectedIndex;
                if (indice != -1)
                {
                    RealizarReserva();
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                    //if (printDialog1.ShowDialog() == DialogResult.OK)
                    //{
                    //    printDocument1.Print();
                    //}
                }
                else MessageBox.Show("Seleccione un alojamiento antes de reservar!", "Reserva", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) { MessageBox.Show("Error al realizar reserva" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CancelarReserva();
            }
            catch (Exception ex) { MessageBox.Show("Error al cancelar reserva" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta cons = new Consulta();
            if (cliente != null)
            {
                if (cliente.ReservasCliente.Count != 0)
                {
                    cons.lbConsultas.Items.Clear();
                    foreach (Reserva res in cliente.ReservasCliente)
                    {
                        if (res.Hotel != null)
                        {
                            cons.lbConsultas.Items.Add("-------------RESERVA---------------");
                            cons.lbConsultas.Items.Add("Hotel: " + res.Hotel.Nombre);
                            cons.lbConsultas.Items.Add("Tipo: " + res.Hotel.TipoHotel);
                            cons.lbConsultas.Items.Add("Habitacion: " + res.Habitacion.NumeroHabitacion + 1);
                            cons.lbConsultas.Items.Add("Plaza: " + res.Habitacion.TípoPlaza);
                            cons.lbConsultas.Items.Add("Ingreso: " + res.Ingreso.ToShortDateString());
                            cons.lbConsultas.Items.Add("Salida: " + res.Salida.ToShortDateString());
                            cons.lbConsultas.Items.Add("Precio Contratado: " + res.ValorBaseContratado);
                            cons.lbConsultas.Items.Add(" ");
                        }
                        else
                        {
                            cons.lbConsultas.Items.Add("-------------RESERVA---------------");
                            cons.lbConsultas.Items.Add("Casa: " + res.Casa.Direccion + " " + res.Casa.Nropropiedad);
                            cons.lbConsultas.Items.Add("Ingreso: " + res.Ingreso.ToShortDateString());
                            cons.lbConsultas.Items.Add("Salida: " + res.Salida.ToShortDateString());
                            cons.lbConsultas.Items.Add("Precio Contratado: " + res.ValorBaseContratado);
                            cons.lbConsultas.Items.Add(" ");
                        }
                    }
                    cons.ShowDialog();
                }
                else MessageBox.Show("El cliente no ha realizado ninguna reserva!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else MessageBox.Show("Debes ingresar un cliente antes de reservar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(cliente.ReservasCliente.Count != 0)
            {
                CancelarReserva();
                RealizarReserva();
            }

            else
            {
                MessageBox.Show("El cliente no ha realizado ninguna reserva!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void Lista1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int indice = cbLista.SelectedIndex;
            if (btnVerCasas.Enabled == false)
            {

                Casa casa;
                if (cbLista.SelectedIndex == -1)
                {
                    casa = empresa.ListaCasas[cbLista.SelectedIndex + 1];
                }
                else
                {
                    casa = empresa.ListaCasas[cbLista.SelectedIndex];
                }
                if (casa.Mascotas)
                {
                    Mascota.Text = "Si";
                }

                else { Mascota.Text = "No"; }

                if (casa.Pileta)
                {
                    Pileta.Text = "Si";
                }

                else { Pileta.Text = "No"; }


                if (casa.Wifi)
                {
                    Wifi.Text = "Si";
                }

                else { Wifi.Text = "No"; }

                Camas.Text = Convert.ToString(casa.CantidadCamas);

                if (casa.Limpieza)
                {
                    Limpieza.Text = "Si";
                }

                else { Limpieza.Text = "No"; }


                if (casa.Cochera)
                {
                    Cochera.Text = "Si";
                }

                else { Cochera.Text = "No"; }


                if (casa.Desayuno)
                {
                    Desayuno.Text = "Si";
                }

                else { Desayuno.Text = "No"; }


                DiaMinimo.Text = Convert.ToString(casa.MinimoDias);
                Precio.Text = Convert.ToString(casa.PrecioBase);

                if (casa.Images != null)
                {
                    pictureBox1.Image = casa.Images[0];
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    controladorImagenes = 0;
                }
                else MessageBox.Show("Esta propiedad no tiene imagenes!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (indice != -1)
                {
                    if (cBMes.SelectedIndex == 0 || cBMes.SelectedIndex == -1)
                    {
                        dias = empresa.ListaCasas[indice].Calendario.DiaaMes1;
                    }
                    else if (cBMes.SelectedIndex == 1)
                    { dias = empresa.ListaCasas[indice].Calendario.DiaaMes2; }
                    else { dias = empresa.ListaCasas[indice].Calendario.DiaaMes3; }
                    limpiar();
                    mostrar();
                }
            }

            else
            {

                cbNroHabitacion.Items.Clear();
                Hotel hotel;


                if (cbLista.SelectedIndex == -1)
                {
                    hotel = empresa.ListaHoteles[cbLista.SelectedIndex + 1];
                }
                else
                {
                    hotel = empresa.ListaHoteles[cbLista.SelectedIndex];
                }

                if (hotel.Mascotas)
                {
                    MascotasHotel.Text = "Si";
                }

                else { MascotasHotel.Text = "No"; }

                if (hotel.Pileta)
                {
                    PiletaHotel.Text = "Si";
                }

                else { PiletaHotel.Text = "No"; }


                if (hotel.Wifi)
                {
                    WiFiHotel.Text = "Si";
                }

                else { WiFiHotel.Text = "No"; }

                if (hotel.Limpieza)
                {
                    LimpiezaHotel.Text = "Si";
                }

                else { LimpiezaHotel.Text = "No"; }


                if (hotel.Cochera)
                {
                    CocheraHotel.Text = "Si";
                }

                else { CocheraHotel.Text = "No"; }


                if (hotel.Desayuno)
                {
                    DesayunoHotel.Text = "Si";
                }

                else { DesayunoHotel.Text = "No"; }

                TipoHotel.Text = Convert.ToString(hotel.TipoHotel);
                foreach (Habitacion plaza in hotel.ListaDeHabitacion)
                {
                    cbNroHabitacion.Items.Add("Nro " + plaza.NumeroHabitacion + 1 + " " + plaza.TípoPlaza.ToString());
                    if (plaza.TípoPlaza == Habitacion.Plazas.Doble)
                    {
                        HabDxDia.Text = Convert.ToString(plaza.Precio);
                    }
                    else if (plaza.TípoPlaza == Habitacion.Plazas.Triple)
                    {
                        HabTxDia.Text = Convert.ToString(plaza.Precio);
                    }
                    else { HabSxDia.Text = Convert.ToString(plaza.Precio); }
                }
                if (hotel.ImagenHotel != null)
                {
                    pictureBox1.Image = hotel.ImagenHotel[0];
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    controladorImagenes = 0;
                }
                else MessageBox.Show("Esta propiedad no tiene imagenes!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        BuscarAlojamiento bas = new BuscarAlojamiento();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                while (bas.ShowDialog() == DialogResult.OK)
                {
                    if (bas.radioButton1.Checked)
                    {
                        bas.DGV.Rows.Clear();
                        string lugar = bas.textBox1.Text.ToLower();
                        
                        Casa[] lista = empresa.FiltroLugarCasas(lugar);
                        Hotel[] lista1 = empresa.FiltroLugarHoteles(lugar);
                        //CasaFinde[] lista2 = empresa.FiltrarLugarCasaFinde(lugar);
                        for (int i = 0; i < lista.Length; i++)
                            
                        {
                            string linea = lista[i].ToString();
                            string[] campos = linea.Split(';');
                            bas.DGV.Rows.Add(campos);
                        }
                        for (int i = 0; i < lista1.Length; i++)
                        {
                            string linea = lista1[i].ToString();
                            string[] campos = linea.Split(';');
                            bas.DGV.Rows.Add(campos);
                        }
                    }
                    if (bas.radioButton2.Checked)
                    {
                        bas.DGV.Rows.Clear();
                        int cant = Convert.ToInt32(bas.textBox2.Text);
                        Casa[] lista = empresa.FiltroCantPasajerosCasa(cant);
                        for (int i = 0; i < lista.Length; i++)
                        {
                            string linea = lista[i].ToString();
                            string[] campos = linea.Split(';');
                            bas.DGV.Rows.Add(campos);
                        }
                        foreach (Hotel hot in empresa.ListaHoteles)
                        {
                            string linea = hot.ToString();
                            string[] campos = linea.Split(';');
                            bas.DGV.Rows.Add(campos);
                        }
                    }
                    if (bas.radioButton3.Checked)
                    {
                        bas.DGV.Rows.Clear();
                        int dia, final;
                        int inicial = 0;
                        int[,] aux = new int[40, 2];
                        int indice = cbLista.SelectedIndex;
                        foreach (Casa cas in empresa.ListaCasas)
                        {
                            bool correcto = true;
                            if (bas.dateTimePicker1.Value.Month == 11)
                            {
                                dias = cas.Calendario.DiaaMes1;
                            }
                            else if (bas.dateTimePicker1.Value.Month == 12) { dias = cas.Calendario.DiaaMes2; } else { dias = cas.Calendario.DiaaMes3; }
                            Array.Copy(dias, aux, 80);
                            dia = bas.dateTimePicker1.Value.Day;
                            final = Convert.ToInt32(bas.textBox3.Text);
                            while (dias[inicial, 0] != dia)
                                inicial++;
                            for (int d = inicial; d < final + inicial; d++)
                            {
                                if (aux[d, 1] == 0) aux[d, 1] = 1;
                                else correcto = false;
                            }
                            if (correcto)
                            {
                                string linea = cas.ToString();
                                string[] campos = linea.Split(';');
                                bas.DGV.Rows.Add(campos);
                            }
                        }
                        foreach (Hotel hot in empresa.ListaHoteles)
                        {
                            string linea = hot.ToString();
                            string[] campos = linea.Split(';');
                            bas.DGV.Rows.Add(campos);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al cargar Datos\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int indice = cbLista.SelectedIndex;

            if (indice != -1)
            {
                if (btnVerCasas.Enabled == false)
                {
                    Casa casa = empresa.ListaCasas[indice];
                    controladorImagenes++;
                    if (controladorImagenes < casa.Images.Length)
                    {
                        pictureBox1.Image = casa.Images[controladorImagenes];
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else controladorImagenes--;
                }
                else
                {
                    Hotel hotel = empresa.ListaHoteles[indice];
                    controladorImagenes++;
                    if (controladorImagenes < hotel.ImagenHotel.Length)
                    {
                        pictureBox1.Image = hotel.ImagenHotel[controladorImagenes];
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else controladorImagenes--;
                }
            }
            else MessageBox.Show("Seleccione un alojamiento para ver su imagenes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int indice = cbLista.SelectedIndex;

            if (indice != -1)
            {
                if (btnVerCasas.Enabled == false)
                {
                    Casa casa = empresa.ListaCasas[indice];
                    controladorImagenes--;
                    if (controladorImagenes != -1)
                    {
                        pictureBox1.Image = casa.Images[controladorImagenes];
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else controladorImagenes++;
                }
                else
                {
                    Hotel hotel = empresa.ListaHoteles[indice];
                    controladorImagenes--;
                    if (controladorImagenes != -1)
                    {
                        pictureBox1.Image = hotel.ImagenHotel[controladorImagenes];
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else controladorImagenes++;
                }
            }
            else MessageBox.Show("Seleccione un alojamiento para ver su imagenes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios establecidos?", "Sistema de Reserva", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                FileStream fs = new FileStream(@"Backup\Guardado.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, empresa);
                fs.Close();
            }
        }

        private void verRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image QR = null;
            GenerarQR DibujarQR = new GenerarQR();

            byte[] bytes = DibujarQR.Generar("https://alquileresrenthome.netlify.app/");

                Image logo;
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            string carpetaImagenes = Path.Combine(directorioBase, "Resources");
            string rutaImagen = Path.Combine(carpetaImagenes, "C:/Users/Administrator/source/repos/tpFinal/TP3FINAL/WindowsFormsApp2/Resources/logooooo.png");
            logo = Image.FromFile(rutaImagen);

            try
            {
                ListaRegistro lr = new ListaRegistro();
                lr.listBox1.Items.Clear();
                Reserva res = cliente.ReservasCliente[cliente.ReservasCliente.Count - 1];
                
                float posY = 30;
                float posX = 30;

                if (PaginaActual == 0)
                {
                    e.Graphics.DrawString("--------------------------------------------------------------------ORIGINAL-------------------------------------------------------------------------------------", new Font("Segoe", 20), Brushes.Black, new PointF(posX - 50, posY));
                    posY += 50;
                    e.Graphics.DrawString("Cliente: " + res.Cliente.Nombre + " " + res.Cliente.Apellido, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("DNI: " + res.Cliente.Dni, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Telefono: " + res.Cliente.Tlefono, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Huespedes", new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    for (int i = 0; i < huesped.Length; i++)
                    {
                        e.Graphics.DrawString(huesped[i], new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                    }
                    if (res.Casa != null)
                    {
                        Image imagenCasa = res.Casa.Images[0];
                        e.Graphics.DrawImage(imagenCasa, 50, 750, 300, 300);
                        e.Graphics.DrawString("Alojamiento: " + res.Casa.Direccion + " " + res.Casa.Nropropiedad, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                    }
                    else
                    {
                        Image imagenHotel = res.Hotel.ImagenHotel[0];
                        e.Graphics.DrawImage(imagenHotel, 50, 750, 300, 300);
                        e.Graphics.DrawString("Alojamiento: " + res.Hotel.Nombre + "  " + res.Hotel.TipoHotel, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                        e.Graphics.DrawString("Habitacion: " + res.Habitacion.TípoPlaza + "  Nro" + res.Habitacion.NumeroHabitacion, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                    }
                    e.Graphics.DrawString("Cantidad de pasajeros admitidos: " + res.PersonasAdmitidas, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Fecha y hora que realizo la reserva: " + res.FechaDeReservacion, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Ingreso al Alojamiento: " + res.Ingreso.ToShortDateString(), new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Salida al Alojamiento: " + res.Salida.ToShortDateString(), new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Costo por dia: " + res.ValorBaseContratado + " $", new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("COSTO TOTAL" + res.PrecioFinal + " $", new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawImage(logo, 760, 60);

                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        QR = Image.FromStream(ms);
                        Image QRr = new Bitmap(QR, 250, 250);
                        e.Graphics.DrawImage(QRr, 500, 800);

                    }


                    PaginaActual++;
                    e.HasMorePages = true; 
                }
                
                else if (PaginaActual == 1)
                {
                    e.Graphics.DrawString("---------------------------------------------------------------------COPIA-------------------------------------------------------------------------------", new Font("Segoe", 20), Brushes.Black, new PointF(posX -50, posY));
                    posY += 50;
                    e.Graphics.DrawString("Cliente: " + res.Cliente.Nombre + " " + res.Cliente.Apellido, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("DNI: " + res.Cliente.Dni, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Telefono: " + res.Cliente.Tlefono, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Huespedes", new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    for (int i = 0; i < huesped.Length; i++)
                    {
                        e.Graphics.DrawString(huesped[i], new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                    }
                    if (res.Casa != null)
                    {
                        Image imagenCasa = res.Casa.Images[0];
                        e.Graphics.DrawImage(imagenCasa, 50, 750, 300, 300);
                        e.Graphics.DrawString("Alojamiento: " + res.Casa.Direccion + " " + res.Casa.Nropropiedad, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                    }
                    else
                    {
                        Image imagenHotel = res.Hotel.ImagenHotel[0];
                        e.Graphics.DrawImage(imagenHotel, 50, 750, 300, 300);
                        e.Graphics.DrawString("Alojamiento: " + res.Hotel.Nombre + "  " + res.Hotel.TipoHotel, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                        e.Graphics.DrawString("Habitacion: " + res.Habitacion.TípoPlaza + "  Nro" + res.Habitacion.NumeroHabitacion, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                        posY += 50;
                    }
                    e.Graphics.DrawString("Cantidad de pasajeros admitidos: " + res.PersonasAdmitidas, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Fecha y hora que realizo la reserva: " + res.FechaDeReservacion, new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Ingreso al Alojamiento: " + res.Ingreso.ToShortDateString(), new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Salida al Alojamiento: " + res.Salida.ToShortDateString(), new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("Costo por dia: " + res.ValorBaseContratado + " $", new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawString("COSTO TOTAL--------->" + res.PrecioFinal + " $", new Font("Segoe", 20), Brushes.Black, new PointF(posX, posY));
                    posY += 50;
                    e.Graphics.DrawImage(logo, 760, 60);

                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        QR = Image.FromStream(ms);
                        Image QRr = new Bitmap(QR,250,250);
                        e.Graphics.DrawImage(QRr, 500, 800);
                    }
                    //PaginaActual++;
                    e.HasMorePages = false;
                    PaginaActual = 0;
                }
                else
                {
                    PaginaActual = 0;
                    res = null;
                    e.HasMorePages = false; 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error..");
            }

        }

        private void exportarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = null; StreamWriter sw = null;
            try
            {
                int indice = cbLista.SelectedIndex;
                string path = @"Backup\Propiedad";
                string pathcompleto;
                if (btnVerCasas.Enabled == false)
                {
                    pathcompleto = Path.Combine(path, empresa.ListaCasas[indice].Direccion + empresa.ListaCasas[indice].Nropropiedad + ".CSV");
                }
                else { pathcompleto = Path.Combine(path, empresa.ListaHoteles[indice].Direccion + empresa.ListaHoteles[indice].NroPropiedad + ".CSV"); }
                fs = new FileStream(pathcompleto, FileMode.OpenOrCreate, FileAccess.Write);
                sw = new StreamWriter(fs);
                if (btnVerCasas.Enabled == false)
                {
                    sw.WriteLine("tipo;ingreso;salida;dniCliente;Nombre;Apellido;Telefono;direccion;nropropiedad;FechaReservacion");
                    foreach (Reserva res in empresa.ListaCasas[indice].ReservasCasa)
                    {
                        sw.WriteLine("Casa;" + res.Ingreso.ToShortDateString() + ";" + res.Salida.ToShortDateString() + ";" + res.Cliente.Dni + ";" + res.Cliente.Nombre + ";" + res.Cliente.Apellido + ";" + res.Cliente.Tlefono + ";" + empresa.ListaCasas[indice].Direccion + ";" + empresa.ListaCasas[indice].Nropropiedad + ";" + res.FechaDeReservacion);
                    }
                    MessageBox.Show("Se ha guardado Correctamente!", "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    sw.WriteLine("tipo;ingreso;salida;nroHabitacion;dniCliente;Nombre;Apellido;Telefono;direccion;nropropiedad;FechaReservacion");
                    foreach (Reserva res in empresa.ListaHoteles[indice].ReservaHotel)
                    {
                        sw.WriteLine("Hotel;" + res.Ingreso.ToShortDateString() + ";" + res.Salida.ToShortDateString() + ";" + res.Habitacion.NumeroHabitacion + ";" + res.Cliente.Dni + ";" + res.Cliente.Nombre + ";" + res.Cliente.Apellido + ";" + res.Cliente.Tlefono + ";" + empresa.ListaHoteles[indice].Direccion + ";" + empresa.ListaHoteles[indice].NroPropiedad + ";" + res.FechaDeReservacion);
                    }
                    MessageBox.Show("Se ha guardado Correctamente!", "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex) { MessageBox.Show("Error en el archivo\n" + ex.Message); }
            finally { if (fs != null) { sw.Close(); fs.Close(); } }
        }

        private void importarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Importando Reservas";
            openFileDialog1.Filter = "Propiedades|*.csv";
            FileStream fs = null; StreamReader sr = null;
            try
            {
                string ruta = Application.StartupPath;
                string rutaArchivo = Path.Combine(ruta, "Propiedades.Csv");


                openFileDialog1.InitialDirectory = @"C:\Users\betra\Desktop\TP31.5\Backup\Propiedad";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    Casa casa = null; Hotel hot = null;
                    DateTime fecha = DateTime.Now;
                    int cantdias = 0;
                    while (sr.EndOfStream == false)
                    {
                        string linea = sr.ReadLine();
                        Cliente clienteNuv = null;
                        string[] campos = linea.Split(';');
                        bool encontro = false; int fd = 0;
                        DateTime ingreso = Convert.ToDateTime(campos[1]);
                        DateTime salida = Convert.ToDateTime(campos[2]);
                        if (campos[0] == "Casa")
                        {
                            while (fd < empresa.ListaCasas.Count && encontro == false)
                            {
                                if (empresa.ListaCasas[fd].Direccion == campos[7] && empresa.ListaCasas[fd].Nropropiedad == Convert.ToInt32(campos[8]))
                                {
                                    casa = empresa.ListaCasas[fd];
                                    encontro = true;
                                    fecha = Convert.ToDateTime(campos[9]);
                                    cantdias = salida.Day - ingreso.Day;
                                }
                                fd++;
                            }
                            if (encontro == false)
                            {
                                CrearCasa crearCasa = new CrearCasa();

                                crearCasa.Text = "Crear Casa " + campos[7] + " " + campos[8];
                                crearCasa.txtDireccion.Text = campos[7]; crearCasa.txtDireccion.Enabled = false;
                                crearCasa.nudNroPropiedad.Value = Convert.ToDecimal(campos[8]); crearCasa.nudNroPropiedad.Enabled = false;
                                fecha = Convert.ToDateTime(campos[9]);
                                cantdias = salida.Day - ingreso.Day;
                                bool lel = false;
                                while (crearCasa.ShowDialog() == DialogResult.OK && lel == false)
                                {
                                    if (crearCasa.txtDireccion.Text != "")
                                    {
                                        calendario calendar = new calendario(DateTime.Now.Month + 1, DateTime.Now.Year);
                                        empresa.AgregarCasa(crearCasa.rBcochera.Checked, crearCasa.rBPileta.Checked, crearCasa.rBWifi.Checked, crearCasa.rBLimpieza.Checked, crearCasa.rBDesayuno.Checked, crearCasa.rBMascota.Checked, crearCasa.txtDireccion.Text, Convert.ToInt32(crearCasa.nudNroPropiedad.Value), Convert.ToInt32(crearCasa.nudDiaMinimo.Value), Convert.ToInt32(crearCasa.nudCamas.Value), Convert.ToDouble(crearCasa.nudPrecioPropiedad.Value), calendar, crearCasa.Cantidad, crearCasa.Directorio, crearCasa.txtDestino.Text);
                                        casa = new Casa(crearCasa.rBcochera.Checked, crearCasa.rBPileta.Checked, crearCasa.rBWifi.Checked, crearCasa.rBLimpieza.Checked, crearCasa.rBDesayuno.Checked, crearCasa.rBMascota.Checked, crearCasa.txtDireccion.Text, Convert.ToInt32(crearCasa.nudNroPropiedad.Value), Convert.ToInt32(crearCasa.nudDiaMinimo.Value), Convert.ToInt32(crearCasa.nudCamas.Value), Convert.ToDouble(crearCasa.nudPrecioPropiedad.Value), calendar, crearCasa.Cantidad, crearCasa.Directorio, crearCasa.txtDestino.Text);
                                        break;
                                    }
                                    else MessageBox.Show("Error al cargar la direccion");
                                }
                                if (btnVerCasas.Enabled == false)
                                {
                                    cbLista.Items.Clear();
                                    foreach (Casa muy in empresa.ListaCasas)
                                    {
                                        cbLista.Items.Add(muy.Direccion + " " + muy.Nropropiedad);
                                    }
                                }
                            }

                        }
                        else if (campos[0] == "Hotel")
                        {
                            while (fd < empresa.ListaHoteles.Count && encontro == false)
                            {
                                if (empresa.ListaHoteles[fd].Direccion == campos[8] && empresa.ListaHoteles[fd].NroPropiedad == Convert.ToInt32(campos[9]))
                                {
                                    hot = empresa.ListaHoteles[fd];
                                    encontro = true;
                                    fecha = Convert.ToDateTime(campos[10]);
                                    cantdias = salida.Day - ingreso.Day;
                                }
                                fd++;
                            }
                            if (encontro == false)
                            {
                                CrearHotel crearhotel = new CrearHotel();
                                bool retorno = false;
                                crearhotel.txtDireccion.Text = campos[8]; crearhotel.txtDireccion.Enabled = false;
                                crearhotel.txtNroPropiedad.Text = campos[9]; crearhotel.txtNroPropiedad.Enabled = false;
                                while (crearhotel.ShowDialog() == DialogResult.OK && retorno == false)
                                {
                                    if (crearhotel.txtNombreHotel.Text != "")
                                    {
                                        empresa.AgregarHotel(crearhotel.rBcochera.Checked, crearhotel.rBPileta.Checked, crearhotel.rBWifi.Checked, crearhotel.rBLimpieza.Checked, crearhotel.rBDesayuno.Checked, crearhotel.rBMascota.Checked,
                                            crearhotel.txtNombreHotel.Text, (Hotel.HotelEstrella)crearhotel.cbEstrellas.SelectedIndex, Convert.ToDouble(crearhotel.nudValorBase.Value), crearhotel.Cantidad, crearhotel.Directorio,
                                            crearhotel.txtDestino.Text, crearhotel.txtDireccion.Text, Convert.ToInt32(crearhotel.txtNroPropiedad.Text));
                                        retorno = true;
                                    }
                                    else MessageBox.Show("Error al cargar el Nombre del Hotel");
                                }
                                if (BtnVerHoteles.Enabled == false)
                                {
                                    cbLista.Items.Clear();
                                    foreach (Hotel cas in empresa.ListaHoteles)
                                        cbLista.Items.Add(cas.Nombre + " " + cas.TipoHotel);
                                }
                            }
                        }
                        encontro = false; fd = 0;
                        while (fd < empresa.ListaClientes.Count && encontro == false)
                        {
                            if (empresa.ListaClientes[fd].Dni == Convert.ToInt32(campos[4]))
                            {
                                clienteNuv = empresa.ListaClientes[fd];
                                encontro = true;
                            }
                            fd++;
                        }
                        if (encontro == false)
                        {
                            clienteNuv = empresa.AgregarCliente(campos[5], campos[6], Convert.ToInt32(campos[4]), Convert.ToDouble(campos[7]));
                        }
                        int inicial = 0; int dia, final;
                        int[,] aux = new int[40, 2];
                        if (casa != null)
                        {
                            bool correcto = true;
                            if (ingreso.Month == 11)
                            {
                                dias = casa.Calendario.DiaaMes1;
                            }
                            else if (ingreso.Month == 12) { dias = casa.Calendario.DiaaMes2; } else { dias = casa.Calendario.DiaaMes3; }
                            Array.Copy(dias, aux, 80);
                            dia = ingreso.Day;
                            final = cantdias;
                            while (dias[inicial, 0] != dia)
                                inicial++;

                            for (int d = inicial; d < final + inicial; d++)
                            {
                                if (aux[d, 1] == 0) aux[d, 1] = 1;
                                else correcto = false;
                            }
                            if (correcto)
                            {
                                Array.Copy(aux, dias, 80);
                                if (ingreso.Month == 11)
                                {
                                    casa.Calendario.DiaaMes1 = dias;
                                }
                                else if (ingreso.Month == 12) { casa.Calendario.DiaaMes2 = dias; } else { casa.Calendario.DiaaMes3 = dias; }
                                MessageBox.Show("Se guardo con exito la Reserva del cliente " + clienteNuv.Nombre);
                                Array.Clear(aux, 0, 80);
                                empresa.AgregarReservaCasa(casa, clienteNuv, fecha, rd.Next(4) + 1, ingreso, cantdias);

                            }
                            else MessageBox.Show("Error al agregar reserva del cliente " + clienteNuv.Nombre);

                        }

                        else
                        {

                            encontro = true;
                            bool correcto = true;
                            if (ingreso.Month == 11)
                            {
                                dias = hot.ListaDeHabitacion[Convert.ToInt32(campos[3])].Calendario.DiaaMes1;
                            }
                            else if (ingreso.Month == 12) { dias = hot.ListaDeHabitacion[Convert.ToInt32(campos[3])].Calendario.DiaaMes2; } else { dias = hot.ListaDeHabitacion[Convert.ToInt32(campos[3])].Calendario.DiaaMes3; }
                            Array.Copy(dias, aux, 80);
                            dia = ingreso.Day;
                            final = cantdias;
                            while (dias[inicial, 0] != dia)
                                inicial++;

                            for (int d = inicial; d < final + inicial; d++)
                            {
                                if (aux[d, 1] == 0) aux[d, 1] = 1;
                                else correcto = false;
                            }
                            if (correcto)
                            {
                                Array.Copy(aux, dias, 80);
                                if (ingreso.Month == 11)
                                {
                                    hot.ListaDeHabitacion[Convert.ToInt32(campos[3])].Calendario.DiaaMes1 = dias;
                                }
                                else if (ingreso.Month == 12) { hot.ListaDeHabitacion[Convert.ToInt32(campos[3])].Calendario.DiaaMes2 = dias; } else { hot.ListaDeHabitacion[Convert.ToInt32(campos[3])].Calendario.DiaaMes3 = dias; }
                                MessageBox.Show("Se guardo con exito la Reserva del cliente " + clienteNuv.Nombre);
                                Array.Clear(aux, 0, 80);
                                empresa.AgregarReservaHabitacion(hot, ingreso, fecha, rd.Next(4) + 1, clienteNuv, Convert.ToInt32(campos[3]), cantdias);
                            }
                            else MessageBox.Show("Error al agregar reserva del cliente " + clienteNuv.Nombre);
                        }


                    }

                }

            }
            catch (Exception ex) { MessageBox.Show("Error al Importar Archivo\n" + ex.Message); }
            finally { if (fs != null) { sr.Close(); fs.Close(); } }
        }

        public void Importar(FileStream fs, StreamReader sr)
        {
            int lt = 0;
            Cliente cli = null; Hotel hot = null; Casa casa = null;
            while (!sr.EndOfStream)
            {
                string linea = sr.ReadLine();
                string[] campos = linea.Split(';');
                if (campos[0] != "Nombre")
                {
                    if (campos[0] != "Casa" && campos[0] != "Tipo" && campos[0] != "Hotel")
                    {
                        bool encontro = false; int fd = 0;
                        while (fd < empresa.ListaClientes.Count && encontro == false)
                        {
                            if (empresa.ListaClientes[fd].Dni == Convert.ToInt32(campos[2]))
                            {
                                cli = empresa.ListaClientes[fd];
                                encontro = true;
                            }
                            fd++;
                        }
                        if (encontro == false)
                        {
                            cli = empresa.AgregarCliente(campos[0], campos[1], Convert.ToInt32(campos[2]), Convert.ToDouble(campos[3]));
                        }
                    }
                    else if (campos[0] != "Tipo")
                    {
                        DateTime fecha = Convert.ToDateTime(campos[6]);
                        int cantdias = 0;
                        bool encontro = false; int fd = 0;
                        DateTime ingreso = Convert.ToDateTime(campos[3]);
                        DateTime salida = Convert.ToDateTime(campos[4]);
                        if (campos[0] == "Casa")
                        {
                            while (fd < empresa.ListaCasas.Count && encontro == false)
                            {
                                if (empresa.ListaCasas[fd].Direccion == campos[1] && empresa.ListaCasas[fd].Nropropiedad == Convert.ToInt32(campos[2]))
                                {
                                    casa = empresa.ListaCasas[fd];
                                    encontro = true;
                                    fecha = Convert.ToDateTime(campos[9]);
                                    cantdias = salida.Day - ingreso.Day;
                                }
                                fd++;
                            }
                            if (encontro == false)
                            {
                                CrearCasa crearCasa = new CrearCasa();
                                crearCasa.Text = "Crear Casa " + campos[1] + " " + campos[2];
                                crearCasa.txtDireccion.Text = campos[1]; crearCasa.txtDireccion.Enabled = false;
                                crearCasa.nudNroPropiedad.Value = Convert.ToDecimal(campos[2]); crearCasa.nudNroPropiedad.Enabled = false;
                                fecha = Convert.ToDateTime(campos[6]);
                                cantdias = salida.Day - ingreso.Day;
                                bool lel = false;
                                while (crearCasa.ShowDialog() == DialogResult.OK && lel == false)
                                {
                                    if (crearCasa.txtDireccion.Text != "")
                                    {
                                        calendario calendar = new calendario(DateTime.Now.Month + 1, DateTime.Now.Year);
                                        empresa.AgregarCasa(crearCasa.rBcochera.Checked, crearCasa.rBPileta.Checked, crearCasa.rBWifi.Checked, crearCasa.rBLimpieza.Checked, crearCasa.rBDesayuno.Checked, crearCasa.rBMascota.Checked, crearCasa.txtDireccion.Text, Convert.ToInt32(crearCasa.nudNroPropiedad.Value), Convert.ToInt32(crearCasa.nudDiaMinimo.Value), Convert.ToInt32(crearCasa.nudCamas.Value), Convert.ToDouble(crearCasa.nudPrecioPropiedad.Value), calendar, crearCasa.Cantidad, crearCasa.Directorio, crearCasa.txtDestino.Text);
                                        casa = new Casa(crearCasa.rBcochera.Checked, crearCasa.rBPileta.Checked, crearCasa.rBWifi.Checked, crearCasa.rBLimpieza.Checked, crearCasa.rBDesayuno.Checked, crearCasa.rBMascota.Checked, crearCasa.txtDireccion.Text, Convert.ToInt32(crearCasa.nudNroPropiedad.Value), Convert.ToInt32(crearCasa.nudDiaMinimo.Value), Convert.ToInt32(crearCasa.nudCamas.Value), Convert.ToDouble(crearCasa.nudPrecioPropiedad.Value), calendar, crearCasa.Cantidad, crearCasa.Directorio, crearCasa.txtDestino.Text);
                                        break;
                                    }
                                    else MessageBox.Show("Error al cargar la direccion");
                                }
                                if (btnVerCasas.Enabled == false)
                                {
                                    cbLista.Items.Clear();
                                    foreach (Casa muy in empresa.ListaCasas)
                                    {
                                        cbLista.Items.Add(muy.Direccion + " " + muy.Nropropiedad);
                                    }
                                }
                            }

                        }
                        else if (campos[0] == "Hotel")
                        {
                            while (fd < empresa.ListaHoteles.Count && encontro == false)
                            {

                                if (empresa.ListaHoteles[fd].Direccion == campos[1] && empresa.ListaHoteles[fd].NroPropiedad == Convert.ToInt32(campos[2]))
                                {
                                    hot = empresa.ListaHoteles[fd];
                                    encontro = true;
                                    fecha = Convert.ToDateTime(campos[6]);
                                    cantdias = salida.Day - ingreso.Day;
                                }
                                fd++;
                            }
                            if (encontro == false)
                            {
                                CrearHotel crearhotel = new CrearHotel();
                                bool pen = false;
                                crearhotel.txtDireccion.Text = campos[1]; crearhotel.txtDireccion.Enabled = false;
                                crearhotel.txtNroPropiedad.Text = campos[2]; crearhotel.txtNroPropiedad.Enabled = false;
                                while (crearhotel.ShowDialog() == DialogResult.OK && pen == false)
                                {
                                    if (crearhotel.txtNombreHotel.Text != "")
                                    {
                                        empresa.AgregarHotel(crearhotel.rBcochera.Checked, crearhotel.rBPileta.Checked, crearhotel.rBWifi.Checked, crearhotel.rBLimpieza.Checked, crearhotel.rBDesayuno.Checked, crearhotel.rBMascota.Checked, crearhotel.txtNombreHotel.Text, (Hotel.HotelEstrella)crearhotel.cbEstrellas.SelectedIndex, Convert.ToDouble(crearhotel.nudValorBase.Value), crearhotel.Cantidad, crearhotel.Directorio, crearhotel.txtDestino.Text, crearhotel.txtDireccion.Text, Convert.ToInt32(crearhotel.txtNroPropiedad.Text));
                                        pen = true;
                                    }
                                    else MessageBox.Show("Error al cargar el Nombre del Hotel");
                                }
                                if (BtnVerHoteles.Enabled == false)
                                {
                                    cbLista.Items.Clear();
                                    foreach (Hotel cas in empresa.ListaHoteles)
                                        cbLista.Items.Add(cas.Nombre + " " + cas.TipoHotel);
                                }
                            }
                        }
                        int inicial = 0; int dia, final;
                        int[,] aux = new int[40, 2];
                        if (casa != null)
                        {
                            bool correcto = true;
                            if (ingreso.Month == 11)
                            {
                                dias = casa.Calendario.DiaaMes1;
                            }
                            else if (ingreso.Month == 12) { dias = casa.Calendario.DiaaMes2; } else { dias = casa.Calendario.DiaaMes3; }
                            Array.Copy(dias, aux, 80);
                            dia = ingreso.Day;
                            final = cantdias;
                            while (dias[inicial, 0] != dia)
                                inicial++;

                            for (int d = inicial; d < final + inicial; d++)
                            {
                                if (aux[d, 1] == 0) aux[d, 1] = 1;
                                else correcto = false;
                            }
                            if (correcto)
                            {
                                Array.Copy(aux, dias, 80);
                                if (ingreso.Month == 11)
                                {
                                    casa.Calendario.DiaaMes1 = dias;
                                }
                                else if (ingreso.Month == 12) { casa.Calendario.DiaaMes2 = dias; } else { casa.Calendario.DiaaMes3 = dias; }
                                Array.Clear(aux, 0, 80);
                                empresa.AgregarReservaCasa(casa, cli, fecha, Convert.ToInt32(campos[5]), ingreso, cantdias);

                            }
                            else MessageBox.Show("Error al agregar reserva del cliente " + cli.Nombre);
                        }
                        else
                        {
                            encontro = true;
                            bool correcto = true;
                            if (ingreso.Month == 11)
                            {
                                dias = hot.ListaDeHabitacion[Convert.ToInt32(campos[7])].Calendario.DiaaMes1;
                            }
                            else if (ingreso.Month == 12) { dias = hot.ListaDeHabitacion[Convert.ToInt32(campos[7])].Calendario.DiaaMes2; } else { dias = hot.ListaDeHabitacion[Convert.ToInt32(campos[7])].Calendario.DiaaMes3; }
                            Array.Copy(dias, aux, 80);
                            dia = ingreso.Day;
                            final = cantdias;
                            while (dias[inicial, 0] != dia)
                                inicial++;

                            for (int d = inicial; d < final + inicial; d++)
                            {
                                if (aux[d, 1] == 0) aux[d, 1] = 1;
                                else correcto = false;
                            }
                            if (correcto)
                            {
                                Array.Copy(aux, dias, 80);
                                if (ingreso.Month == 11)
                                {
                                    hot.ListaDeHabitacion[Convert.ToInt32(campos[7])].Calendario.DiaaMes1 = dias;
                                }
                                else if (ingreso.Month == 12) { hot.ListaDeHabitacion[Convert.ToInt32(campos[7])].Calendario.DiaaMes2 = dias; } else { hot.ListaDeHabitacion[Convert.ToInt32(campos[7])].Calendario.DiaaMes3 = dias; }
                                MessageBox.Show("Se guardo con exito la Reserva del cliente " + cli.Nombre);
                                Array.Clear(aux, 0, 80);
                                empresa.AgregarReservaHabitacion(hot, ingreso, fecha, Convert.ToInt32(campos[5]), cli, Convert.ToInt32(campos[7]), cantdias);
                            }
                            else MessageBox.Show("Error al agregar reserva del cliente " + cli.Nombre);
                        }

                    }
                }
                lt++;

            }
        }

        public void Exportar(FileStream fs, StreamWriter sw)
        {
            for (int i = 0; i < empresa.ListaClientes.Count; i++)
            {
                sw.WriteLine("Nombre;Apellido;Dni;Telefono");
                sw.WriteLine(empresa.ListaClientes[i].Nombre + ";" + empresa.ListaClientes[i].Apellido + ";" + empresa.ListaClientes[i].Dni + ";" + empresa.ListaClientes[i].Tlefono);
                sw.WriteLine("Tipo;Direccion;NroPropiedad;Checkin,Checkout;Huespedes;FechaReservacion;NroHabtiacionHotel");
                foreach (Reserva res in empresa.ListaClientes[i].ReservasCliente)
                {
                    if (res.Casa != null)
                    {
                        sw.WriteLine("Casa;" + res.Casa.Direccion + ";" + res.Casa.Nropropiedad + ";" + res.Ingreso + ";" + res.Salida + ";" + res.PersonasAdmitidas + ";" + res.FechaDeReservacion);
                    }
                    else
                    {
                        sw.WriteLine("Hotel;" + res.Hotel.Direccion + ";" + res.Hotel.NroPropiedad + ";" + res.Ingreso.ToShortDateString() + ";" + res.Salida.ToShortDateString() + ";" + res.PersonasAdmitidas + ";" + res.FechaDeReservacion + ";" + res.Habitacion.NumeroHabitacion);
                    }

                }
            }

        }


        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaRegistro lr = new ListaRegistro();
            lr.listBox1.Items.Clear();
            List<Reserva> list = empresa.ListaReservas.OrderBy(reserva => reserva.Cliente.Nombre).ToList();
            foreach (Reserva res in list)
            {
                lr.listBox1.Items.Add("-------------------------------------------------------------------------------------------------");
                lr.listBox1.Items.Add("Cliente: " + res.Cliente.Nombre + " " + res.Cliente.Apellido);
                lr.listBox1.Items.Add("DNI: " + res.Cliente.Dni);
                lr.listBox1.Items.Add("Telefono: " + res.Cliente.Tlefono);
                if (res.Casa != null)
                {
                    lr.listBox1.Items.Add("Alojamiento: " + res.Casa.Direccion + " " + res.Casa.Nropropiedad);
                }
                else
                {
                    lr.listBox1.Items.Add("Alojamiento: " + res.Hotel.Nombre + "  " + res.Hotel.TipoHotel);
                    lr.listBox1.Items.Add("Habitacion: " + res.Habitacion.TípoPlaza + "  Nro" + res.Habitacion.NumeroHabitacion);
                }
                lr.listBox1.Items.Add("Cantidad de pasajeros admitidos: " + res.PersonasAdmitidas);
                lr.listBox1.Items.Add("Fecha y hora que realizo la reserva: " + res.FechaDeReservacion);
                lr.listBox1.Items.Add("Ingreso al Alojamiento: " + res.Ingreso.ToShortDateString());
                lr.listBox1.Items.Add("Salida al Alojamiento: " + res.Salida.ToShortDateString());
                lr.listBox1.Items.Add("Costo por dia: " + res.ValorBaseContratado + " $");
                lr.listBox1.Items.Add("COSTO TOTAL--------->" + res.PrecioFinal + " $");
            }
            lr.ShowDialog();
        }
        private void graficasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<Reserva> reservas = empresa.ListaReservas;
            bool existe = false;
            int[] cantHuespedes = new int[8];
            cantHuespedes[0] = 0;
            int[] dataAlojamiento = new int[2];// SI ES 0 ES CASA SI ES 1 ES HOTEL.
            foreach (Reserva r in reservas)
            {
                existe = true;
                //primera grafica
                int cant = r.PersonasAdmitidas;
                switch (cant)
                {
                    case 1:
                        cantHuespedes[cant]++; break;
                    case 2:
                        cantHuespedes[cant]++; break;
                    case 3:
                        cantHuespedes[cant]++; break;
                    case 4:
                        cantHuespedes[cant]++; break;
                    case 5:
                        cantHuespedes[cant]++; break;
                    case 6:
                        cantHuespedes[cant]++; break;
                    case 7:     //mayor que 6
                        cantHuespedes[cant]++; break;
                }
                //segunda grafica
                if (r.Casa != null)
                    dataAlojamiento[0]++;
                else if (r.Hotel != null)
                    dataAlojamiento[1]++;
            }
            //
            if (existe)
            {
                Graficas graficas = new Graficas(cantHuespedes, dataAlojamiento);
                graficas.Show();
            }
            else MessageBox.Show("No se ha realizado ninguna reserva!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vAyuda ayuda = new vAyuda();

            ayuda.Show();
        }


        private void exportarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Exportando clientes";
            saveFileDialog1.Filter = "Clientes|*.txt";
            saveFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "..", "..", "archivos");

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaCsv = saveFileDialog1.FileName;
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    fs = new FileStream(rutaCsv, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    List<Cliente> lista = empresa.ListaClientes;
                    //descartar cabecera

                    sw.WriteLine("Nombre;Apellido;Dni;Telefono");
                    foreach (Cliente cliente in lista)
                    {
                        sw.WriteLine(cliente);
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null)
                    {
                        if (sw != null) sw.Close();
                        fs.Close();
                    }
                }
            }
        }
        
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe vAcercade = new AcercaDe();
            vAcercade.ShowDialog();
            vAcercade.Dispose();
        }


        private void importarReservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importando Clientes";
            openFileDialog1.Filter = "Clientes|*.txt";


            openFileDialog1.InitialDirectory = Path.Combine(Application.StartupPath, "..", "..", "archivos");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string rutaCsv = openFileDialog1.FileName;
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(rutaCsv, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    //leer una vez con eso descarto la cabecera
                    string linea = sr.ReadLine();

                    while (sr.EndOfStream == false)
                    {
                        linea = sr.ReadLine();
                        string[] campos = linea.Split(';');

                        string nombre = campos[0];
                        string apellido = campos[1];
                        int dni = Convert.ToInt32(campos[2]);
                        long telefono = Convert.ToInt64(campos[3]);
                        empresa.AgregarCliente(nombre,apellido,dni,telefono);
                        MessageBox.Show("Importado el/los clientes");
                        /**/

                        Importar(fs,sr);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (fs != null)
                    {

                        if (sr != null) sr.Close();
                        fs.Close();
                    }
                }
            }
        
        }

        private void holaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void holaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cBMes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridCalendario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ServicioCasa_Enter(object sender, EventArgs e)
        {

        }
    }
}

