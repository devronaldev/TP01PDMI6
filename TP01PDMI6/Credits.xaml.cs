namespace TP01PDMI6;
	/*
    * PT-BR: Se voc� veio aqui, Eu descobri que ao apagar um XAML voc� tem que apagar nas pastas ou recompilar (Para todos as plataformas) e isso demora, por isso o arquivo n�o foi apagado.
    * Nomes: Ronald Pereira Evangelista e Ariel Martins Alves da Silva
    * Prontu�rios: CB3020282 e CB3021521
    */

	/*
	* EN-US: If you came here, I've discovered if you delete a XAML you must delete in folders or recompile(to all plataforms) and it takes a long, that's why the file wasn't deleted.
	* Names: Ronald Pereira Evangelista and Ariel Martins Alves da Silva
	* College Id: CB3020282 and CB3021521
	*/
public partial class Credits : ContentPage
{
	public Credits()
	{
		InitializeComponent();
	}

	public async void OnBackClicked(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}