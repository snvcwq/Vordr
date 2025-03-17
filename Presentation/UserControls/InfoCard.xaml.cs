using System.Windows;
using System.Windows.Controls;

namespace Presentation.UserControls;

public partial class InfoCard : UserControl
{
    public InfoCard()
    {
        InitializeComponent();
    }
    
    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }
    
    public static readonly DependencyProperty TitleProperty = 
        DependencyProperty.Register(nameof(Title), typeof(string), typeof(InfoCard)); 
    
    public string Number
    {
        get => (string)GetValue(NumberProperty);
        set => SetValue(NumberProperty, value);
    }
    
    public static readonly DependencyProperty NumberProperty = 
        DependencyProperty.Register(nameof(Number), typeof(string), typeof(InfoCard)); 
    
    public bool IsActive
    {
        get => (bool)GetValue(IsActiveProperty);
        set => SetValue(IsActiveProperty, value);
    }
    
    public static readonly DependencyProperty IsActiveProperty = 
        DependencyProperty.Register(nameof(IsActive), typeof(bool), typeof(InfoCard)); 
    
    public bool IsTechnical
    {
        get => (bool)GetValue(IsTechnicalProperty);
        set => SetValue(IsTechnicalProperty, value);
    }
    
    public static readonly DependencyProperty IsTechnicalProperty = 
        DependencyProperty.Register(nameof(IsTechnical), typeof(bool), typeof(InfoCard)); 
}

