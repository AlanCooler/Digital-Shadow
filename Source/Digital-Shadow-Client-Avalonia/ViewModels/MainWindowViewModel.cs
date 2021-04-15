namespace Digital_Shadow_Client_Avalonia.ViewModels
{
    public sealed class MainWindowViewModel : ViewModelBase
    {
        #region Fields

        private string _ApplicationName = "Digital Shadow";
        public string ApplicationName
        {
            get => _ApplicationName;
            set => _ApplicationName = value;
        }

        #endregion
    }
}
