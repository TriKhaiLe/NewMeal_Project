﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Project.Model;

namespace Project.Pages
{
    /// <summary>
    /// Interaction logic for HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        private double _lastLecture;
        private double _trend;
        private List<HistoryInDay> _userhistory;
        public HistoryPage()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {4, 5, 6, 8},
                    StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                    DataLabels = true
                },
                new StackedColumnSeries
                {
                    Values = new ChartValues<double> {2, 5, 6, 7},
                    StackMode = StackMode.Values,
                    DataLabels = true
                }
            };

            //adding series updates and animates the chart
            SeriesCollection.Add(new StackedColumnSeries
            {
                Values = new ChartValues<double> { 6, 2, 7 },
                StackMode = StackMode.Values
            });

            //adding values also updates and animates
            SeriesCollection[2].Values.Add(4d);

            Labels = new[] { "Chrome", "Mozilla", "Opera", "IE" };
            Formatter = value => value + " Mill";

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }


        //===================================================================================
        #region backend
        //---------------------------------------------------------------------------------
        // STATIC DATABASE
        // Get Data
        static private List<UserHistory> _HistoryData = null;

        static public List<UserHistory> HistoryData
        {
            get
            {
                if (refresh_History())
                {
                    refresh_UserHistory();
                }
                return _HistoryData;
            }
        }

        static private bool refresh_History()
        {
            if (_HistoryData == null || _HistoryData != DataProvider.Ins.DB.UserHistory.ToList())
            {
                _HistoryData = DataProvider.Ins.DB.UserHistory.ToList();
                return true;
            }
            return false;
        }

        //Get User Data
        static private List<UserHistory> _UserHistory = null;
        static public List<UserHistory> UserHistory
        {
            get
            {
                if(refresh_History())
                {
                    refresh_UserHistory();
                }
                return _UserHistory;
            }
        }

        static private void refresh_UserHistory()
        {
            _UserHistory = HistoryData.Where(x => (int)(x.UserID) == DataProvider.Ins.Current_UserID).ToList();
            _UserHistory.OrderBy(x => x.eatDate);
        }

        //---------------------------------------------------------------------------------
        struct HistoryInDay
        {
            private List<Food> _Morning;
            private List<Food> _Lunch;
            private List<Food> _Dinner;
            private DateTime _date;
            public HistoryInDay(DateTime date, List<Food> morning, List<Food> lunch, List<Food> dinner)
            {
                _date = date;
                _Morning = morning;
                _Lunch = lunch;
                _Dinner = dinner;
            }

            public List<Food> Morning
            {
                get { return _Morning; }
            }

            public List<Food> Lunch
            {
                get { return _Lunch; }
            }

            public List<Food> Dinner
            {
                get { return _Dinner; }
            }

            public int MorningKcal
            {
                get { return (int)(_Morning.Sum(x => x.Kcal)); }
            }

            public int LunchKcal
            {
                get { return (int)(_Lunch.Sum(x => x.Kcal)); }
            }

            public int DinnerKcal
            {
                get { return (int)(_Dinner.Sum(x => x.Kcal)); }
            }

            public DateTime Date
            {
                get { return _date; }
            }
        } 

        private int CompareDate(DateTime a, DateTime b)
        {
            if (a.Year < b.Year)
            {
                return -1;
            }
            if (a.Year > b.Year)
            {
                return 1;
            }
            if (a.DayOfYear < b.DayOfYear)
            {
                return -1;
            }
            if (a.DayOfYear > b.DayOfYear)
            {
                return 1;
            }
            return 0;
        }

        private List<HistoryInDay> GetHistory()
        {
            List<HistoryInDay> history = new List<HistoryInDay>();
            if (UserHistory.Count() == 0)
            {
                return history;
            }
            DateTime date = (DateTime)(UserHistory[UserHistory.Count()-1].eatDate);
            date.AddDays(1);
            int count = 7;
            for(int i = UserHistory.Count; i>=0; i--)
            {
                UserHistory his = UserHistory[i];
                int gap = 0;
                while (CompareDate(date,(DateTime)(his.eatDate)) == 1)
                {
                    date.AddDays(-1);
                    count--;
                    gap++;
                }
                if (count < 0)
                {
                    break;
                }
                while (gap > 0)
                {
                    history.Add(new HistoryInDay(date,new List<Food>(), new List<Food>(), new List<Food>()));
                    gap--;
                }
                // Add to History in date
                HistoryInDay historyInDay = history[history.Count() - 1];
                switch(his.Meal)
                {
                    case 3:
                        {
                            historyInDay.Morning.Add(his.Food);
                            break;
                        }
                    case 4:
                        {
                            historyInDay.Lunch.Add(his.Food);
                            break;
                        }
                    case 5:
                        {
                            historyInDay.Dinner.Add(his.Food);
                            break;
                        }
                }

            }
            return history;
        }
        

        //---------------------------------------------------------------------------------
        #endregion

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            _userhistory = GetHistory();
            SeriesCollection = new SeriesCollection();
            List<string> labelList = new List<string>();

            foreach(HistoryInDay his in _userhistory)
            {
                SeriesCollection.Add(new StackedColumnSeries
                {
                    Values = new ChartValues<double> { his.MorningKcal, his.LunchKcal, his.DinnerKcal},
                    StackMode = StackMode.Values
                });
                labelList.Add(his.Date.ToString());
            }
            Labels = labelList.ToArray();
            Formatter = value => value + " Mill";
        }
    }
}
