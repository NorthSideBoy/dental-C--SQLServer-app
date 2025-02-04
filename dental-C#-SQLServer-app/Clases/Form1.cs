﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;       
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace dental_C__SQLServer_app.Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CConexion.Conectar();
            dtGridViewpacientes.DataSource = Index();
        }

        public DataTable Index()
        {
            DataTable dataTable = new DataTable();
            string Sql = "SELECT * FROM pacientes";
            SqlCommand CMD = new SqlCommand(Sql, CConexion.Conectar());
            SqlDataAdapter adapter = new SqlDataAdapter(CMD);

            adapter.Fill(dataTable);
            return dataTable;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();
            MensajeBorrar();
            if (validarcampos())
            {
               
            

            string Guardar = "INSERT INTO pacientes (Nombre,Apellido,Cédula,FechaDeNacimiento,Dirección,Edad,Telefono,Sexo) VALUES (@Nombre,@Apellido,@Cédula,@FechaDeNacimiento,@Dirección,@Edad,@Telefono,@Sexo)";
            SqlCommand insert = new SqlCommand(Guardar, CConexion.Conectar());

            insert.Parameters.AddWithValue("@Nombre", textNombre.Text);
            insert.Parameters.AddWithValue("@Apellido", textApellido.Text);
            insert.Parameters.AddWithValue("@Cédula", textCédula.Text);
            insert.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
            insert.Parameters.AddWithValue("@Dirección", textDirección.Text);
            insert.Parameters.AddWithValue("@Edad", textEdad.Text);
            insert.Parameters.AddWithValue("@Telefono", textTelefono.Text);
            insert.Parameters.AddWithValue("@Sexo", textSexo.Text);

     
            insert.ExecuteNonQuery();
                MessageBox.Show("Los Datos Fueron Guardados Correctamente");

                dtGridViewpacientes.DataSource = Index();
            }

            

            

        }

        private bool validarcampos()
        {
            bool validado = true;

            if (textNombre.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textNombre, "Ingresar Nombre");

            }

            if (textApellido.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textApellido, "Ingresar Apellido");

            }

            if (textCédula.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textCédula, "Ingresar Cédula");

            }

            if (textFechaDeNacimiento.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textFechaDeNacimiento, "Ingresar Fecha De Nacimiento");

            }

            if (textDirección.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textDirección, "Ingresar Dirección");

            }

            if (textEdad.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textEdad, "Ingresar Edad");

            }

            if (textTelefono.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textTelefono, "Ingresar Teléfono");

            }

            if (textSexo.Text == "")
            {
                validado = false;
                errorProvider1.SetError(textSexo, "Ingresar Sexo");

            }

            return validado;
        }

        private void MensajeBorrar()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textApellido, "");
            errorProvider1.SetError(textCédula, "");
            errorProvider1.SetError(textFechaDeNacimiento, "");
            errorProvider1.SetError(textDirección, "");
            errorProvider1.SetError(textEdad, "");
            errorProvider1.SetError(textTelefono, "");
            errorProvider1.SetError(textSexo, "");
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Datagr(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("CURRENT ROW:", dtGridViewpacientes.CurrentRow);
                Text = dtGridViewpacientes.CurrentRow.Cells[0].Value.ToString();
                textNombre.Text = dtGridViewpacientes.CurrentRow.Cells[1].Value.ToString();
                textApellido.Text = dtGridViewpacientes.CurrentRow.Cells[2].Value.ToString();
                textCédula.Text = dtGridViewpacientes.CurrentRow.Cells[3].Value.ToString();
                textFechaDeNacimiento.Text = dtGridViewpacientes.CurrentRow.Cells[4].Value.ToString();
                textDirección.Text = dtGridViewpacientes.CurrentRow.Cells[5].Value.ToString();
                textEdad.Text = dtGridViewpacientes.CurrentRow.Cells[6].Value.ToString();
                textTelefono.Text = dtGridViewpacientes.CurrentRow.Cells[7].Value.ToString();
                textSexo.Text = dtGridViewpacientes.CurrentRow.Cells[8].Value.ToString();
            }
            catch (Exception Error) {
                System.Diagnostics.Debug.WriteLine(Error.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();
            string modificar = "UPDATE pacientes SET Nombre=@Nombre,Apellido=@Apellido,Cédula=@Cédula,FechaDeNacimiento=@FechaDeNacimiento,Dirección=@Dirección,Edad=@Edad,Telefono=@Telefono,Sexo=@Sexo WHERE Id=@Id";
            SqlCommand cambios = new SqlCommand(modificar, CConexion.Conectar());

            cambios.Parameters.AddWithValue("@Id", Text);
            cambios.Parameters.AddWithValue("@Nombre", textNombre.Text);
            cambios.Parameters.AddWithValue("@Apellido", textApellido.Text);
            cambios.Parameters.AddWithValue("@Cédula", textCédula.Text);
            cambios.Parameters.AddWithValue("@FechaDeNacimiento", textFechaDeNacimiento.Text);
            cambios.Parameters.AddWithValue("@Dirección", textDirección.Text);
            cambios.Parameters.AddWithValue("@Edad", textEdad.Text);
            cambios.Parameters.AddWithValue("@Telefono", textTelefono.Text);
            cambios.Parameters.AddWithValue("@Sexo", textSexo.Text);

            cambios.ExecuteNonQuery();

            MessageBox.Show("Los Datos Se Modificaron Correctamente");

            dtGridViewpacientes.DataSource = Index();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CConexion.Conectar();
            string Eliminar = "DELETE FROM pacientes WHERE Id=@Id";
            SqlCommand Borrar = new SqlCommand(Eliminar, CConexion.Conectar());

            Borrar.Parameters.AddWithValue("@Id", Text);

            Borrar.ExecuteNonQuery();
            MessageBox.Show("Paciente Eliminado Correctamente");

            dtGridViewpacientes.DataSource = Index();

        }

        private void textFechaDeNacimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
