using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace TourManagerDesktopV2.Views
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public string stringProperty { get; set; }

        private void InitializeComponent()
        {
            AddButton();
            AvaloniaXamlLoader.Load(this);
            
        }


        private void AddButton() 
        {

          

            Button button = new Button();
            button.Content = "dfs";

            this.LogicalChildren.Add(button);

            

            
        }
    }
}
