namespace TP01PDMI6;
    /*
    * PT-BR: Se você veio aqui, Eu descobri que ao apagar um XAML você tem que apagar nas pastas ou recompilar (Para todos as plataformas) e isso demora, por isso o arquivo não foi apagado.
    * Nomes: Ronald Pereira Evangelista e Ariel Martins Alves da Silva
    * Prontuários: CB3020282 e CB3021521
    */

    /*
    * EN-US: If you came here, I've discovered if you delete a XAML you must delete in folders or recompile(to all plataforms) and it takes a long, that's why the file wasn't deleted.
    * Names: Ronald Pereira Evangelista and Ariel Martins Alves da Silva
    * College Id: CB3020282 and CB3021521
    */
public partial class InputPage : ContentPage
{
	public InputPage()
	{
		InitializeComponent();
	}

	private async void OnOkClicked(object sender, EventArgs e)
	{
		string id = IdEntry.Text;
		string password = PasswordEntry.Text;
        string title = "";
        string message = "";
        string Btn = "Fechar";

		if (!id.Equals("admin"))
		{
            title = "Não autorizado";
            message = "Usuário ou senha incorretos";

        }
        else if (!password.Equals("senha@dmin"))
        {
            title = "Não autorizado";
            message = "Usuário ou senha incorretos";
        }
        else
        {
            title = "Autorizado";
            message = "Id e senha corretos";
        }

        await DisplayAlert(title, message, Btn);
        OnCleanClicked(sender, e);
    }

    private void OnCleanClicked(object sender, EventArgs e)
    {
		IdEntry.Text = "";
        PasswordEntry.Text = "";
    }

    private async void OnCreditsClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Credits());
    }
}