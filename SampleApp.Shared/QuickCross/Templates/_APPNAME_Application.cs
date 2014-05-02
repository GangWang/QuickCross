#if TEMPLATE // To add an application class: in the Visual Studio Package Manager Console (menu View | Other Windows), enter "Install-Mvvm". Alternatively: copy this file, then in the copy remove the enclosing #if TEMPLATE ... #endif lines and replace _APPNAME_ with the application name.
using System;
using System.Threading.Tasks;
using QuickCross;
using QuickCross.Templates.ViewModels;
using QuickCross.Templates.ViewModels.Design;

namespace QuickCross.Templates
{
    public sealed class _APPNAME_Application : ApplicationBase
    {
        private I_APPNAME_Navigator _navigator;

        public _APPNAME_Application(I_APPNAME_Navigator navigator, TaskScheduler uiTaskScheduler = null)
            : base(uiTaskScheduler)
        {
            // Services that have a platform-specific implementation, such as the navigator,
            // are instantiated in a platform-specific project and passed to this application 
            // as a cross-platform interface.
            _navigator = navigator;

            // TODO: Create instances for all services that have a cross-platform implementation
        }

        new public static _APPNAME_Application Instance { get { return (_APPNAME_Application)ApplicationBase.Instance; } }

        /* TODO: For each viewmodel, add a public property with a private setter like this:
        public _VIEWNAME_ViewModel _VIEWNAME_ViewModel { get; private set; }
         * DO NOT REMOVE this comment; the New-View and New-ViewModel commands use this to add the above code automatically (see http://github.com/MacawNL/QuickCross#new-viewmodel). */

		public void ReturnToPreviousView()
		{
			RunOnUIThread(() => _navigator.NavigateToPreviousView());
		}

        /* TODO: For each view, add a method (with any parameters needed) to initialize its viewmodel
         * and then navigate to the view using the navigator, like this:

        public void ContinueTo_VIEWNAME_()
        {
            if (_VIEWNAME_ViewModel == null) _VIEWNAME_ViewModel = UseDesignViewModels ? new _VIEWNAME_ViewModelDesign() : new _VIEWNAME_ViewModel();
            // Any actions to update the viewmodel go here
            RunOnUIThread(() => _navigator.NavigateTo_VIEWNAME_View());
        }
         * DO NOT REMOVE this comment; the New-View command uses this to add the above code automatically (see http://github.com/MacawNL/QuickCross#new-view). */
    }
}

#endif // TEMPLATE