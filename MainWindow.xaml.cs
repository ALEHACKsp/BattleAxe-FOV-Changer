using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BattleAxe_FOV_Changer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void applyFOV_Click(object sender, RoutedEventArgs e)
        {
            string resolutionText = FOV.applyFOV(fovOption.Text, (bool)readOnly.IsChecked);
            if(resolutionText == "0")
            {
                string messageError = "Error: Please select a FOV";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = System.Windows.Forms.MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            } else if(resolutionText == "1")
            {
                string messageError = "Error: Fortnite installation could not be found";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = System.Windows.Forms.MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            } else
            {
                resolution.Document.Blocks.Clear();
                resolution.Document.Blocks.Add(new Paragraph(new Run()));
            }
        }

        private void backupINI_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FOV.backupFOV();
                string messageError = "Successfully backed-up file";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = System.Windows.Forms.MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            } catch (Exception error)
            {
                string messageError = "Error: Failed to backup file";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = System.Windows.Forms.MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            }
        }

        private void openConfig_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(FOV.getOpenFolderPath());
            } catch
            {
                string messageError = "Error: Failed to open folder";
                MessageBoxButtons buttonsError = MessageBoxButtons.OK;
                DialogResult resultError;
                resultError = System.Windows.Forms.MessageBox.Show(messageError, "Error", buttonsError, MessageBoxIcon.Error);
            }
        }
    }
}
