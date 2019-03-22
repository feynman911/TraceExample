using Prism.Mvvm;
using System.Diagnostics;

namespace TraceExample.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {
            string st = "";
            for(int i = 0;i < 10; i++)
            {
                st = "テスト:" + i.ToString("D2");
                Trace.WriteLine(st);
            }
            
        }
    }
}
