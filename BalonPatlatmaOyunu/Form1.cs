namespace BalonPatlatmaOyunu
{
    public partial class Form1 : Form
    {
        List<Button> baloons = new List<Button>();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            BalonOlusturucu.Start();
            BalonD�s�r�c�.Start();
            
        }

        private void BalonOlustur()
        {
            baloons.Add(new Button()
            {
                Width = 40,
                Height = 40,
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = Resource1.karpuz,
                BackgroundImageLayout = ImageLayout.Stretch,
                Location = new Point(new Random().Next(this.Width - 40), 0),
            });
            baloons[i].FlatAppearance.BorderSize = 0;
            baloons[i].Click += Button_Click;
            this.Controls.Add(baloons[i]);
            i++;
        }
        int skor = 0;
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Height = 0;
            Controls.Remove(clickedButton); // T�klanan butonu formdan kald�r
            clickedButton.Dispose(); // Bellekten butonu temizle
            GC.Collect(); //  Garbage Collector(��p toplay�c�s�)
            GC.WaitForPendingFinalizers(); // ��pleri yok et
            skor++;
            lbl_skor.Text = skor.ToString();
        }
        private void DusmeEfekti()
        {
            foreach (Button item in baloons)
            {
                item.Location = new Point(item.Location.X, item.Location.Y + 6);

                if ((item.Location.Y + (item.Height/2) >= this.Height) && item.Height == 40)
                {
                    BalonD�s�r�c�.Stop();
                    BalonOlusturucu.Stop();
                    MessageBox.Show("Maalesef Kaybettiniz!!!");
                }

            }
        }

        private void BalonOlusturucu_Tick(object sender, EventArgs e)
        {
            BalonOlustur();
        }

        private void BalonD�s�r�c�_Tick(object sender, EventArgs e)
        {
            DusmeEfekti();

        }
    }
}
