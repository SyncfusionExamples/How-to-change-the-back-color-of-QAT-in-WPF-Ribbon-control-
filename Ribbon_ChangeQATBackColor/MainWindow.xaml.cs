using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Ribbonstatusbar_sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CmbTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbTheme.SelectedIndex == 1)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.SystemTheme);
            }
            else if (cmbTheme.SelectedIndex == 2)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.Office2016Colorful);
            }
            else if (cmbTheme.SelectedIndex == 3)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.Office2013DarkGray);
            }
            else if (cmbTheme.SelectedIndex == 4)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.MaterialDark);
            }
            else if (cmbTheme.SelectedIndex == 5)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.Office2019Colorful);
            }
            else if (cmbTheme.SelectedIndex == 6)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.MaterialLight);
            }
            else if (cmbTheme.SelectedIndex == 7)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.MaterialDarkBlue);
            }
            else if (cmbTheme.SelectedIndex == 8)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.Office2019HighContrast);
            }
            else if (cmbTheme.SelectedIndex == 9)
            {
                SfSkinManager.SetVisualStyle(this, VisualStyles.MaterialLight);
            }
        }
        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

    public class Model : NotificationObject
    {
        private string themeName;

        public string ThemeName
        {
            get { return themeName; }
            set { themeName = value; }
        }


    }


    public class ViewModel
    {
        public ViewModel()
        {
            Model m = new Model();
            m.ThemeName = "Material";


            themeList = new ObservableCollection<Model>();
            themeList.Add(new Model { ThemeName = "Default" });
            themeList.Add(new Model { ThemeName = "SystemTheme" });
            themeList.Add(new Model { ThemeName = "Office2016Colorful" });
            themeList.Add(new Model { ThemeName = "Office2013DarkGray" });
            themeList.Add(new Model { ThemeName = "MaterialDark" });
            themeList.Add(new Model { ThemeName = "Office2019Colorful" });
            themeList.Add(new Model { ThemeName = "MaterialLight" });
            themeList.Add(new Model { ThemeName = "MaterialDarkBlue" });
            themeList.Add(new Model { ThemeName = "Office2019HighContrast" });
            themeList.Add(new Model { ThemeName = "MaterialLight" });
            //ThemeList.Add("Material" );
            //ThemeList.Add( "OfficeColorful" );
            //ThemeList.Add(new Model { "Metro" );

        }

        private ObservableCollection<Model> themeList;

        public ObservableCollection<Model> ThemeList
        {
            get { return themeList; }
            set { themeList = value; }
        }
    }

}
