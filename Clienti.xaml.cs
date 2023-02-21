namespace client_manager_maui;

public partial class Clienti : ContentPage
{
    public class Clienti_Model
    {
        public string NumeClient { get; set; }
        public string OraProgramarii { get; set; }
        public string ZiuaProgramarii { get; set; }
        public string Numar_telefon { get; set; }

    }

    public List<string> patient_names { get; set; }
    public List<string> time { get; set; }
    public List<DateTime> date { get; set; }
    public List<string> Numar_telefon { get; set; }
    public Clienti()
    {
        InitializeComponent();

        patient_names = new List<string>();
        time = new List<string>();
        date = new List<DateTime>();
        Numar_telefon = new List<string>();

        App.Repository.GetAll().ForEach(x =>
        {
            patient_names.Add(x.NumeClient);
            time.Add(x.OraProgramarii);
            date.Add(x.ZiuaProgramarii);
            Numar_telefon.Add(x.Numar_telefon);
        });

        List<Clienti_Model> clienti_all = new List<Clienti_Model>();
        for (int i = 0; i < patient_names.Count; i++)
        {
            clienti_all.Add(new Clienti_Model
            {
                NumeClient = patient_names[i],
                OraProgramarii = time[i],
                ZiuaProgramarii = date[i].ToString(),
                Numar_telefon = Numar_telefon[i]
            });
        }

        //render the data in the listview
        listClienti.ItemsSource = clienti_all;


    }

    private void VerticalStackLayout_Loaded(object sender, EventArgs e)
    {

    }

    private void VerticalStackLayout_Focused(object sender, FocusEventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
    



    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        var selected_item = listClienti.SelectedItem;
        //get the name of the selected item
        var selected_item_name = ((Clienti_Model)selected_item).NumeClient;
        //get the item from the db
        var item = App.Repository.GetAll().Where(x => x.NumeClient == selected_item_name).FirstOrDefault();
        //remove the item from the db
        App.Repository.Delete(item);    
    }
}