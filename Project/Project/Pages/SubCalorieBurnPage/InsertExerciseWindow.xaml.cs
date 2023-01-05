﻿using Microsoft.Win32;
using Project.Model;
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
using System.Windows.Shapes;

namespace Project.Pages.SubCalorieBurnPage
{
    /// <summary>
    /// Interaction logic for InsertExerciseWindow.xaml
    /// </summary>
    public partial class InsertExerciseWindow : Window
    {
        public InsertExerciseWindow()
        {
            InitializeComponent();
        }

        private void AddImg_btn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Title = "Hãy chọn 1 tấm ảnh";
            image.Filter = "Image (*.jpeg;*.png;*.jpg;*.gif)|*.jpeg;*.png;*.jpg;*.gif";
            if (image.ShowDialog() == true)
            {
                ExerciseImg.ImageSource = new BitmapImage(new Uri(image.FileName));
            }
        }

        private void AddExercise_btn_Click(object sender, RoutedEventArgs e)
        {
            // check empty textbox
            if (ExName_tb.Text == null || CaloPerH_tb.Text == null)
            {
                MessageBox.Show("Nhập thiếu thông tin bắt buộc !");
                return;
            }

            // check calo textbox validation
            if (!int.TryParse(CaloPerH_tb.Text, out int calo))
            {
                MessageBox.Show("Lượng calo chỉ được nhập số");
                return;
            }

            // all is ok
            Exercise exercise = new Exercise();
            exercise.ExName = ExName_tb.Text;
            exercise.Kps = Convert.ToDecimal(CaloPerH_tb.Text);
            exercise.ImgLink = ExerciseImg.ImageSource.ToString();

            DataProvider.Ins.DB.Exercise.Add(exercise);
            DataProvider.Ins.DB.SaveChanges();

            UserExercise userExercise = new UserExercise();
            userExercise.UserID = DataProvider.Ins.Current_UserID;
            userExercise.ExID = exercise.ExID;
            DataProvider.Ins.DB.UserExercise.Add(userExercise);
            DataProvider.Ins.DB.SaveChanges();

            MainWindow mainWindow = this.Owner as MainWindow;
            CalorieBurnPage calorieBurnPage = mainWindow.Main.Content as CalorieBurnPage;
            calorieBurnPage.ExerciseList.Add(exercise);
            calorieBurnPage.lvCaloriesBurned.Items.Refresh();

            MessageBox.Show("Bài tập mới đã được thêm vào !");
            this.Close();
        }
    }
}
