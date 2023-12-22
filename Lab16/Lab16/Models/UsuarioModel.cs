using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab16.Models
{

    public class UsuarioModel:INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChange([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private int userid;

        public int UserId
        {
            get { return userid; }
            set { userid = value;
                OnPropertyChange();
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value;
                OnPropertyChange();
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value;
                OnPropertyChange();
            }
        }

        private bool complete;

        

        public bool Complete
        {
            get { return complete; }
            set { complete = value;
                OnPropertyChange();
            }
        }
    }
}
