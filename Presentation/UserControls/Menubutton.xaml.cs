using MahApps.Metro.IconPacks;
using System.Windows;
using System.Windows.Controls;

namespace Presentation.UserControls;

public partial class Menubutton : UserControl
{
    public Menubutton()
    {
        InitializeComponent();
    }

    public PackIconMaterialKind Icon
    {
        get => (PackIconMaterialKind)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
    
    public static readonly DependencyProperty IconProperty = 
        DependencyProperty.Register("Icon", typeof(PackIconMaterialKind), typeof(Menubutton)); 
    
    public bool IsActive
    {
        get => (bool)GetValue(IsActiveProperty);
        set => SetValue(IsActiveProperty, value);
    }
    
    public static readonly DependencyProperty IsActiveProperty = 
        DependencyProperty.Register("IsActive", typeof(bool), typeof(Menubutton)); 
}

