using System;
using System.ComponentModel;
using System.Diagnostics;
using Prism.Commands;
using Prism.Navigation;

namespace VisualStateManagerLearning.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public DelegateCommand VsmButtonTappedCommand { get; set; }
        public DelegateCommand NoVsmButtonTappedCommand { get; set; }

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

            VsmButtonTappedCommand = new DelegateCommand(OnVsmButtonTapped);
            NoVsmButtonTappedCommand = new DelegateCommand(OnNoVsmButtonTapped);

            this.PropertyChanged += OnViewModelPropertyChanged;
        }

        void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(string.Equals(e.PropertyName, nameof(ShouldEnableButtons), StringComparison.Ordinal))
            {
                Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnViewModelPropertyChanged)}:  {nameof(ShouldEnableButtons)} now set to {ShouldEnableButtons}.");
            }
        }

        private void OnNoVsmButtonTapped()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNoVsmButtonTapped)}");
        }

        private void OnVsmButtonTapped()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnVsmButtonTapped)}");
        }
    }
}
