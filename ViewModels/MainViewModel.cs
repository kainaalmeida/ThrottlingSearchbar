namespace SearchItemsDemo.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private ObservableCollection<string> itemsFiltereds = new ObservableCollection<string>();
    public ObservableCollection<string> ItemsFiltereds
    {
        get => itemsFiltereds;
        set => SetProperty(ref itemsFiltereds, value);
    }

    public ObservableCollection<string> Items { get; }
        = new ObservableCollection<string>();

    public MainViewModel()
    {

    }


    [RelayCommand]
    public async Task Search(string term)
    {
        if (string.IsNullOrEmpty(term))
        {
            ItemsFiltereds = new ObservableCollection<string>(Items);
            return;
        }

        var itemsFiltered = Items
            .Where(x => x.StartsWith(term, StringComparison.InvariantCultureIgnoreCase));

        ItemsFiltereds = new ObservableCollection<string>(itemsFiltered);
    }

    internal void Init()
    {
        Items.Add("Apple");
        Items.Add("Banana");
        Items.Add("Cherry");
        Items.Add("Date");
        Items.Add("Elderberry");
        Items.Add("Fig");
        Items.Add("Grape");

        ItemsFiltereds = new ObservableCollection<string>(Items);
    }

}
