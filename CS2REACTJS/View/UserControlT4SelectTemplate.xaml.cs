﻿using CS2REACTJS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS2REACTJS.View
{
    /// <summary>
    /// Логика взаимодействия для UserControlT4SelectTemplate.xaml
    /// </summary>
    public partial class UserControlT4SelectTemplate : UserControl
    {
        public UserControlT4SelectTemplate(Selectt4TemplateViewModel dataContext)
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
