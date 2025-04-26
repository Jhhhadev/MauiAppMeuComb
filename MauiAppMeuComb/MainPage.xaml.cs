namespace MauiAppMeuComb
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

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando";
                }else
                {
                    msg = "A gasolina está compensando";
                }

                DisplayAlert("Calculado", msg, "OK");


            }catch (Exception ex)
            { //captura uma excessão, caso de algum erro o usuario cai nessa estrutura e exibo uma msg na tela
                DisplayAlert("Ops", ex.Message, "Fechar");
            }



        } //fecha método
    }// fecha class

}//fecha namespace
