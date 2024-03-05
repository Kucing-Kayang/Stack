
using Microsoft.Maui.Controls;
using System;

    namespace ProjectMaui
{
    public partial class MainPage : ContentPage
    {
        private Stack<string> stack = new Stack<string>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnPushClicked(object sender, EventArgs e)
        {
            stack.Push(inputEntry.Text);
            inputEntry.Text = string.Empty;
            UpdateStackListView();
        }

        private void OnPopClicked(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                outputEntry.Text = stack.Pop();
                UpdateStackListView();
            }
            else
            {
                DisplayAlert("Alert", "Stack is empty", "OK");
            }
        }

        private void OnPeekClicked(object sender, EventArgs e)
        {
            if (stack.Count > 0)
            {
                outputEntry.Text = stack.Peek();
            }
            else
            {
                DisplayAlert("Alert", "Stack is empty", "OK");
            }
        }

        private void UpdateStackListView()
        {
            stackListView.ItemsSource = null;
            stackListView.ItemsSource = stack;
        }
    }
}