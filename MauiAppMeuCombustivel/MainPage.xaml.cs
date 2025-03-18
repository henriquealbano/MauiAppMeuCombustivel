namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string mensagem = "";

                if (etanol >= (gasolina * 0.7))
                {
                    mensagem = "O Etanol está compensando!";
                }
                else
                {
                    mensagem = "A Gasolina está compensando!";
                }

                DisplayAlert("Calculado", mensagem, "Ok");

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        }
    }

}
