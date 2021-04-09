﻿using SophiApp.Commons;
using SophiApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace SophiApp.Models
{
    internal class CheckBoxModel : IUIElementModel, INotifyPropertyChanged
    {
        private string description;
        private string header;
        private bool isChecked = default;
        private bool systemState = default;
        private bool userState = default;

        public CheckBoxModel(JsonDTO json)
        {
            Descriptions = json.Descriptions;
            Headers = json.Headers;
            Id = json.Id;
            HasParent = json.HasParent;
            Tag = json.Tag;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Description
        {
            get => description;
            set
            {
                description = value;
                OnPropertyChanged("Description");
            }
        }

        public string Header
        {
            get => header;
            set
            {
                header = value;
                OnPropertyChanged("Header");
            }
        }

        public int Id { get; set; }

        public bool HasParent { get; set; }

        public bool IsChecked
        {
            get => isChecked;
            set
            {
                isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }

        public Dictionary<UILanguage, string> Descriptions { get; set; }
        public Dictionary<UILanguage, string> Headers { get; set; }

        public bool SystemState
        {
            get => systemState;
            set
            {
                systemState = value;
                OnPropertyChanged("SystemState");
            }
        }

        public string Tag { get; set; }

        public bool UserState
        {
            get => userState;
            set
            {
                userState = value;
                OnPropertyChanged("UserState");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
#if DEBUG
            Debug.WriteLine($"{DateTime.Now}");
            Debug.WriteLine($"Id: {Id}");
            Debug.WriteLine($"SystemState: {SystemState}");
            Debug.WriteLine($"UserState: {UserState}");
            Debug.WriteLine($"IsChecked: {IsChecked}");
            Debug.WriteLine("");
#endif

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetLocalizationTo(UILanguage language)
        {
            Header = Headers[language];
            Description = Descriptions[language];
        }

        public void SetSystemState()
        {
            SystemState = true;
            IsChecked = true;
        }

        public void SetUserState()
        {
            UserState = !UserState;
            IsChecked = !IsChecked;
        }
    }
}