// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) Leszek Pomianowski and WPF UI Contributors.
// All Rights Reserved.

using System.Collections.ObjectModel;

using TodoList.Helpers;
using TodoList.Models;

namespace TodoList.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        string todayString = string.Empty;

        [ObservableProperty]
        string todoString = string.Empty;

        [ObservableProperty]
        ObservableCollection<TodoTask> todoTasks = new ObservableCollection<TodoTask>()
        {
            new TodoTask()
            {
                Id = Guid.NewGuid().ToString(),
                Title = "XXXXX"
            }
        };

        public DashboardViewModel()
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = $"{currentDate.Month}月{currentDate.Day}日，{currentDate.GetChineseDayOfWeek()}";
            todayString = formattedDate;
        }
    }
}
