﻿/*
 * Copyright 2011 ODIN Working Group. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using Microsoft.Phone.Controls;
using System.ComponentModel;

namespace org.odinmobile.windowsphone
{
    public partial class MainPage : PhoneApplicationPage, INotifyPropertyChanged
    {

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = this;
            InitData();
        }

        private void InitData()
        {
            odin = ODIN.GetODIN1();
        }

        string _odin = "";
        public string odin 
        {
            get 
            {
                return _odin;
            }
            set 
            {
                _odin = value;
                raise_NotifyPropertyChanged("odin");
            }

        }

        private void raise_NotifyPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}