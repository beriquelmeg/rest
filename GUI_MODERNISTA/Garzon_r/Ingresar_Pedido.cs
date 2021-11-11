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
    public partial class Ingresar_Pedido : MaterialForm
    {
        bool cargado = false;

        public Ingresar_Pedido()
        {
            InitializeComponent();
            Dtpedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtPlatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DatosPersonas();
            DtPlatos.Visible = false;

            CbxCategoria.Enabled = false;
            CbxPlato.Enabled = false;
            TxtCantidad.Enabled = false;
        }

        private void Ingresar_Pedido_Load(object sender, EventArgs e)
        {
            CbxCategoria.DataSource = DatosCategoria();
            CbxCategoria.DisplayMember = "categoria"; //campo que queres mostrar
            CbxCategoria.ValueMember = "id_categoria"; //valor que capturas



            CbxPlato.DataSource = DatosPlato();
            CbxPlato.DisplayMember = "nombre_plato"; //campo que queres mostrar
            CbxPlato.ValueMember = "id_plato"; //valor que capturas



            cargado = true;
        }

        //listo
        public DataTable DatosCategoria()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_categoria,categoria from categoria order by id_categoria asc";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;
        }


        //listo
        public DataTable DatosPlato()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_plato,nombre_plato from plato where id_categoria = "+ CbxCategoria.SelectedIndex;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);
            return dt;
        }

        private void CbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxPlato.DataSource = DatosPlato();
        }

        public void DatosMesa( string v_a)
        {


            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select id_mesa, nro_mesa from mesa where disponibilidad = 'Disponible' and num_asientos = " + v_a;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            CbxMesa.DataSource = dt;
            CbxMesa.DisplayMember = "nro_mesa";
            CbxMesa.ValueMember = "id_mesa";
        }

        public void DatosCliente(string nombre)
        {


            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select us.nombres||' '||us.apellidos as nombre,cli.id_cliente  from usuario us join cliente cli on us.id_usuario = cli.id_usuario where us.id_rol = 7 and us.nombres||' '||us.apellidos like '%" + nombre + "%'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            CbxCliente.DataSource = dt;
            CbxCliente.DisplayMember = "nombre";
            CbxCliente.ValueMember = "id_cliente";
        }

        public void DatosPersonas()
        {

            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select DISTINCT num_asientos from mesa";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DataRow fila = dt.NewRow();
            fila["num_asientos"] = 0;
            dt.Rows.InsertAt(fila,0);

            CbxPersonas.DataSource = dt;
            CbxPersonas.DisplayMember = "num_asientos"; //campo que queres mostrar
            CbxPersonas.ValueMember = "num_asientos"; //valor que capturas

           
        }
        public void DatoTotal(string id)
        {


            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select SUM(ped.cantidad*pl.valor_plato) as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + id + " GROUP BY ped.id_pedido";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            CbxTotal.DataSource = dt;
            CbxTotal.DisplayMember = "Total";
            CbxTotal.ValueMember = "Total";
        }

        private void CbxPersonas_TextChanged(object sender, EventArgs e)
        {
            if (cargado)
            {
                string quewea = CbxPersonas.Text;

                DatosMesa(quewea);
            }
        }

        private void TxtCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (TxtCliente.Text == "Ingrese un nombre para filtrar.")
            {
                TxtCliente.Text = "";
                TxtCliente.ForeColor = Color.Black;
            }
        }

        private void TxtCliente_Leave(object sender, EventArgs e)
        {
            if (TxtCliente.Text == "")
            {
                TxtCliente.Text = "Ingrese un nombre para filtrar.";
                TxtCliente.ForeColor = Color.Gray;
            }
        }

        private void TxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string nombre = TxtCliente.Text;
                DatosCliente(nombre);
            }
            catch
            {

            }
        }

        private void BtnIngresarPedido_Click(object sender, EventArgs e)
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

                    using (OracleCommand command = new OracleCommand("INSERTAR_PEDIDO", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("V_CLIENTE", OracleDbType.Int32).Value = CbxCliente.SelectedValue.ToString();
                        command.Parameters.Add("V_MESA", OracleDbType.Int32).Value = CbxMesa.SelectedValue.ToString();


                        command.ExecuteNonQuery();


                    }

                    using (OracleCommand command = new OracleCommand("INGRESO_PEDIDO_MESA", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("V_ID_MESA", OracleDbType.Int32).Value = CbxMesa.SelectedValue.ToString();

                        command.ExecuteNonQuery();

                    }

                    DataTable dt = new DataTable();
                    string query = "select id_pedido from pedido where id_cliente = " + CbxCliente.SelectedValue.ToString();
                    OracleCommand cmd = new OracleCommand(query, conn);
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    da.Fill(dt);

                    Cbxid.DataSource = dt;
                    Cbxid.DisplayMember = "id_pedido";
                    Cbxid.ValueMember = "id_pedido";

                    BtnIngresarPedido.Visible = false;
                    BtnAgregarPlato.Visible = true;
                    BtnEliminarPlato.Visible = true;
                    BtnIngresarComanda.Visible = true;
                Dtpedido.Visible = false;
                DtPlatos.Visible = true;

                CbxCategoria.Enabled = true;
                CbxPlato.Enabled = true;
                TxtCantidad.Enabled = true;
            }

        }

        private void BtnAgregarPlato_Click(object sender, EventArgs e)
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

                using (OracleCommand command = new OracleCommand("INGRESO_PEDIDO_PLATO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_ID_PLATO", OracleDbType.Int32).Value = CbxPlato.SelectedValue.ToString();
                    command.Parameters.Add("V_ID_PEDIDO", OracleDbType.Int32).Value = Cbxid.Text;
                    command.Parameters.Add("V_CANTIDAD", OracleDbType.Int32).Value = TxtCantidad.Text;


                    command.ExecuteNonQuery();

                    CbxCategoria.SelectedIndex = 0;
                    TxtCantidad.Text = "";
                    CbxCategoria.Text = "";

                    CargarPlatos(Cbxid.Text);
                    DatoTotal(Cbxid.Text);
                }
            }
        }

        private void CargarPlatos(string id)
        {
            Dtpedido.Visible = false;
            DtPlatos.Visible = true;

            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();
            

            DataTable dt = new DataTable();
            string query = "select pl.nombre_plato as Plato, ped.id_plato as codigo_plato, pl.id_categoria as codigo_categoria, ped.id as ID_Comanda , ped.cantidad As Cantidad, pl.valor_plato As Valor from pedidoplato ped join plato pl on ped.id_plato = pl.id_plato where ped.id_pedido = " + id;
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtPlatos.DataSource = dt;
        }


        private void CargarPedidos()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select us.nombres||' '||us.apellidos as nombre,me.nro_mesa,me.num_asientos as nro_personas,ped.id_pedido from pedido ped JOIN mesa me on ped.id_mesa = me.id_mesa join cliente cl on ped.id_cliente = cl.id_cliente join usuario us on ped.id_cliente = cl.id_cliente and us.id_usuario = cl.id_usuario WHERE ped.estado = 'Activo'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            Dtpedido.DataSource = dt;

        }

        private void BtnPedidosActivos_Click(object sender, EventArgs e)
        {
            Dtpedido.Visible = true;
            DtPlatos.Visible = false;
            CargarPedidos();
            BtnPedidosActivos.Visible = false;
            BtnVolver.Visible = true;
            BtnIngresarPedido.Visible = false;

            CbxCategoria.Enabled = false;
            CbxPlato.Enabled = false;
            TxtCantidad.Enabled = false;
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Dtpedido.Columns.Clear();
          
            BtnPedidosActivos.Visible = true;
            BtnVolver.Visible = false;
            BtnIngresarPedido.Visible = true;
            DtPlatos.Visible = false;
            Dtpedido.Visible = true;

            Cbxid.Text = "";
            CbxPersonas.SelectedIndex = 0;
            CbxCategoria.SelectedIndex = 0;
            TxtCantidad.Text = "";
            CbxTotal.Text = "";
            TxtCliente.Text = "Ingrese un nombre para filtrar.";
            TxtCliente.ForeColor = Color.Gray;

            CbxIDplato.Text="";

            CbxCategoria.Enabled = false;
            CbxPlato.Enabled = false;
            TxtCantidad.Enabled = false;
        }

        private void BtnIngresarComanda_Click(object sender, EventArgs e)
        {
            Cbxid.Text="";
            CbxMesa.SelectedIndex=0;
            CbxCliente.SelectedIndex=0;
            TxtCantidad.Text = "";
            CbxTotal.Text = "";
            TxtCliente.Text = "Ingrese un nombre para filtrar.";
            TxtCliente.ForeColor = Color.Gray;

            CbxCategoria.SelectedIndex = 0;
            Dtpedido.Columns.Clear();
            DtPlatos.Visible = false;

            CbxCategoria.Enabled = false;
            CbxPlato.Enabled = false;
            TxtCantidad.Enabled = false;
        }

        private void Dtpedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dtpedido_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int FilaActual;
            FilaActual = Dtpedido.CurrentRow.Index;

            string nombre;
            nombre = Dtpedido.Rows[FilaActual].Cells[0].Value.ToString();
            TxtCliente.Text = nombre;

            string nro_mesa;
            nro_mesa = Dtpedido.Rows[FilaActual].Cells[1].Value.ToString();
            CbxMesa.Text = nro_mesa;

            string nro_personas;
            nro_personas = Dtpedido.Rows[FilaActual].Cells[2].Value.ToString();
            CbxPersonas.Text = nro_personas;

            string id;
            id = Dtpedido.Rows[FilaActual].Cells[3].Value.ToString();
            Cbxid.Text = id;


            BtnIngresarPedido.Visible = false;
            BtnAgregarPlato.Visible = true;
            BtnEliminarPlato.Visible = true;

            Dtpedido.Visible = false;
            DtPlatos.Visible = true;

            CargarPlatos(id);

            CbxCategoria.Enabled = true;
            CbxPlato.Enabled = true;
            TxtCantidad.Enabled = true;

        }

        private void DtPlatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void BtnEliminarPlato_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            CbxIDplato.Items.Clear();

            string message = "¿Estas seguro de eliminar el plato?.";
            string caption = "Eliminar plato.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                using (OracleCommand command = new OracleCommand("ELIMINAR_PEDIDOPLATO", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("V_ID", OracleDbType.Int32).Value = CbxIDplato.Text;
                    command.ExecuteNonQuery();
                    CargarPlatos(Cbxid.Text);
                }
            }
        }

        private void DtPlatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void DtPlatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;

            if (fila != -1)
            {
                string id_plato;
                id_plato = DtPlatos.Rows[fila].Cells[3].Value.ToString();
                CbxIDplato.Text = id_plato;

                string categoria;
                categoria = DtPlatos.Rows[fila].Cells[2].Value.ToString();
                CbxCategoria.SelectedValue = categoria;

                string plato;
                plato = DtPlatos.Rows[fila].Cells[1].Value.ToString();
                CbxIDplato.SelectedValue = plato;

                string cantidad;
                cantidad = DtPlatos.Rows[fila].Cells[4].Value.ToString();
                TxtCantidad.Text = cantidad;
            }

        }
    }
}
