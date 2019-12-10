using System;
using System.Collections.Generic;

using Xamarin.Forms;
using static SelectableButtons.SelectableButtons;

namespace SelectableButtons
{
    public partial class MyPage : ContentPage
    {

        public IList<SelectableButton> SelectableButtonsList { get; set; }

        public string PageTitle { get; set; }

        public MyPage()
        {

            InitializeComponent();

            Title = "Testing";

            SetUpButtonData();

        }

        private void SetUpButtonData()
        {
            SelectableButtonsList = new List<SelectableButton>
            {
                new SelectableButton
                {
                    Title = "OFF",
                    State = 0,
                    IsSelected = true
                },
                new SelectableButton
                {
                    Title = "ON",
                    State = 1,
                    IsSelected = false
                },
                new SelectableButton
                {
                    Title = "NONE",
                    State = 2,
                    IsSelected = false
                },
                new SelectableButton
                {
                    Title = "ERROR",
                    State = 2,
                    IsSelected = false
                }

            };

            SelectableButtonsView.ButtonList = SelectableButtonsList;
            BindingContext = this;

        }
    }

    
}
