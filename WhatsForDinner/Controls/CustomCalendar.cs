using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace WhatsForDinner.Controls
{
    public class CustomCalendar : Grid
    {
        private DateTime _currentMonth;
        private ObservableCollection<DayViewModel> _days;
        public event EventHandler<DateTime> DaySelected;

        public CustomCalendar()
        {
            _currentMonth = DateTime.Now;
            _days = new ObservableCollection<DayViewModel>();
            BuildCalendar();
        }

        private void BuildCalendar()
        {
            Children.Clear();
            RowDefinitions.Clear();
            ColumnDefinitions.Clear();

            _days.Clear();

            var firstDayOfMonth = new DateTime(_currentMonth.Year, _currentMonth.Month, 1);
            int dayOffset = ((int)firstDayOfMonth.DayOfWeek - (int)CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7;
            int daysInMonth = DateTime.DaysInMonth(_currentMonth.Year, _currentMonth.Month);

            for (int i = 0; i < dayOffset; i++)
            {
                _days.Add(new DayViewModel { Day = string.Empty, Date = DateTime.MinValue, IsEnabled = false });
            }

            for (int day = 1; day <= daysInMonth; day++)
            {
                _days.Add(new DayViewModel { Day = day.ToString(), Date = new DateTime(_currentMonth.Year, _currentMonth.Month, day), IsEnabled = true });
            }

            var collectionView = new CollectionView
            {
                ItemsSource = _days,
                ItemsLayout = new GridItemsLayout(7, ItemsLayoutOrientation.Vertical),
                ItemTemplate = new DayTemplate()
            };

            Children.Add(collectionView);
        }

        public virtual void OnDaySelected(DateTime selectedDate)
        {
            DaySelected?.Invoke(this, selectedDate);
        }
    }

    public class DayViewModel
    {
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public bool IsEnabled { get; set; }
    }

    public class DayTemplate : DataTemplateSelector
    {
        private readonly DataTemplate _dayTemplate;

        public DayTemplate()
        {
            _dayTemplate = new DataTemplate(() =>
            {
                var grid = new Grid
                {
                    Padding = new Thickness(5)
                };

                var button = new Button
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    BackgroundColor = Colors.Transparent,
                    TextColor = Colors.Black,
                    FontSize = 16,
                    CornerRadius = 20,
                    HeightRequest = 40,
                    WidthRequest = 50
                };

                // Set the event handler for the button click
                button.Clicked += Button_Clicked;

                button.SetBinding(Button.TextProperty, nameof(DayViewModel.Day));
                button.SetBinding(Button.CommandParameterProperty, nameof(DayViewModel.Date));
                button.SetBinding(Button.IsEnabledProperty, nameof(DayViewModel.IsEnabled));

                grid.Children.Add(button);

                return grid;
            });
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return _dayTemplate;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.BindingContext is DayViewModel dayViewModel && dayViewModel.IsEnabled)
            {
                var calendar = FindParent<CustomCalendar>(button);
                calendar?.OnDaySelected(dayViewModel.Date);
            }
        }

        private T FindParent<T>(VisualElement element) where T : VisualElement
        {
            var parent = element.Parent;

            while (parent != null && !(parent is T))
            {
                parent = parent.Parent;
            }

            return parent as T;
        }
    }
}
