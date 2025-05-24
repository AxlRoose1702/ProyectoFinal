using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Datos;
using ProyectoFinal.Logica;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmPagos : Form
    {
        CDPago cd_pago = new CDPago();
        CLPago cl_pago = new CLPago();

        private void MtdMostrarListaReservaciones()
        {
            var ListaReservaciones = cd_pago.MtdListaReservaciones();

            foreach (var Reservaciones in ListaReservaciones)
            {
                cboxReserva.Items.Add(Reservaciones);
            }

            cboxReserva.DisplayMember = "Text";
            cboxReserva.ValueMember = "Value";
        }

        public FrmPagos()
        {
            InitializeComponent();
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            MtdMostrarListaReservaciones();
        }

        private void cboxReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMonto.Text = cd_pago.MtdMontoReserva(Convert.ToDouble(cboxReserva.ValueMember = "Value")).ToString();  
        }
    }
}
