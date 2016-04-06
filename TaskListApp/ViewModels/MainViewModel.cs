using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using TaskListApp.Commands;

namespace TaskListApp.ViewModels
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
        private ObservableCollection<ToDoTask> itemsCollection = new ObservableCollection<ToDoTask>();
        public ObservableCollection<ToDoTask> ItemsCollection
        {
            get
            {
                return itemsCollection;
            }
            set
            {
                itemsCollection = value;
                OnPropertyChanged("ItemsCollection");
            }
        }

        public ActionCommand ClickCommand { get; set; }
        public ICommand AddElementCommand { get; set; }
        

        public MainViewModel()
        {
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
        }

        private void OnClick()
        {
            Title = "Time: " + DateTime.Now.Ticks;
        }
    }
}
