namespace PhpRunnerMaui.Sample;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        PhpRunnerMaui.ServerApi = "http://********************";
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        List<ClassAll> classAlls = await PhpRunnerMaui.Service.List<ClassAll>();
        foreach (var item in classAlls)
        {
            System.Diagnostics.Debug.WriteLine("::::: " + item.teacher);
        }
    }

    public class ClassAll
    {
        public string id { get; set; }
        public string curse_id { get; set; }
        public string company_id { get; set; }
        public string student_id { get; set; }
        public string teacher_id { get; set; }
        public string days { get; set; }
        public string duration { get; set; }
        public string evaluation_period { get; set; }
        public string hours { get; set; }
        public string active { get; set; }
        public string company { get; set; }
        public string teacher { get; set; }
        public string student { get; set; }
        public string curse { get; set; }
    }
}