﻿using System;
using System.Windows.Input;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using XCalendarFormsSample.Popups;

namespace XCalendarFormsSample.ViewModels
{
    public class CustomDatePickerDialogExampleViewModel : BaseViewModel
    {
        #region Properties
        public DateTime SelectedDate { get; set; } = DateTime.Today;
        #endregion

        #region Commands
        public ICommand ShowDatePickerDialogCommand { get; set; }
        #endregion

        #region Constructors
        public CustomDatePickerDialogExampleViewModel()
        {
            ShowDatePickerDialogCommand = new Command<DateTime>(ShowDatePickerDialog);
        }
        #endregion

        #region Methods
        public async void ShowDatePickerDialog(DateTime initialDate)
        {
           SelectedDate = await Shell.Current.ShowPopupAsync(new DatePickerDialogPopup(initialDate));
        }
        #endregion
    }
}
