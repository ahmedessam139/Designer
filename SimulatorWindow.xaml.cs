using System;
using System.Collections.Generic;
using System.Windows;
using System.Activities.Presentation.Services;
using System.Activities.Presentation.Model;
using System.Activities.Presentation.View;
using System.Activities.Presentation.Debug;
using System.Activities;

namespace Business.WorkflowDebugger
{
    /// <summary>
    /// Interaction logic for SimulatorWindow.xaml
    /// </summary>
    public partial class SimulatorWindow : Window
    {
        public SimulatorWindow()
        {
            InitializeComponent();
        }
   
        private void btnRunLoadedWorkflow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.RunWorkflow();
            }
            catch (Exception ex) 
            {
                System.Windows.MessageBox.Show(ex.Message, "Errorr", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void fileMenuExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void fileMenuItem_Click_LoadWorkflow(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog(this).Value)
            {
                WFHost.WorkflowFilePath = openFileDialog.FileName;
                WFHost.AddWorkflowDesigner(); 

            }
        }

        private void WFHost_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaveWorkflow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.SaveWorkflow();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnNewWorkflow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.NewWorkflow();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnOpenWorkflow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.OpenWorkflow();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnFastRunWorkflow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.FastRunWorkflow();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnBreakpointToggle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.BreakPointToggle();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost._continue();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnStopDep_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                WFHost.Stop();
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
