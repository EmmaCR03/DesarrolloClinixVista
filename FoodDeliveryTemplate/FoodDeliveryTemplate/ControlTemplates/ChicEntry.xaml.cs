namespace FoodDeliveryTemplate.ControlTemplates;

/// <summary>
/// A control that provides single-line text input. 
/// </summary>

public partial class ChicEntry : ContentView
{
    /// <summary>
    /// The string to be edited.
    /// </summary>

    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(ChicEntry), string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public ChicEntry()
	{
		InitializeComponent();
	}
}