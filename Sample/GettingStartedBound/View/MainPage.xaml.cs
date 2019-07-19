using Syncfusion.XForms.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GettingStartedBound
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private void TreeView_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                //Returns speified item height for items.
                e.Height = 200;
                e.Handled = true;
            }
            else
            {
                // Returns item height based on the content loaded.
                e.Height = e.GetActualNodeHeight();
                e.Handled = true;
            }
        }
    }
}