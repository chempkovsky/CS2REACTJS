﻿using CS2REACTJS.ViewModel;
using System;
using System.Windows.Controls;

namespace CS2REACTJS.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlCreateForeignKey.xaml
    /// </summary>
    public partial class UserControlCreateForeignKey : UserControl
    {
        public UserControlCreateForeignKey(CreateForeignKeyViewModel dataContext)
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
