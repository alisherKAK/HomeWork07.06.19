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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork07_06_19
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AnimationStartButtonClick(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = processRectangle.Width;
            animation.To = processBarRectangle.Width - 30;
            animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            animation.Completed += new EventHandler(AnimationCompleted);

            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(animation);
            Storyboard.SetTargetName(animation, processRectangle.Name);
            Storyboard.SetTargetProperty(animation, new PropertyPath(WidthProperty));

            storyboard.Begin(this);
        }

        private void AnimationCompleted(object sender, EventArgs e)
        {
            MessageBox.Show("Process finished");
        }
    }
}
