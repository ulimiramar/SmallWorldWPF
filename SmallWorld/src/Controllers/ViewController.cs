using SmallWorld.src.Interfaces;
using SmallWorld.src.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallWorld.src.Controllers
{
    internal class ViewController
    {
        private static ViewController instance;
        private Random random = new Random();
        private ViewController() { }

        public static ViewController GetInstance()
        {
            if (instance == null)
            {
                instance = new ViewController();
            }
            return instance;
        }

        public void FillListControlWithImplementations(ListControl control, Type interfaceType)
        {
            var types = Assembly.GetExecutingAssembly().GetTypes()
                                .Where(type => interfaceType.IsAssignableFrom(type) && !type.IsInterface);

            foreach (var type in types)
            {
                object instance = Activator.CreateInstance(type);

                if (control is ComboBox comboBox)
                {
                    comboBox.Items.Add(instance);
                }
                else if (control is CheckedListBox checkedListBox)
                {
                    checkedListBox.Items.Add(instance);
                }
            }
        }

        //lógica para marcar al menos un checkbox aleatorios y luego los demás aleatorios
        public void CheckRandomItemsInClbControl(CheckedListBox checkedListBox)
        {
            int randomIndex = random.Next(0, checkedListBox.Items.Count);
            checkedListBox.SetItemChecked(randomIndex, true);
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (i == randomIndex)
                {
                    continue; // Salta el elemento que ya marcamos aleatoriamente
                }
                bool isChecked = random.Next(0, 2) == 1; // Genera 0 o 1 aleatoriamente
                checkedListBox.SetItemChecked(i, isChecked);
            }
        }
        public void SelectRandomItemInComboBox(ComboBox comboBox)
        {
            int randomKingdomIndex = random.Next(0, comboBox.Items.Count);
            comboBox.SelectedIndex = randomKingdomIndex;
        }

        public string GetRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void ClearCheckedListBox(CheckedListBox checkedListBox)
        {
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                checkedListBox.SetItemChecked(i, false);
            }
        }


        //TODO: hacer función para checkear los items en el clbControl con la información del objeto a modificar
        //public void CheckItemsInClbControl(CheckedListBox checkedListBox, Type interfaceType)

    }
}