using System;
using System.Windows;
using System.Windows.Controls;

namespace CardCollection
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Boolean formUpdated;
        Boolean movedBack;

        Classes.Collection collectionDetails;

        public MainWindow()
        {
            InitializeComponent();

            // Attach simple presentation model
            DataContext = new WindowPresentationModel();

            formUpdated = false;
            movedBack = false;

            collectionDetails = new Classes.Collection();
            m_Wizard.DataContext = collectionDetails;
        }

        // Wizard event handlers
        private void m_Wizard_NextClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void m_Wizard_PreviousClick(object sender, RoutedEventArgs e)
        {
            // Flag our backwards movement so we can repopulate the boxes
            // on the previous page
            movedBack = true;
        }

        private void Wizard_OnFinishClick(object sender, RoutedEventArgs e)
        {
            // Not sure about the finish button here, does it make sense?
            // Can I remove it easily
            Close();
        }

        private void Wizard_OnCancelClick(object sender, RoutedEventArgs e)
        {
            if (formUpdated == true)
            {
                MessageBoxResult response = MessageBox.Show("Quit, losing current collection?",
                    "Really quit?", MessageBoxButton.OKCancel);

                if (response == MessageBoxResult.OK)
                {
                    Close();
                }
            }
        }

        // Wizard page 1 events
        private void cbIssuer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string issuer = cbIssuer.SelectedValue.ToString();
            if (issuer.Contains("Brooke"))
            {
                collectionDetails.brokeBond = true;
                tbSerialNo.IsEnabled = true;
                label5.IsEnabled = true;
            }
        }

        private void btnNotes_Click(object sender, RoutedEventArgs e)
        {
            NotesWindow notesDialog = new NotesWindow();
            notesDialog.Owner = this;
            notesDialog.notesText = collectionDetails.notes;

            notesDialog.Show();

            if (notesDialog.DialogResult == true)
            {
                collectionDetails.notes = notesDialog.notesText;
            }
        }

        private void tbNumberEntry_GotFocus(object sender, RoutedEventArgs e)
        {
            // A general function which puts the cursor to the end of any text
            // in the selected text box, makes editing a bit easier.  Only used
            // by text boxes which accept numbers.  Needed because they are bound
            // to ints which have a default value of 0 and the cursor always goes to
            // the begining, very anonying!
            TextBox tb = (TextBox)sender;

            string contents = tb.Text;
            if (contents == "0")
            {
                tb.Select(contents.Length, 1);
            }
        }

        // Wizard page 2 event handlers
        private void oddsTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // We are called by many text boxes so we need to get the boxes name
            // so we can figure out which element of the odds array to update

            TextBox tb = (TextBox)sender;
            // All names start with the string tbOdds
            int boxId = Convert.ToInt32(tb.Name.Substring(6));

            if (tb.Text != "" & tb.Text != "0")
            {
                collectionDetails.odds[boxId] = Convert.ToInt32(tb.Text);
            }
        }

        // Wizard page 3 event handlers
        private void btnSavePrintRestart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPrintResart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnResart_Click(object sender, RoutedEventArgs e)
        {

        }

        // Page load event handlers
        private void CollectionDetails_PageShow(object sender, RoutedEventArgs e)
        {
            // Bind our controls to the Collection object
            tbCollectionName.DataContext = collectionDetails;
            cbIssuer.DataContext = collectionDetails;
            tbYear.DataContext = collectionDetails;
            tbSerialNo.DataContext = collectionDetails;
            tbCardsInSet.DataContext = collectionDetails;
            tbAlbumSets.DataContext = collectionDetails;
            tbLoseSets.DataContext = collectionDetails;
        }

        private void OddCards_PageShow(object sender, RoutedEventArgs e)
        {
            // Add controls for entering the odds we have in the collection
            // (an odd is a card not in a complete collection)

            // We only need to populate this page if we have not visited it before
            if (movedBack == false)
            {
                // The printed document has the odds laid out in rows of 8
                // so we have this page show the text boxes in rows of 8 too
                // We always have a least one row
                int rows = (collectionDetails.cards / 8) + 1;
                int odds = collectionDetails.cards % 8;

                Thickness rowMargins = new Thickness(0, 0, 10, 0);
                int currentCard = 0;

                // Loop through our rows
                for (int r = 1; r <= rows; r++)
                {
                    // If we are on the last row, check our odds, otherwise it
                    // will be a full row
                    int items;
                    if (r == rows)
                    {
                        items = odds;
                    }
                    else
                    {
                        items = 8;
                    }

                    // Create the stack panels which layout the indivdual controls
                    StackPanel spLabelRow = new StackPanel();
                    StackPanel spTextBoxRow = new StackPanel();
                    spLabelRow.Name = "spRow" + r + "Labels";
                    spLabelRow.Orientation = Orientation.Horizontal;
                    spTextBoxRow.Name = "spRow" + r + "TextBoxes";
                    spTextBoxRow.Orientation = Orientation.Horizontal;

                    // Popualte the stack panel 'rows'
                    for (int i = 1; i <= items; i++)
                    {
                        // Keep track of the which card we are working on, for id's and labels etc.
                        currentCard++;
                        Label oddsLabel = new Label();
                        oddsLabel.Content = "Card " + currentCard;
                        oddsLabel.Width = 55;
                        oddsLabel.Margin = rowMargins;
                        oddsLabel.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
                        spLabelRow.Children.Add(oddsLabel);

                        TextBox oddsTextBox = new TextBox();
                        oddsTextBox.Name = "tbOdds" + currentCard;
                        oddsTextBox.TextAlignment = TextAlignment.Center;
                        oddsTextBox.Text = "0";
                        oddsTextBox.Width = 55;
                        oddsTextBox.Margin = rowMargins;
                        oddsTextBox.LostFocus += new RoutedEventHandler(oddsTextBox_LostFocus);
                        spTextBoxRow.Children.Add(oddsTextBox);

                        // Set all cards in our odds array to 0 now, so we can use
                        // lost focus events in the textboxes to update array elements
                        collectionDetails.odds.Add(0);
                    }

                    // Add the rows after they are fully populated 
                    spRowHolder.Children.Add(spLabelRow);
                    spRowHolder.Children.Add(spTextBoxRow);
                }
            }
        }
    }
}