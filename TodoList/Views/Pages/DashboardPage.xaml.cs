// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using TodoList.ViewModels.Pages;

using Wpf.Ui.Controls;

namespace TodoList.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }

        private void Add_Task(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                if (!string.IsNullOrWhiteSpace(ViewModel.TodoString))
                {
                    ViewModel.TodoTasks.Add(new Models.TodoTask()
                    {
                        Title = ViewModel.TodoString
                    });
                    ViewModel.TodoString = string.Empty;
                }
            }
        }

        private void Size_Changed(object sender, SizeChangedEventArgs e)
        {
            ScrollViewer_Tasks.Height = DashboardPageGrid.RowDefinitions[1].ActualHeight;
            e.Handled = true;
        }
    }
}
