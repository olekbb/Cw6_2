using Cw6_2.Commands;
using Cw6_2;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;

namespace Cw6_2.ViewModels
{
    public class MainViewModel : ViewModel
    {
        private string title;
        private string value;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        public string Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
                OnPropertyChanged("Value");
            }
        }
        private ObservableCollection<ToDoTask> itemsCollection;
        public ObservableCollection<ToDoTask> ItemsCollection
        {
            get
            {
                return itemsCollection;
            }
            set
            {
                itemsCollection = value;

               // RaisePropertyChanged("ItemsCollection");
                //OnPropertyChanged("ItemsCollection");
            }
        }

        public ActionCommand ClickCommand { get; set; }
        public ICommand AddElementCommand { get; set; }
        

        public MainViewModel()
        {
            ItemsCollection = new ObservableCollection<ToDoTask>();
            ItemsCollection.Add(new ToDoTask("task1", "opis"));
            ItemsCollection.Add(new ToDoTask("task2", "opis"));
            ItemsCollection.Add(new ToDoTask("task3", "opis"));
            
            //ClickCommand = new ActionCommand(OnClick);
            //AddElementCommand = new ActionCommand(()=>
            //{

            //});
            AddElementCommand = new RelayCommand(pars => AddElement());
        }

        private void AddElement()
        {
            ItemsCollection.Add(new ToDoTask(Title, Value));

            //OnPropertyChanged("ItemsCollection");
            RaisePropertyChanged("ItemsCollection");
        }

        private void OnClick()
        {
            Title = "Time: " + DateTime.Now.Ticks;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }

    }
}
