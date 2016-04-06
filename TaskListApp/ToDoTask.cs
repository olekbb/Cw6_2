using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListApp
{
    public class ToDoTask : INotifyPropertyChanged
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Value { get; set; }
        public string OwnerId { get; set; }
        public string CreatedAt { get; set; }

        public ToDoTask(string Title, string Value)
        {
            this.Title = Title;
            this.Value = Value;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }


}
