using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace controls
{
    class MyButton:Button
    {
        public MyButton()
        {
            Width = 300;
            Height = 100;
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            this.Background = brush;
        }

    }
}
