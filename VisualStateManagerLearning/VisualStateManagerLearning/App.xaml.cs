using System.Diagnostics;
using Prism;
using Prism.Ioc;
using VisualStateManagerLearning.ViewModels;
using VisualStateManagerLearning.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace VisualStateManagerLearning
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null)
        {
            Debug.WriteLine($"**** {this.GetType().Name}:  ctor (no parameters)");
        }

        public App(IPlatformInitializer initializer) : base(initializer)
        {
            Debug.WriteLine($"**** {this.GetType().Name}:  ctor");
        }

        protected override async void OnInitialized()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnInitialized)}");

            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(RegisterTypes)}");

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
        }

        protected override void OnStart()
        {
            base.OnStart();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
        }

        protected override void OnSleep()
        {
            base.OnSleep();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
        }

        protected override void OnResume()
        {
            base.OnResume();
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
        }
    }
}
