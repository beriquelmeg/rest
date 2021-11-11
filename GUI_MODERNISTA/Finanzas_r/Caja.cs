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

namespace Diseno
{
    public partial class Caja : MaterialForm
    {
        public Caja()
        {
            InitializeComponent();
            CbxPropina.SelectedIndex = 0;
            CbxTipoPago.SelectedIndex = 0;
            LblPersonal.Text = "Personal de venta: " + CacheInicioSesion.Nombres + " " + CacheInicioSesion.Apellidos;
            CargarPedidos();
            DtActivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CbxPropina.Enabled = false;
            CbxTipoPago.Enabled = false;
            Total_Efectivo();
            Total_Debito_Credito();
            Total_Transferencias();
            Total_Propinas();
        }

        //Listo
        private void CargarPedidos()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            DataTable dt = new DataTable();
            string query = "select us.nombres||' '||us.apellidos as nombre,me.nro_mesa,me.num_asientos as nro_personas,ped.id_pedido from pedido ped JOIN mesa me on ped.id_mesa = me.id_mesa join cliente cl on ped.id_cliente = cl.id_cliente join usuario us on ped.id_cliente = cl.id_cliente and us.id_usuario = cl.id_usuario WHERE ped.estado = 'Pagar'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter da = new OracleDataAdapter(command);
            da.Fill(dt);

            DtActivos.DataSource = dt;

        }
        private void Total_Efectivo()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            string query = "select sum(total) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY') and medio_pago = 'EFECTIVO'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtEfectivo.Text = "$ " + reg["Total"].ToString();

            }
        }

        private void Total_Debito_Credito()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            string query = "select sum(total) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY') and medio_pago = 'DEBITO/CREDITO'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtDebitoCredito.Text = "$ " + reg["Total"].ToString();

            }
        }

        private void Total_Transferencias()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            string query = "select sum(total) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY') and medio_pago = 'TRANSFERENCIA'";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtTransferencia.Text = "$ " + reg["Total"].ToString();

            }
        }

        private void Total_Propinas()
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();

            string query = "select sum(atencion) as total from boleta where to_char(fecha_hora,'DD-MON-YYYY') = TO_CHAR(SYSTIMESTAMP,'DD-MON-YYYY')";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                TxtPropinasDia.Text = "$ " + reg["Total"].ToString();

            }
        }

        string id;
        //Listo
        private void DtActivos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CbxPropina.Enabled = true;
            CbxTipoPago.Enabled = true;
            CbxTipoPago.SelectedIndex = 0;
            CbxPropina.SelectedIndex = 0;
            LblMesa.Text = "Mesa:";
            LblIDpedido.Text = "N° Pedido: ";
            TxtSubTotal.Text = "";
            TxtDcto.Text = "";
            TxtTotal.Text = "";
            TxtPropina.Text = "0";
            TxtMesa.Text = "";

            int fila = e.RowIndex;

            if (fila != -1)
            {
                string mesa;
                mesa = DtActivos.Rows[fila].Cells[1].Value.ToString();
                LblMesa.Text = "Mesa: " + mesa;

                string categoria;
                categoria = DtActivos.Rows[fila].Cells[3].Value.ToString();
                LblIDpedido.Text = "N° Pedido: " + categoria;

                string categoria2;
                categoria2 = DtActivos.Rows[fila].Cells[1].Value.ToString();
                TxtMesa.Text =  categoria2;

                string categoria1;
                categoria1 = DtActivos.Rows[fila].Cells[3].Value.ToString();
                TxtId.Text = categoria;

                id = DtActivos.Rows[fila].Cells[3].Value.ToString();

                TxtSubTotal.Text = sub_total(TxtId.Text);

            }
            
        }

        //Falta aplicar dcto
        private string sub_total (string id)
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();


            string query = "select SUM(ped.cantidad*pl.valor_plato) as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + id + " GROUP BY ped.id_pedido";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataReader reg = command.ExecuteReader();

            if (reg.Read())
            {
                return reg["Total"].ToString();
            }
            else
            {
                return "0";
            }
        }

        //Por terminar
        private void BtnPagar_Click(object sender, EventArgs e)
        {
            Acceso ac = new Acceso();
            var conn = ac.conectar();
            conn.Open();
            if (CbxPropina.SelectedIndex != 0)
            {
                if (CbxTipoPago.SelectedIndex != 0)
                {
                    if (TxtDcto.Text == "")
                    {
                        string message1 = "Debe declarar un descuento, si no se aplicara descuento indique 0.";
                        string title = "Error al pagar.";
                        MessageBox.Show(message1, title);
                    }
                    else
                    {

                        string message = "¿Estas seguro de agregar el pedido?.";
                        string caption = "Añadir pedido.";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result;

                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {

                            using (OracleCommand command = new OracleCommand("INSERTAR_BOLETA", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_SUBTOTAL", OracleDbType.Int32).Value = TxtSubTotal.Text;
                                command.Parameters.Add("V_PROPINA", OracleDbType.Int32).Value = TxtPropina.Text;
                                command.Parameters.Add("V_DCTO", OracleDbType.Int32).Value = TxtDcto.Text;
                                command.Parameters.Add("V_TOTAL", OracleDbType.Int32).Value = TxtTotal.Text;
                                command.Parameters.Add("V_PAGO", OracleDbType.Varchar2).Value = CbxTipoPago.Text;
                                command.Parameters.Add("V_ID_PEDIDO", OracleDbType.Int32).Value = TxtId.Text;


                                command.ExecuteNonQuery();


                            }

                            using (OracleCommand command = new OracleCommand("RETIRO_PEDIDO_MESA", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_ID_MESA", OracleDbType.Int32).Value = TxtMesa.Text;

                                command.ExecuteNonQuery();

                            }
                            using (OracleCommand command = new OracleCommand("TERMINO_PEDIDO", conn))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.Add("V_ID", OracleDbType.Int32).Value = TxtId.Text;

                                command.ExecuteNonQuery();

                            }

                            CbxTipoPago.SelectedIndex = 0;
                            CbxPropina.SelectedIndex = 0;
                            CbxTipoPago.Enabled = false;
                            CbxPropina.Enabled = false;
                            LblMesa.Text = "Mesa:";
                            LblIDpedido.Text = "N° Pedido: ";
                            TxtSubTotal.Text = "";
                            TxtDcto.Text = "";
                            TxtTotal.Text = "";
                            TxtPropina.Text = "0";
                            TxtMesa.Text = "";
                            TxtId.Text = "";
                            CargarPedidos();
                            id = "";
                            Total_Efectivo();
                            Total_Debito_Credito();
                            Total_Transferencias();
                            Total_Propinas();
                        }

                    }
                }
                else
                {
                    string message1 = "Debe Seleccionar un tipo de pago.";
                    string title = "Error al pagar.";
                    MessageBox.Show(message1, title);
                }
            }
            else
            {
                string message1 = "Debe Seleccionar si el cliente desea agregar propina";
                string title = "Error al pagar.";
                MessageBox.Show(message1, title);
            }
        }

        //Listo
        private void CbxPropina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CbxPropina.SelectedIndex == 1)
            {
                Acceso ac = new Acceso();
                var conn = ac.conectar();
                conn.Open();


                string query = "select (SUM(ped.cantidad*pl.valor_plato))*1.1 as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + TxtId.Text + " GROUP BY ped.id_pedido";
                OracleCommand command = new OracleCommand(query, conn);
                OracleDataReader reg = command.ExecuteReader();

                if (reg.Read())
                {
                    TxtTotal.Text = reg["Total"].ToString();

                }
                else
                {
                    TxtTotal.Text= "0";
                }


                string query1 = "select (SUM(ped.cantidad*pl.valor_plato))*0.1 as Total from pedidoplato ped join plato pl on pl.id_plato = ped.id_plato WHERE ped.id_pedido = " + TxtId.Text + " GROUP BY ped.id_pedido";
                OracleCommand commandd = new OracleCommand(query1, conn);
                OracleDataReader reg1 = commandd.ExecuteReader();
                if (reg1.Read())
                {
                    TxtPropina.Text = reg1["Total"].ToString();

                }
                else
                {
                    TxtPropina.Text = "0" ;
                }
            }
            else
            {
                TxtTotal.Text = TxtSubTotal.Text;
            }
            if (CbxPropina.SelectedIndex == 2)
            {
                TxtPropina.Text = "0";
            }
        }
    }
}
