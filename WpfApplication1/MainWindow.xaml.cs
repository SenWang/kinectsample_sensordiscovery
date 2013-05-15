using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;

namespace WpfApplication1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(MainWindow_Loaded);
            Unloaded += new RoutedEventHandler(MainWindow_Unloaded);
        }
        void MainWindow_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }
        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
        }

        void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            string info = "狀態: " + e.Status + " , 感應器ID: " + e.Sensor.UniqueKinectId
                + " , USB裝置連接識別碼(USB connector ID): " + e.Sensor.DeviceConnectionId;
            TextBlock tb = new TextBlock()
            {
                Text = info
            };
            status.Items.Add(tb) ;
        }

    }
}
