using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using DeviceInfoTest.Resources;

namespace DeviceInfoTest
{
    using System.Windows.Input;

    using Microsoft.Phone.Info;
    using Microsoft.Phone.Net.NetworkInformation;

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            MnoName.Text = "MNO Name: " + DeviceNetworkInformation.CellularMobileOperator;
            HandsetManufacturer.Text = "Handset Manufacturer: " + DeviceStatus.DeviceManufacturer;
            ActualOsVersion.Text = "Actual OS Version: " + Environment.OSVersion.Version;
            HandsetModel.Text = "HandsetModel: " + DeviceStatus.DeviceName;
        }
    }
}