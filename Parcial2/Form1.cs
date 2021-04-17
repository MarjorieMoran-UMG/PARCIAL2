using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2.Clases;

namespace Parcial2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\Marjorie\Desktop\Practica";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                textBoxResultados.Text = resultado;
            }
        }

        private void buttonPromedioPorParcial_Click(object sender, EventArgs e)
        {
            ClsPromedio prommm = new ClsPromedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }
            int promediop1 = prommm.promedios_por_parcial(ArregloDosDimensiones, enumColumnas.Parcial1);
            listBoxArchivo.Items.Add($"Promedio de Primer Parcial : {promediop1}");
            int promediop2 = prommm.promedios_por_parcial(ArregloDosDimensiones, enumColumnas.Parcial2);
            listBoxArchivo.Items.Add($"Promedio de Segundo Parcial : {promediop2}");
            int promediop3 = prommm.promedios_por_parcial(ArregloDosDimensiones, enumColumnas.Parcial3);
            listBoxArchivo.Items.Add($"Promedio de Tercer Parcial : {promediop3}");
        }

        private void buttonPromedioPorSeccion_Click(object sender, EventArgs e)
        {
            Limpiar();
            ClsPromedio prommm = new ClsPromedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }

            int PromP1SecA = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial1, "A");
            int PromP2SecA = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial2, "A");
            int PromP3SecA = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial3, "A");
            int PromP1SecB = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial1, "B");
            int PromP2SecB = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial2, "B");
            int PromP3SecB = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial3, "B");
            int PromP1SecC = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial1, "C");
            int PromP2SecC = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial2, "C");
            int PromP3SecC = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial3, "C");
            int PromP1SecD = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial1, "D");
            int PromP2SecD = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial2, "D");
            int PromP3SecD = prommm.promedios_por_seccion(ArregloDosDimensiones, enumColumnas.Parcial3, "D");

            listBoxArchivo.Items.Add("Sección A:");
            listBoxArchivo.Items.Add($"Parcial 1: {PromP1SecA}");
            listBoxArchivo.Items.Add($"Parcial 2: {PromP2SecA}");
            listBoxArchivo.Items.Add($"Parcial 3: {PromP3SecA}");

            listBoxArchivo.Items.Add("Sección B:");
            listBoxArchivo.Items.Add($"Parcial 1: {PromP1SecB}");
            listBoxArchivo.Items.Add($"Parcial 2: {PromP2SecB}");
            listBoxArchivo.Items.Add($"Parcial 3: {PromP3SecB}");

            listBoxArchivo.Items.Add("Sección C:");
            listBoxArchivo.Items.Add($"Parcial 1: {PromP1SecC}");
            listBoxArchivo.Items.Add($"Parcial 2: {PromP1SecC}");
            listBoxArchivo.Items.Add($"Parcial 3: {PromP1SecC}");

            listBoxArchivo.Items.Add("Sección D:");
            listBoxArchivo.Items.Add($"Parcial 1: {PromP1SecD}");
            listBoxArchivo.Items.Add($"Parcial 2: {PromP1SecD}");
            listBoxArchivo.Items.Add($"Parcial 3: {PromP1SecD}");
        }

        private void Limpiar()
        {
            listBoxArchivo.Items.Clear();
        }

        private void buttonPromedioGeneralSeccion_Click(object sender, EventArgs e)
        {
            Limpiar();
            ClsPromedio prommm = new ClsPromedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }

            int PromGeneralSecA = prommm.promedios_general_seccion(ArregloDosDimensiones, "A");
            int PromGeneralSecB = prommm.promedios_general_seccion(ArregloDosDimensiones, "B");
            int PromGeneralSecC = prommm.promedios_general_seccion(ArregloDosDimensiones, "C");
            int PromGeneralSecD = prommm.promedios_general_seccion(ArregloDosDimensiones, "D");

            listBoxArchivo.Items.Add("Promedios Generales:");
            listBoxArchivo.Items.Add($"Sección A: {PromGeneralSecA}");
            listBoxArchivo.Items.Add($"Sección B: {PromGeneralSecB}");
            listBoxArchivo.Items.Add($"Sección C: {PromGeneralSecC}");
            listBoxArchivo.Items.Add($"Sección D: {PromGeneralSecD}");
        }

        private void buttonNotaMayorEnGeneral_Click(object sender, EventArgs e)
        {
            Limpiar();
            ClsPromedio Nota = new ClsPromedio();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }
            int Mayor = Nota.nombre_nota_mayor(ArregloDosDimensiones, ArregloNotas);
            listBoxArchivo.Items.Add($"Mejor Promedio: {Mayor}");
        }

        private void buttonNombreAlumnosySeccion_Click(object sender, EventArgs e)
        {
            Limpiar();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
                listBoxArchivo.Items.Add($"{datosUnitarios[enumColumnas.Nombre]} -- {datosUnitarios[enumColumnas.Seccion]}");
            }
        }
    }
}
