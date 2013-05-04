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
using System.Windows.Shapes;

namespace CardCollection
{
    /// <summary>
    /// Interaction logic for NotesWindow.xaml
    /// </summary>
    public partial class NotesWindow : Window
    {
        public string notesText
        {
            get { return (string)this.DataContext; }
            set { this.DataContext = value; }
        }

        public NotesWindow()
        {
            InitializeComponent();
        }

        private void btnAddNotes_Click(object sender, RoutedEventArgs e)
        {
            if (tbNotes.Text != "")
            {
                //TODO insert notes to collectionDetails.notes member
            }
        }

        private void btnCancelNotes_Click(object sender, RoutedEventArgs e)
        {
            if (tbNotes.Text != "")
            {
                MessageBoxResult answer = MessageBox.Show
                    ("Save this note ?", "Save note", MessageBoxButton.OKCancel);

                if (answer == MessageBoxResult.OK)
                {
                    //TODO insert notes to collectionDetails.note member
                }
            }

            //TODO close dialogue
        }
    }
}
