﻿using System.ComponentModel;

namespace Playground.Model
{
    //public class StudentModel
    //{
    //}

    public class Student : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string asioId;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
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
        public string AsioId{ get { return asioId; }
            set
            {
                asioId = value;
                RaisePropertyChanged("AsioId");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}