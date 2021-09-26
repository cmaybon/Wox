using System.Windows;
using System.Windows.Controls;

namespace Wox.Plugin.Everything
{
    public partial class EverythingSettings : UserControl
    {
        private readonly Settings _settings;

        public EverythingSettings(Settings settings)
        {
            InitializeComponent();
            _settings = settings;
        }

        private void View_Loaded(object sender, RoutedEventArgs re)
        {
            UseLocationAsWorkingDir.IsChecked = _settings.UseLocationAsWorkingDir;
            SearchMatchCase.IsChecked = _settings.SearchMatchCase;
            SearchWholeWord.IsChecked = _settings.SearchWholeWord;
            SearchPath.IsChecked = _settings.SearchPath;

            UseLocationAsWorkingDir.Checked += (o, e) =>
            {
                _settings.UseLocationAsWorkingDir = true;
            };

            UseLocationAsWorkingDir.Unchecked += (o, e) =>
            {
                _settings.UseLocationAsWorkingDir = false;
            };

            SearchMatchCase.Checked += (o, e) =>
            {
                _settings.SearchMatchCase = true;
            };

            SearchMatchCase.Unchecked += (o, e) =>
            {
                _settings.SearchMatchCase = false;
            };

            SearchWholeWord.Checked += (o, e) =>
            {
                _settings.SearchWholeWord = true;
            };

            SearchWholeWord.Unchecked += (o, e) =>
            {
                _settings.SearchWholeWord = false;
            };

            SearchPath.Checked += (o, e) =>
            {
                _settings.SearchPath = true;
            };

            SearchPath.Unchecked += (o, e) =>
            {
                _settings.SearchPath = false;
            };
        }
    }
}
