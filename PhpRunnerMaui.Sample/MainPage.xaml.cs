namespace PhpRunnerMaui.Sample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        PRMaui.ServerApi = "http://**********/api";
    }

    private async void OnList(object sender, EventArgs e)
    {
        List<Confirm> all = await PRMaui.Service.List<Confirm>();
        if (all != null)
            foreach (var item in all)
            {
                System.Diagnostics.Debug.WriteLine(item.Id + " ::::: " + item.Name);
            }
    }

    private async void OnAdd(object sender, EventArgs e)
    {
        Confirm item = await PRMaui
            .Service.Insert(new Confirm
            {
                Name = "Lixo Z",
                Date = DateTime.Now,
                CompanyId = 4,
                ByStudent = true,
                ByTeacher = false

            });
        if (item != null)
            System.Diagnostics.Debug.WriteLine(item?.Id + " ::::: " + item?.Name);
    }

    private async void OnFilter(object sender, EventArgs e)
    {
        
        List<Confirm> all = await PRMaui.Service.Search<Confirm>(
            new List<PhpRunnerFilter> {
                new PhpRunnerFilter { Field = "class_id", Filter = PhpRunnerFilter.Equals, Value = "5" },
                new PhpRunnerFilter { Field = "student_id", Filter = PhpRunnerFilter.Equals, Value = "7" }
            }
            );
        if (all != null)
            foreach (var item in all)
            {
                System.Diagnostics.Debug.WriteLine(item.Id + " ::::: " + item.Name);
            }
    }
}