﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using ColorCode;

namespace Caliburn.Micro.Contrib.Demo.Views.Samples
{
    public partial class GenericSampleView : UserControl
    {
        public GenericSampleView()
        {
            InitializeComponent();
            Loaded += (sender, args) =>
            {
                var code = (DataContext as ISample).Code;
                var html = new CodeColorizer().Colorize(code, Languages.CSharp);
                html = html.Replace("White", "#A0A0A0");
                html = "<body style=\"background-color:#A0A0A0;\">" + html + "</body>";
                Browser.NavigateToString(html);
            };
        }
    }
}
