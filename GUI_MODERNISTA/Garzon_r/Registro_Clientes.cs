using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Transversal;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelo_Negocio;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Windows.Input;
using System.Globalization;
using System.Drawing.Imaging;
using System.IO;

namespace Diseno
{
    public partial class Registro_Clientes : MaterialForm
    {
        public Registro_Clientes()
        {
            InitializeComponent();
            CargarGrilla();

            Dtclientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = true;
            Dtclientes.Visible = false;
        }

        public void limpiar_formulario()
        {
            TxtID.Text = "";
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtRut.Text = "";
            TxtFono.Text = "";
            TxtEmail.Text = "";
            TxtDireccion.Text = "";
        }

        public class Rut
        {
            public String formatear(String rut)
            {
                int cont = 0;
                String format;
                if (rut.Length == 0)
                {
                    return "";
                }
                else
                {
                    rut = rut.Replace(".", "");
                    rut = rut.Replace("-", "");
                    format = "-" + rut.Substring(rut.Length - 1);
                    for (int i = rut.Length - 2; i >= 0; i--)
                    {

                        format = rut.Substring(i, 1) + format;

                        cont++;
                        if (cont == 3 && i != 0)
                        {
                            format = "." + format;
                            cont = 0;
                        }
                    }
                    return format;
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();


            string message = "¿Estas seguro de agregar el pedido?.";
            string caption = "Añadir pedido.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                using (OracleCommand command = new OracleCommand("INSERTAR_CLIENTE_USUARIO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_NOMBRE", OracleDbType.Varchar2).Value = TxtNombre.Text;
                    command.Parameters.Add("V_APELLIDO", OracleDbType.Varchar2).Value = TxtApellido.Text;
                    command.Parameters.Add("V_RUT", OracleDbType.Varchar2).Value = TxtRut.Text;
                    command.Parameters.Add("V_EMAIL", OracleDbType.Varchar2).Value = TxtEmail.Text;
                    command.Parameters.Add("V_FONO", OracleDbType.Varchar2).Value = TxtFono.Text;


                    command.ExecuteNonQuery();


                }

                DataTable dt = new DataTable();
                string query = "SELECT ID_USUARIO FROM USUARIO WHERE id_rol = 7 AND NOMBRES||' '||APELLIDOS = '" + TxtNombre.Text + " "+ TxtApellido.Text +"'";
                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                CbxId.DataSource = dt;
                CbxId.DisplayMember = "ID_USUARIO";
                CbxId.ValueMember = "ID_USUARIO";

                using (OracleCommand cmd1 = new OracleCommand("INSERTAR_CLIENTE", conn))
                {
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Parameters.Add("V_DIRECCION", OracleDbType.Varchar2).Value = TxtDireccion.Text;
                    cmd1.Parameters.Add("V_ID_USUARIO", OracleDbType.Int32).Value = CbxId.SelectedValue.ToString();

                    cmd1.ExecuteNonQuery();

                }

                limpiar_formulario();
                PnlFormulario.Visible = false;

            }
        }

        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            PnlFormulario.Visible = false;
            Dtclientes.Visible = true;
        }

        private void TxtRut_Leave(object sender, EventArgs e)
        {
            Rut auxR = new Rut();
            this.TxtRut.Text = auxR.formatear(this.TxtRut.Text);
        }

        private void CargarGrilla()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            OracleDataAdapter adaptador = new OracleDataAdapter("select us.id_usuario,us.nombres,us.apellidos,us.rut,us.login,us.clave,us.email,us.Fono,us.id_rol,ro.nombre_rol,us.estado,to_char(us.fecha_creacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_creacion,to_char(us.fecha_modificacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_modificacion FROM usuario US JOIN ROL RO ON US.ID_ROL = RO.ID_ROL where us.estado = 'Activo' and us.id_rol = 7", conn);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Dtclientes.DataSource = tabla;
            conn.Close();
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string busqueda = (CultureInfo.InvariantCulture.TextInfo.ToTitleCase(TxtBusqueda.Text.ToLower()));

            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            OracleDataAdapter adaptador = new OracleDataAdapter("select us.id_usuario,us.nombres,us.apellidos,us.rut,us.login,us.clave,us.email,us.Fono,us.id_rol,ro.nombre_rol,us.estado,to_char(us.fecha_creacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_creacion,to_char(us.fecha_modificacion, 'dd-mm-yyyy hh24:mi:ss') as Fecha_modificacion FROM usuario US JOIN ROL RO ON US.ID_ROL = RO.ID_ROL where us.estado = 'Activo' and us.id_rol = 7 and us.nombres LIKE '%" + busqueda + "%'", conn);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            Dtclientes.DataSource = tabla;
            conn.Close();
        }

        private void Dtclientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BtnGuardarCambios.Visible = true;
            BtnGuardar.Visible = false;
            PnlFormulario.Visible = true;
            PnlFormulario.Visible = true;
            int FilaActual;
            FilaActual = Dtclientes.CurrentRow.Index;

            string id;
            id = Dtclientes.Rows[FilaActual].Cells[0].Value.ToString();
            TxtID.Text = id;

            string nombre;
            nombre = Dtclientes.Rows[FilaActual].Cells[1].Value.ToString();
            TxtNombre.Text = nombre;

            string apellido;
            apellido = Dtclientes.Rows[FilaActual].Cells[2].Value.ToString();
            TxtApellido.Text = apellido;

            string rut;
            rut = Dtclientes.Rows[FilaActual].Cells[3].Value.ToString();
            TxtRut.Text = rut;

            string email;
            email = Dtclientes.Rows[FilaActual].Cells[4].Value.ToString();
            TxtEmail.Text = email;

            string fono;
            fono = Dtclientes.Rows[FilaActual].Cells[5].Value.ToString();
            TxtFono.Text = fono;

            string direccion;
            direccion = Dtclientes.Rows[FilaActual].Cells[7].Value.ToString();
            TxtDireccion.Text = direccion;
        }
    }
}
