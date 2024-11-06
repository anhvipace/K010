using System;
using System.Windows;

namespace TikTokCloneApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlayVideo();
        }

        // Phương thức để phát video từ tài nguyên nhúng
        private void PlayVideo()
        {
            // Sử dụng đường dẫn Resource URI để phát video nhúng
            videoPlayer.Source = new Uri("C:\\Users\\HOANG ANH\\source\\repos\\anhvipace\\K010\\TikTokCloneApp\\6004275556721.mp4", UriKind.Absolute);
            videoPlayer.Play();
        }

        // Xử lý sự kiện nút Play
        private void OnPlayClicked(object sender, RoutedEventArgs e)
        {
            videoPlayer.Play();
        }

        // Xử lý sự kiện nút Pause
        private void OnPauseClicked(object sender, RoutedEventArgs e)
        {
            videoPlayer.Pause();
        }

        // Xử lý sự kiện nút Stop
        private void OnStopClicked(object sender, RoutedEventArgs e)
        {
            videoPlayer.Stop();
        }
    }
}
