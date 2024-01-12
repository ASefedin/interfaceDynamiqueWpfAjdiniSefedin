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

namespace devoirClasse
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ///instanciation
            ColumnDefinition coldef1 = new ColumnDefinition();
            ColumnDefinition coldef2 = new ColumnDefinition();
            ColumnDefinition coldef3 = new ColumnDefinition();
            grdMain.ColumnDefinitions.Add(coldef1);
            grdMain.ColumnDefinitions.Add(coldef2);
            grdMain.ColumnDefinitions.Add(coldef3);

            RowDefinition rowDef1 = new RowDefinition();
            RowDefinition rowDef2 = new RowDefinition();
            RowDefinition rowDef3 = new RowDefinition();
            grdMain.RowDefinitions.Add(rowDef1);
            grdMain.RowDefinitions.Add(rowDef2);
            grdMain.RowDefinitions.Add(rowDef3);

            ///haut de page
            TextBlock txtAMonTexte = new TextBlock();
            Grid.SetColumn(txtAMonTexte, 0);
            txtAMonTexte.Background = Brushes.Yellow;
            txtAMonTexte.Foreground = Brushes.Red;
            txtAMonTexte.Text = "TextBlock créé dynamique";
            txtAMonTexte.FontWeight = FontWeights.Bold;
            Grid.SetColumnSpan(txtAMonTexte, 3);
            grdMain.Children.Add(txtAMonTexte);



            ///marginHaut
            Thickness myThickness = new Thickness();
            myThickness.Bottom = 130;
            myThickness.Top = 130;
            txtAMonTexte.Margin = myThickness;

            ///bouton

            Button btn1 = new Button();
            btn1.Content = "BOUTON 1";
            btn1.Height = 300;
            btn1.Width = 300;
            Grid.SetRow(btn1, 1);
            Grid.SetColumn(btn1, 0);
            grdMain.Children.Add(btn1);

            Button btn2 = new Button();
            btn2.Content = "BOUTON 2";
            btn2.Height = 300;
            btn2.Width = 300;
            Grid.SetRow(btn2, 1);
            Grid.SetColumn(btn2, 1);
            grdMain.Children.Add(btn2);

            Button btn3 = new Button();
            btn3.Content = "BOUTON 3";
            btn3.Height = 300;
            btn3.Width = 300;
            Grid.SetRow(btn3, 1);
            Grid.SetColumn(btn3, 2);
            grdMain.Children.Add(btn3);

            ///bas de page
            TextBlock txtBMonTexte = new TextBlock();
            Grid.SetColumn(txtAMonTexte, 0);
            txtBMonTexte.Background = Brushes.Yellow;
            txtBMonTexte.Text = "Infos :";
            Grid.SetColumnSpan(txtBMonTexte, 2);
            Grid.SetRow(txtBMonTexte, 2);
            grdMain.Children.Add(txtBMonTexte);

            ///marginBas
            txtBMonTexte.Margin = myThickness;
            

            TextBox txtDonnees = new TextBox();
            txtDonnees.Text = "J'attend vos infos  :";
            grdMain.Children.Add(txtDonnees);
            Grid.SetColumnSpan(txtDonnees, 2);
            Grid.SetRow(txtDonnees, 2);

            ///marginBass
            Thickness myThickness1 = new Thickness();
            myThickness1.Bottom = 130;
            myThickness1.Top = 190;
            txtDonnees.Margin = myThickness1;

            ///checkBox
            ComboBox chkBoite = new ComboBox();
            Grid.SetRow(chkBoite, 2);
            Grid.SetColumn(chkBoite, 2);
            chkBoite.Height = 150;
            chkBoite.Width = 150;
            chkBoite.Items.Add("coucou");
            chkBoite.Items.Add("coucou2");
            grdMain.Children.Add(chkBoite);
            

        }
    }
}
