﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PixiEditor.Helpers;

namespace PixiEditor.Views
{
    /// <summary>
    /// Interaction logic for LayerItem.xaml
    /// </summary>
    public partial class LayerItem : UserControl
    {
        public LayerItem()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty IsRenamingProperty = DependencyProperty.Register(
            "IsRenaming", typeof(bool), typeof(LayerItem), new PropertyMetadata(default(bool)));

        public bool IsRenaming
        {
            get { return (bool) GetValue(IsRenamingProperty); }
            set { SetValue(IsRenamingProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register(
            "IsActive", typeof(bool), typeof(LayerItem), new PropertyMetadata(default(bool)));

        public bool IsActive
        {
            get { return (bool) GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty SetActiveLayerCommandProperty = DependencyProperty.Register(
            "SetActiveLayerCommand", typeof(RelayCommand), typeof(LayerItem), new PropertyMetadata(default(RelayCommand)));

        public RelayCommand SetActiveLayerCommand
        {
            get { return (RelayCommand) GetValue(SetActiveLayerCommandProperty); }
            set { SetValue(SetActiveLayerCommandProperty, value); }
        }

        public static readonly DependencyProperty LayerIndexProperty = DependencyProperty.Register(
            "LayerIndex", typeof(int), typeof(LayerItem), new PropertyMetadata(default(int)));

        public int LayerIndex
        {
            get { return (int) GetValue(LayerIndexProperty); }
            set { SetValue(LayerIndexProperty, value); }
        }

        public static readonly DependencyProperty LayerNameProperty = DependencyProperty.Register(
            "LayerName", typeof(string), typeof(LayerItem), new PropertyMetadata(default(string)));

        public string LayerName
        {
            get { return (string) GetValue(LayerNameProperty); }
            set { SetValue(LayerNameProperty, value); }
        }

        public static readonly DependencyProperty ControlButtonsVisibleProperty = DependencyProperty.Register(
            "ControlButtonsVisible", typeof(Visibility), typeof(LayerItem), new PropertyMetadata(System.Windows.Visibility.Hidden));

        public Visibility ControlButtonsVisible
        {
            get { return (Visibility) GetValue(ControlButtonsVisibleProperty); }
            set { SetValue(ControlButtonsVisibleProperty, value); }
        }



        public RelayCommand MoveToBackCommand
        {
            get { return (RelayCommand)GetValue(MoveToBackCommandProperty); }
            set { SetValue(MoveToBackCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MoveToBackCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MoveToBackCommandProperty =
            DependencyProperty.Register("MoveToBackCommand", typeof(RelayCommand), typeof(LayerItem), new PropertyMetadata(default(RelayCommand)));

        public static readonly DependencyProperty MoveToFrontCommandProperty = DependencyProperty.Register(
            "MoveToFrontCommand", typeof(RelayCommand), typeof(LayerItem), new PropertyMetadata(default(RelayCommand)));

        public RelayCommand MoveToFrontCommand
        {
            get { return (RelayCommand) GetValue(MoveToFrontCommandProperty); }
            set { SetValue(MoveToFrontCommandProperty, value); }
        }


        private void LayerItem_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ControlButtonsVisible = Visibility.Visible;
        }

        private void LayerItem_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ControlButtonsVisible = Visibility.Hidden;

        }
    }
}
