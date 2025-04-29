namespace FoodDeliveryTemplate.ControlTemplates;

/// <summary>
/// A control that provides multi-line text input. 
/// </summary>

public partial class ChicEditor : ContentView
{
    /// <summary>
    /// To set and read the text presented by the Editor.
    /// </summary>
    public static readonly BindableProperty TextProperty =
        BindableProperty.Create(nameof(Text), typeof(string), typeof(ChicEditor), string.Empty);

    /// <summary>
    /// A hint shown if there is no user input.
    /// </summary>
    public static readonly BindableProperty PlaceholderProperty =
        BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(ChicEditor), string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public ChicEditor()
	{
		InitializeComponent();
	}
}