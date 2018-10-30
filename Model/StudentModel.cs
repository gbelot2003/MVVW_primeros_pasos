using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class StudentModel
    {
    }

    // Se implementa la interface
    public class Student : INotifyPropertyChanged
    {

        // se agregan las propiedades de la clase
        private string firstName;
        private string lastName;

        // Se notifican los getters y setters
        public string FirstName
        {
            get { return firstName; }
            set
            {
                // Se vigila el cambio de valor en los setters de las propiedades.
                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }

        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        // Se extrae el PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        //Se vigilan los cambios del property
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
