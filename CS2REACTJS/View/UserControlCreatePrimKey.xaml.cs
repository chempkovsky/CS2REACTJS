﻿using CS2REACTJS.ViewModel;
using System;
using System.Windows.Controls;

namespace CS2REACTJS.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlCreatePrimKey.xaml
    /// </summary>
    public partial class UserControlCreatePrimKey : UserControl
    {
        public UserControlCreatePrimKey(CreatePrimaryKeyViewModel dataContext)
        {
            InitializeComponent();
            SetDataContext(dataContext);
        }
        public void SetDataContext(Object dataContext)
        {
            this.DataContext = dataContext;

        }
    }
}
