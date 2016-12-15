using GalaSoft.MvvmLight;
using BTB_Data;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;

namespace BTB_UI.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private List<Catalog> _newlyReleased;

        public List<Catalog> NewlyReleased
        {
            get { return _newlyReleased; }
            set { Set(() => NewlyReleased, ref _newlyReleased, value); }
        }

        Repository repo;

        private void GetNewlyReleased()
        {
            var result = repo.NewlyReleased();
            NewlyReleased = result;
        }

        public RelayCommand NewlyReleasedCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            NewlyReleasedCommand = new RelayCommand(GetNewlyReleased, () => NewlyReleased != null);
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}