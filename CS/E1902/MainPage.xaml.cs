using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Q386075 {
    public partial class MainPage: UserControl {
        public MainPage() {
            InitializeComponent();
        }
        private void showPopup(object sender, RoutedEventArgs e) {
            popupWindow.Show();
        }
        private void popupWindow_Closed(object sender, EventArgs e) {
            popupWindow.ShowAnimation.Stop();
            popupWindow.HideAnimation.Stop();
        }
        private void closePopup(object sender, RoutedEventArgs e) {
            popupWindow.Hide();
        }
    }
}