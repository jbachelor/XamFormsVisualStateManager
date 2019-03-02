using Prism.Navigation;

namespace VisualStateManagerLearning.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private bool _shouldEnableButtons;
        public bool ShouldEnableButtons
        {
            get { return _shouldEnableButtons; }
            set { SetProperty(ref _shouldEnableButtons, value); }
        }

        private string _noVSMButtonText;
        public string NoVSMButtonText
        {
            get { return _noVSMButtonText; }
            set { SetProperty(ref _noVSMButtonText, value); }
        }

        private string _VSMButtonText;
        public string VSMButtonText
        {
            get { return _VSMButtonText; }
            set { SetProperty(ref _VSMButtonText, value); }
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Visual States";
            VSMButtonText = "VISUAL STATES";
            NoVSMButtonText = "DEFAULT BEHAVIOR";
            ShouldEnableButtons = true;
        }
    }
}
