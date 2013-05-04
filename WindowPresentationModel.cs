using System.ComponentModel;

namespace CardCollection
{
    public class WindowPresentationModel : INotifyPropertyChanged
    {
        private bool m_OptionSelected;

        public bool OptionSelected
        {
            get { return m_OptionSelected; }
            set
            {
                m_OptionSelected = value;
                OnPropertyChanged("OptionChanged");
            }
        }

        protected virtual void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}