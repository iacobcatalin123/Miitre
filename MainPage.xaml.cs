using client_manager_maui.Models;

namespace client_manager_maui;

public partial class MainPage : ContentPage
{
    public string nume_client {get;set;}
    public string ora_programarii { get; set; }
    public DateTime ziua_programarii { get; set; }
    public string numar_telefon { get; set; }
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

	}

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        ziua_programarii = ((DatePicker)sender).Date;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
		((Entry)sender).Unfocus();
        nume_client = ((Entry)sender).Text;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        //add to database
        App.Repository.Add(new ProgramareModel
        {
            NumeClient = nume_client,
            OraProgramarii = ora_programarii,
            ZiuaProgramarii = ziua_programarii.Date,
            Numar_telefon = numar_telefon
        });

        
       
    }


    private void TimePicker_Unfocused(object sender, FocusEventArgs e)
    {
        ora_programarii = ((TimePicker)sender).Time.ToString();
    }

    private void Entry_Completed_1(object sender, EventArgs e)
    {
        numar_telefon = ((Entry)sender).Text;
        ((Entry)sender).Unfocus();
         
    }
}

