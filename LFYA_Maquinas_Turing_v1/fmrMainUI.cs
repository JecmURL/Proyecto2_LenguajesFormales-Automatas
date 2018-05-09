using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LFYA_Maquinas_Turing_v1
{
    public partial class frmMainUI : Form
    {
        public frmMainUI()
        {
            InitializeComponent();
        }

        //pinta en data grid view
        public void PintarDataGrid(char[] cadena, int cursor) {
            dgvOutput.Rows.Clear();
            dgvOutput.Columns.Clear();
            dgvOutput.Refresh();

            dgvOutput.ColumnCount = cadena.Length;
            dgvOutput.Rows.Add();

            for (int i = 0; i < cadena.Length; i++)
            {
                dgvOutput[i,0].Value = cadena[i];
            }

            bool parche = true;
            int i_parche = cursor;
            if (cursor < 0)
            {
                i_parche = cursor;
                cursor = 0;
            }

            dgvOutput[cursor, 0].Style.BackColor = Color.Red;

            lblCounterSteps.Text = stepCounter.ToString();

            dgvOutput.Refresh();
            System.Threading.Thread.Sleep(500);

            if (parche)
                cursor = i_parche;
            
        }

        //agrega B al final del string
        public string agregarB(char[] palabras) {
            string res = "";
            for (int i = 0; i < palabras.Length; i++)
            {
                res += palabras[i];
            }

            res = res + "B";
            return res;
        }
        

        //manda a llamar la maquina de estado correspondiente
        public int Ejecutar(string cadena, int mt_option)
        {
            switch (mt_option)
            {
                case 0: //Suma
                    return mt_suma(cadena);

                case 1://Resta
                    return mt_resta(cadena);

                case 2://Multiplicacion
                    return mt_multiplicacion(cadena);

                case 3://Palindromos
                    return mt_palindromos(cadena);

                case 4://Copia Cadena
                    return mt_copiaPatron(cadena);
                default:
                    return -1;
            }

        }

        public int stepCounter = 0;

        private int mt_palindromos(string input) {
            int res = -1;

            input = "B" + input + "B";

            char[] cadena = input.ToCharArray();

            int puntero = 1;
            int estado = 0;
            bool ejecucion = true;

            PintarDataGrid(cadena, puntero - 1);

            stepCounter = 0;

            while (ejecucion)
            {
                stepCounter++;
                switch (estado)
                {
                    case 0:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 1;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 2;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 3;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 11;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 1:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 4;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 4;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 4;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 11;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 2:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 5;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 5;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 5;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 11;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 3:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 6;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 6;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 6;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 11;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 4:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 4;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 4;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 4;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 7;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 5:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 5;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 5;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 5;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 8;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 6:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 6;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 6;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 6;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 9;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 7:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 10;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 8:
                        {
                            if (cadena[puntero] == 'b')
                            {
                                estado = 10;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 9:
                        {
                            if (cadena[puntero] == 'c')
                            {
                                estado = 10;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 10:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 10;
                                cadena[puntero] = 'a';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 10;
                                cadena[puntero] = 'b';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 10;
                                cadena[puntero] = 'c';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 0;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                                estado = -1;
                            break;
                        }
                    case 11:
                        {
                            res = 1;
                            ejecucion = false;
                            PintarDataGrid(cadena, puntero - 1);
                            break;
                        }

                    default:
                        res = 0;
                        ejecucion = false;
                        break;
                }

            }

            return res;
        }

        private int mt_suma(string input)
        {
            int res = -1;
            input = "B" + input + "=B";

            char[] cadena = input.ToCharArray();

            int puntero = 1;
            int estado = 0;
            bool ejecucion = true;

            PintarDataGrid(cadena, puntero-1);

            stepCounter = 0;

            while (ejecucion)
            {
                stepCounter++;
                switch (estado)
                {
                    case 0:
                        {
                            if (cadena[puntero] == '1')
                            {
                                cadena[puntero] = 'B';
                                puntero++;
                                estado = 1;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '+')
                            {
                                cadena[puntero] = 'B';
                                puntero++;
                                estado = 0;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B' || cadena[puntero] == '=')
                            {
                                cadena[puntero] = 'B';
                                puntero++;
                                estado = 3;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else {
                                estado = -1;
                            }
                            break;
                        }

                    case 1:
                        {
                            if (cadena[puntero] == '1')
                            {
                                cadena[puntero] = '1';
                                puntero++;
                                estado = 1;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '+')
                            {
                                cadena[puntero] = '+';
                                puntero++;
                                estado = 1;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                cadena[puntero] = '=';
                                puntero++;
                                estado = 1;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                cadena[puntero] = '1';
                                puntero--;

                                input = agregarB(cadena);
                                cadena = input.ToCharArray();

                                estado = 2;

                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (cadena[puntero] == '1')
                            {
                                cadena[puntero] = '1';
                                puntero--;
                                estado = 2;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '+')
                            {
                                cadena[puntero] = '+';
                                puntero--;
                                estado = 2;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                cadena[puntero] = '=';
                                puntero--;
                                estado = 2;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                cadena[puntero] = 'B';
                                puntero++;
                                estado = 0;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 3:
                        {
                            res = 1;
                            ejecucion = false;
                            PintarDataGrid(cadena, puntero - 1);
                            break;
                        }
                    default:
                        res = 0;
                        ejecucion = false;
                        break;
                }
            }
            
            return res;
        }

        private int mt_resta(string input)
        {
            int res = -1;
            input = input.Replace('-', '0');

            input = "B" + input + "B";

            char[] cadena = input.ToCharArray();

            int puntero = 1;
            int estado = 0;
            bool ejecucion = true;

            PintarDataGrid(cadena, puntero - 1);

            stepCounter = 0;

            while (ejecucion)
            {
                stepCounter++;
                switch (estado)
                {
                    case 0:
                        {
                            if (cadena[puntero] == '0')
                            {
                                estado = 5;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '1')
                            {
                                estado = 1;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }

                    case 1:
                        {
                            if (cadena[puntero] == '0')
                            {
                                estado = 1;
                                cadena[puntero] = '0';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '1')
                            {
                                estado = 1;
                                cadena[puntero] = '1';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 2;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (cadena[puntero] == '0')
                            {
                                estado = 4;
                                cadena[puntero] = '1';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '1')
                            {
                                estado = 3;
                                cadena[puntero] = 'B';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (cadena[puntero] == '0')
                            {
                                estado = 3;
                                cadena[puntero] = '0';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '1')
                            {
                                estado = 3;
                                cadena[puntero] = '1';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 0;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 4:
                        {
                            res = 1;
                            ejecucion = false;
                            PintarDataGrid(cadena, puntero - 1);
                            break;
                        }
                    case 5:
                        {
                            if (cadena[puntero] == '1')
                            {
                                estado = 5;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 6;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 6:
                        {
                            res = 2;
                            ejecucion = false;
                            PintarDataGrid(cadena, puntero - 1);
                            break;
                        }
                    default:
                        res = 0;
                        ejecucion = false;
                        break;
                }
            }

            return res;
        }

        private int mt_multiplicacion(string input)
        {
            int res = -1;

            input = "B" + input + "=B";

            char[] cadena = input.ToCharArray();

            int puntero = 1;
            int estado = 0;
            bool ejecucion = true;

            PintarDataGrid(cadena, puntero - 1);

            stepCounter = 0;

            while (ejecucion)
            {
                stepCounter++;
                switch (estado)
                {
                    case 0:
                        {
                            if (cadena[puntero] == '1')
                            {
                                estado = 1;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '*')
                            {
                                estado = 0;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                estado = 5;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (cadena[puntero] == '1')
                            {
                                estado = 1;
                                cadena[puntero] = '1';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '*')
                            {
                                estado = 2;
                                cadena[puntero] = '*';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                estado = 4;
                                cadena[puntero] = '=';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (cadena[puntero] == '1')
                            {
                                estado = 3;
                                cadena[puntero] = 'A';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                estado = 4;
                                cadena[puntero] = '=';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (cadena[puntero] == '1')
                            {
                                estado = 3;
                                cadena[puntero] = '1';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '*')
                            {
                                estado = 3;
                                cadena[puntero] = '*';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                estado = 3;
                                cadena[puntero] = '=';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 4;
                                cadena[puntero] = '1';
                                puntero--;

                                input = agregarB(cadena);
                                cadena = input.ToCharArray();

                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (cadena[puntero] == '1')
                            {
                                estado = 4;
                                cadena[puntero] = '1';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '*')
                            {
                                estado = 4;
                                cadena[puntero] = '*';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == '=')
                            {
                                estado = 4;
                                cadena[puntero] = '=';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 0;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'A')
                            {
                                estado = 2;
                                cadena[puntero] = '1';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 5:
                        {
                            res = 1;
                            ejecucion = false;
                            PintarDataGrid(cadena, puntero - 1);
                            break;
                        }
                    default:
                        res = 0;
                        ejecucion = false;
                        break;
                }
            }

            return res;
        }

        private int mt_copiaPatron(string input)
        {
            int res = -1;

            input = "B" + input + "B";

            char[] cadena = input.ToCharArray();

            int puntero = 1;
            int estado = 0;
            bool ejecucion = true;

            PintarDataGrid(cadena, puntero - 1);

            stepCounter = 0;

            while (ejecucion)
            {
                stepCounter++;
                switch (estado)
                {
                    case 14:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 14;
                                cadena[puntero] = 'a';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 14;
                                cadena[puntero] = 'b';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 14;
                                cadena[puntero] = 'c';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 1;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 0:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 0;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 0;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 0;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 14;
                                cadena[puntero] = 'y';
                                input = agregarB(cadena);
                                cadena = input.ToCharArray();
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 1:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 2;
                                cadena[puntero] = 'x';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 3;
                                cadena[puntero] = 'x';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 4;
                                cadena[puntero] = 'x';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 8;
                                cadena[puntero] = 'y';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 2;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 2;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 2;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 5;
                                cadena[puntero] = 'a';
                                puntero--;
                                input = agregarB(cadena);
                                cadena = input.ToCharArray();
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 2;
                                cadena[puntero] = 'y';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 3;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 3;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 3;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 6;
                                cadena[puntero] = 'b';
                                puntero--;
                                input = agregarB(cadena);
                                cadena = input.ToCharArray();
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 3;
                                cadena[puntero] = 'y';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 4;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 4;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 4;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 7;
                                cadena[puntero] = 'c';
                                puntero--;
                                input = agregarB(cadena);
                                cadena = input.ToCharArray();
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 4;
                                cadena[puntero] = 'y';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 5;
                                cadena[puntero] = 'a';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 5;
                                cadena[puntero] = 'b';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 5;
                                cadena[puntero] = 'c';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'x')
                            {
                                estado = 1;
                                cadena[puntero] = 'a';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 5;
                                cadena[puntero] = 'y';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 6:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 6;
                                cadena[puntero] = 'a';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 6;
                                cadena[puntero] = 'b';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 6;
                                cadena[puntero] = 'c';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'x')
                            {
                                estado = 1;
                                cadena[puntero] = 'b';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 6;
                                cadena[puntero] = 'y';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 7:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 7;
                                cadena[puntero] = 'a';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 7;
                                cadena[puntero] = 'b';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 7;
                                cadena[puntero] = 'c';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'x')
                            {
                                estado = 1;
                                cadena[puntero] = 'c';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 7;
                                cadena[puntero] = 'y';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 8:
                        {
                            if (cadena[puntero] == 'a')
                            {
                                estado = 9;
                                cadena[puntero] = 'y';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'b')
                            {
                                estado = 10;
                                cadena[puntero] = 'y';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'c')
                            {
                                estado = 11;
                                cadena[puntero] = 'y';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'B')
                            {
                                estado = 12;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else if (cadena[puntero] == 'y')
                            {
                                estado = 8;
                                cadena[puntero] = 'y';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 9:
                        {
                            if (cadena[puntero] == 'y')
                            {
                                estado = 8;
                                cadena[puntero] = 'a';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 10:
                        {
                            if (cadena[puntero] == 'y')
                            {
                                estado = 8;
                                cadena[puntero] = 'b';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 11:
                        {
                            if (cadena[puntero] == 'y')
                            {
                                estado = 8;
                                cadena[puntero] = 'c';
                                puntero--;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 12:
                        {
                            if (cadena[puntero] == 'y')
                            {
                                estado = 13;
                                cadena[puntero] = 'B';
                                puntero++;
                                PintarDataGrid(cadena, puntero - 1);
                            }
                            else
                            {
                                estado = -1;
                            }
                            break;
                        }
                    case 13:
                        {
                            res = 1;
                            ejecucion = false;
                            PintarDataGrid(cadena, puntero - 1);
                            break;
                        }

                    default:
                        res = 0;
                        ejecucion = false;
                        break;
                }
            }

            return res;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una cadena valida.", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Focus();
            }
            else
            {
                //Ejecutar devolvera 0 = No Acepta, 1 = Acepta, -1 = Error
                switch (Ejecutar(txtInput.Text, cmbMT.SelectedIndex))
                {
                    case 1:
                        {
                            MessageBox.Show("Cadena procesada y aceptada.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    case 0:
                        {
                            MessageBox.Show("Cadena NO procesada, no es aceptada por la MT.", "No aceptada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    case 2:
                        {
                            MessageBox.Show("Cadena procesada y aceptada. Esta es una resta tipo M-N donde M <= N, el resultado queda como 0.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Cadena No procesada, hubo un error.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                }
                
            }
        }

        private void cmbMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtInput.Visible = true;
            lblText.Visible = true;
            lblWarning.Visible = true;
            btnStart.Visible = true;

            switch (cmbMT.SelectedIndex)
            {
                case 0:
                    lblWarning.Text = "Los simbolos aceptados son unarios. \r\nEj: 11+111";
                    break;
                case 1:
                    lblWarning.Text = "Los simbolos aceptados son unarios. \r\nEj: 111-11";
                    break;
                case 2:
                    lblWarning.Text = "Los simbolos aceptados son unarios. \r\nEj: 11*111";
                    break;
                case 3:
                    lblWarning.Text = "Los simbolos aceptados son a,b,c. \r\nEj: abcba";
                    break;
                case 4:
                    lblWarning.Text = "Los simbolos aceptados son a,b,c. \r\nEj: abc";
                    break;
                default:
                    break;
            }

            txtInput.Focus();
        }
    }
}
