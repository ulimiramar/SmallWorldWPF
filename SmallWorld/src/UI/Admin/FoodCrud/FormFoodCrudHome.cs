using SmallWorld.src.Controllers;
using SmallWorld.src.Model.Interactuable;
using SmallWorld.src.UI.Admin.EntityCrud;
using SmallWorld.src.UI.Admin.FoodCrud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.UI.Admin
{
    public partial class FormFoodCrudHome : Form
    {
        private FoodController foodController = FoodController.GetInstance();
        public FormFoodCrudHome()
        {
            InitializeComponent();
            
            

            // Crea una columna para la lista de dietas
            DataGridViewTextBoxColumn dietColumn = new DataGridViewTextBoxColumn();
            dietColumn.DataPropertyName = "Diet"; // Debe coincidir con el nombre de la propiedad
            dietColumn.HeaderText = "Dietas";

            // Agrega la columna al DataGridView
            dgvFood.Columns.Add(dietColumn);
            RefreshDataGridFood();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            new FormCreateFood().ShowDialog();
            RefreshDataGridFood();
        }
        private void RefreshDataGridFood()
        {
            bsFood.DataSource = foodController.getFoods();
            bsFood.ResetBindings(false);
            dgvFood.DataSource = bsFood;
        }


        //TODO: 1. arreglar esto que muestra en la columna dietas la palabra colección, y arreglar que esa columna vaya a un costado y no primera
        
        //posición de la columna
        int dietListColumnIndex = 1;

        private void dgvFood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dietListColumnIndex && e.RowIndex >= 0)
            {
                // Obtiene el valor de la celda
                object cellValue = dgvFood[e.ColumnIndex, e.RowIndex].Value;

                // Verifica si el valor es una colección (por ejemplo, List<string>)
                if (cellValue is IEnumerable<string> dietList)
                {
                    // Convierte la colección en una cadena separada por comas
                    string dietListString = string.Join(", ", dietList);

                    // Establece el valor formateado en la celda
                    e.Value = dietListString;

                    // Marca la celda como formateada
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
