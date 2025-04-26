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
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;             ;

                if (etanol <= (gasolina * 0.7))
                {
                    msg = $"O etanol está compensando para o seu {marca} {modelo}."; //interpolação de strings 
                }else
                {
                    msg = "A Gasolina está compensando" + marca + " " + modelo + "."; //concatenação de strings
                }

                DisplayAlert("Calculado", msg, "OK");


            }catch (Exception ex)
            { //captura uma excessão, caso de algum erro o usuario cai nessa estrutura e exibo uma msg na tela
                DisplayAlert("Ops", ex.Message, "Fechar");
            }



        } //fecha método
    }// fecha class

}//fecha namespace
