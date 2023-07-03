using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace POE_multiple_windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public List<Recipe> students = new List<Recipe>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Recipe() { Name=txtName.Text, Ingredient= txtIngredient.Text, foodGroup = txtfoodGroup.Text, calories = double.Parse(txtScore.Text)});
            txtName.Text = "";
            txtIngredient.Text = "";
            txtfoodGroup.Text = "";
            txtcalories.Text = "";
            txtName.Focus();
        }

        private void btnDisplay_Click(object sender, RoutedEventArgs e)
        {
            lstDisplay.Items.Clear();
            foreach (Recipe recipe in recipe)
            {
                lstDisplay.Items.Add(recipe.Name);
            }
        }

        private void btnAdjust_Click(object sender, RoutedEventArgs e)
        {
            AdjustWindow adjustWindow = new AdjustWindow();
            adjustWindow.studentsCopy.AddRange(Recipe);
            adjustWindow.Show();
        }

        private void lstDisplay_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (Recipe recipe in students)
            {
                if(lstDisplay.SelectedItem.ToString().Equals(recipe.Name))
                {
                    lstDispayAll.Items.Add(recipe.Name+ "-" + recipe.ingredient+"-"+ recipe.foodGroup + "-"+ recipe.calories);
                    MessageBox.Show(recipe.Name + "-" + recipe.ingredient + "-" + recipe.foodGroup + "-" + recipe.calories);
                }
            }
        }
    }
}
