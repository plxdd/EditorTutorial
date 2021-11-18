using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EditorTutorial
{
    public partial class MainPage : ContentPage
    {

        void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
        }

        void OnEditorCompleted(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
