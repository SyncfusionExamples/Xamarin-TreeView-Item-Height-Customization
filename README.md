# How to autofit the items based on the content in Xamarin Forms TreeView?

In TreeView, you can customize each item size by using the [QueryNodeSize](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.SfTreeView~QueryNodeSize_EV.html) event. In this event, the [Handled](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.QueryNodeSizeEventArgs~Handled.html) property indicates whether to set specified size for an item or not by its Boolean value. This event is raised when an item comes in view with the [QueryNodeSizeEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.QueryNodeSizeEventArgs.html) argument.

```xml
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.XForms.TreeView;assembly=Syncfusion.SfTreeView.XForms"
             xmlns:local="clr-namespace:GettingStarted"
             x:Class="GettingStarted.MainPage">
    <ContentPage.BindingContext>
       <local:FileManagerViewModel x:Name="viewModel"></local:FileManagerViewModel>
    </ContentPage.BindingContext>
    <ContentPage.Content>
       <syncfusion:SfTreeView x:Name="treeView"
                              QueryNodeSize="TreeView_QueryNodeSize"
                              ChildPropertyName="SubFiles"
                              ItemsSource="{Binding ImageNodeInfo}"/>
       </syncfusion:SfTreeView>
    </ContentPage.Content>
</ContentPage>
```
The [QueryNodeSizeEventArgs.GetActualNodeHeight](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.QueryNodeSizeEventArgs~GetActualNodeHeight.html) method of [QueryNodeSizeEventArgs](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.QueryNodeSizeEventArgs.html) is used to get the measured height of the item based on content and it is set to the [QueryNodeSizeEventArgs.Height](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfTreeView.XForms~Syncfusion.XForms.TreeView.QueryNodeSizeEventArgs~Height.html) property.

```c#
private void TreeView_QueryNodeSize(object sender, QueryNodeSizeEventArgs e)
{
    if (e.Node.Level == 0)
    {
        //Returns speified item height for item.
        e.Height = 200;
        e.Handled = true;
    }
    else
    {
        // Returns measured height based on the content loaded.
        e.Height = e.GetActualNodeHeight();
        e.Handled = true;
    }
}

```
