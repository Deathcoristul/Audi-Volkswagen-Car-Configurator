/**************************************************************************
 *                                                                        *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2022, Iliescu Ștefan-Adrian                          *
 *  Description: Clasa ce construiește interfața grafică pentru aplicație.*
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Auto_Configurator
{
    public partial class MainForm : Form
    {
        private readonly string Resources; //folderul resources
        private string firma; //brandul curent
        private readonly string[] culoriAudi; //vector pentru culorile marcii Audi 
        private readonly string[] jentiAudi;//vector pentru jantele marcii Audi 
        private readonly Button[] butoaneCuloriAudi;//vector pentru butoanele culorilor marcii Audi 
        private readonly Button[] butoaneJentiAudi;//vector pentru butoanele jentilor marcii Audi 
        private readonly string[] culoriVW;//vector pentru culorile marcii VW 
        private readonly string[] jentiVW;//vector pentru jantele marcii VW
        private readonly Button[] butoaneCuloriVW;//vector pentru butoanele culorilor marcii VW
        private readonly Button[] butoaneJentiVW;//vector pentru butoanele jentilor marcii VW
        private string selectedColorAudi;//culoarea selectata pentru Audi
        private string selectedWheelAudi;//jantele selectate pentru Audi
        private string selectedColorVW;//culoarea selectata pentru VW
        private string selectedWheelVW;//jantele selectate pentru VW
        private readonly List<List<string>> listaComenzi;//lista comenzilor
        private readonly Bitmap bmp;//imaginea
        private readonly CarFactory factory;//obiect Fabrica de Masini

        /// <summary>
        /// Interfata Aplicatiei
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Size = new Size(1350, 810);
            factory = new CarFactory();
            Resources = "Resources\\";//folder-ul radacina
            listaComenzi = new List<List<string>>();//lista de comenzi pentru a verifica daca se afla comanda specificata
            //AUDI
            firma = "Audi";
            butoaneCuloriAudi = new Button[4];
            culoriAudi = new string[4];
            for (int i = 0; i < 4; i++)
            {
                butoaneCuloriAudi[i] = new Button();//vom crea butoanele pentru culorile pentru Audi
            }
            try{
                butoaneCuloriAudi[0].Image = new Bitmap(Resources + "culori\\albastru.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste albastru.png", "Error");//in caz de lipseste un fisier n-are sens sa nu inseram si restul imaginilor valide
            }
            try{
                butoaneCuloriAudi[1].Image = new Bitmap(Resources + "culori\\gri.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste gri.png", "Error");
            }
            try {
                butoaneCuloriAudi[2].Image = new Bitmap(Resources + "culori\\rosu.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste rosu.png", "Error");
            }
            try { 
                butoaneCuloriAudi[3].Image = new Bitmap(Resources + "culori\\alb.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"Lipseste alb.png", "Error");
            }
            culoriAudi[0] = Resources+"audi\\audi_blue.png";
            culoriAudi[1] = Resources + "audi\\audi_gray.png";
            culoriAudi[2] = Resources + "audi\\audi_red.png";
            culoriAudi[3] = Resources + "audi\\audi_white.png";
            int currentX = 10;
            for (int i = 0; i < 4; i++)
            {
                butoaneCuloriAudi[i].Width = 150;//aranjam butoanele
                butoaneCuloriAudi[i].Height = 150;
                butoaneCuloriAudi[i].Location = new Point(currentX, 250);
                butoaneCuloriAudi[i].Click += new EventHandler(ColorSelect);//instalam callback-ul la fiecare buton
                this.Controls.Add(butoaneCuloriAudi[i]);//adaugam butoanele la lista de controale
                currentX += butoaneCuloriAudi[i].Width;//mutam pozitia curenta
            }
            butoaneJentiAudi = new Button[3];
            jentiAudi = new string[3];
            for (int i = 0; i < 3; i++)
            {
                butoaneJentiAudi[i] = new Button();
            }
            try
            {
                butoaneJentiAudi[0].Image = new Bitmap(Resources + "audi\\JANTE17.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste JANTE17.png", "Error");
            }
            try
            {
                butoaneJentiAudi[1].Image = new Bitmap(Resources + "audi\\JANTE18.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste JANTE18.png", "Error");
            }
            try
            {
                butoaneJentiAudi[2].Image = new Bitmap(Resources + "audi\\JANTE19.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste JANTE19.png", "Error");
            }
            jentiAudi[0] = Resources + "audi\\audi_17.png";//locatia imaginii
            jentiAudi[1] = Resources + "audi\\audi_18.png";
            jentiAudi[2] = Resources + "audi\\audi_19.png";
            currentX = 10;
            for (int i = 0; i < 3; i++)
            {
                butoaneJentiAudi[i].Width = 150;//acelasi lucru ca la butoanele de culori
                butoaneJentiAudi[i].Height = 150;
                butoaneJentiAudi[i].Location = new Point(currentX, 450);
                butoaneJentiAudi[i].Click += new EventHandler(WheelSelect);
                this.Controls.Add(butoaneJentiAudi[i]);
                currentX += butoaneJentiAudi[i].Width;
            }
            selectedColorAudi = Resources + "audi\\audi_blue.png";
            selectedWheelAudi = Resources + "audi\\audi_17.png";
            bmp = new Bitmap(1000, 500);//pentru pictureBox vom lucra neaparat cu un bitmap
            Draw();
            //Volkswagen
            butoaneCuloriVW = new Button[4];
            culoriVW = new string[4];
            for (int i = 0; i < 4; i++)
            {
                butoaneCuloriVW[i] = new Button();
            }
            try
            {
                butoaneCuloriVW[0].Image = new Bitmap(Resources + "culori\\albastru.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste albastru.png", "Error");//in caz de lipseste un fisier n-are sens sa nu inseram si restul imaginilor valide
            }
            try
            {
                butoaneCuloriVW[1].Image = new Bitmap(Resources + "culori\\mov.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste mov.png", "Error");//in caz de lipseste un fisier n-are sens sa nu inseram si restul imaginilor valide
            }
            try
            {
                butoaneCuloriVW[2].Image = new Bitmap(Resources + "culori\\rosu.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste rosu.png", "Error");//in caz de lipseste un fisier n-are sens sa nu inseram si restul imaginilor valide
            }
            try
            {
                butoaneCuloriVW[3].Image = new Bitmap(Resources + "culori\\alb.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste alb.png", "Error");//in caz de lipseste un fisier n-are sens sa nu inseram si restul imaginilor valide
            }
            culoriVW[0] = Resources + "vw\\vw_blue.png";
            culoriVW[1] = Resources + "vw\\vw_purple.png";
            culoriVW[2] = Resources + "vw\\vw_red.png";
            culoriVW[3] = Resources + "vw\\vw_white.png";
            currentX = 10;
            for (int i = 0; i < 4; i++)
            {
                butoaneCuloriVW[i].Width = 150;
                butoaneCuloriVW[i].Height = 150;
                butoaneCuloriVW[i].Location = new Point(currentX, 250);
                butoaneCuloriVW[i].Click += new EventHandler(ColorSelect);
                this.Controls.Add(butoaneCuloriVW[i]);
                currentX += butoaneCuloriVW[i].Width;
            }
            butoaneJentiVW = new Button[2];
            jentiVW = new string[2];
            for (int i = 0; i < 2; i++)
            {
                butoaneJentiVW[i] = new Button();
            }
            try
            {
                butoaneJentiVW[0].Image = new Bitmap(Resources + "vw\\JANTE16.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste JANTE16.png", "Error");
            }
            try
            {
                butoaneJentiVW[1].Image = new Bitmap(Resources + "vw\\JANTE17.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Lipseste JANTE17.png", "Error");
            }
            jentiVW[0] = Resources + "vw\\vw_16.png";
            jentiVW[1] = Resources + "vw\\vw_17.png";
            selectedColorVW = Resources + "vw\\vw_blue.png";
            selectedWheelVW = Resources + "vw\\vw_16.png";
            currentX = 10;
            for (int i = 0; i < 2; i++)
            {
                butoaneJentiVW[i].Width = 150;
                butoaneJentiVW[i].Height = 150;
                butoaneJentiVW[i].Location = new Point(currentX, 450);
                butoaneJentiVW[i].Click += new EventHandler(WheelSelect);
                this.Controls.Add(butoaneJentiVW[i]);
                currentX += butoaneJentiVW[i].Width;
            }
        }

        /// <summary>
        /// Buton alegere marca Audi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AudiButton_Click(object sender, EventArgs e)
        {
            firma = "Audi";
            for(int i = 0; i < 4; i++)//vom face vizibile si active DOAR controalele necesare brand-ului Audi
            {
                butoaneCuloriAudi[i].Enabled = true;
                butoaneCuloriAudi[i].Visible = true;
                butoaneCuloriVW[i].Enabled = false;
                butoaneCuloriVW[i].Visible = false;
            }
            for(int i=0;i<3;i++)
            {
                butoaneJentiAudi[i].Enabled = true;
                butoaneJentiAudi[i].Visible = true;
            }
            for (int i = 0; i < 2; i++)
            {
                butoaneJentiVW[i].Enabled = false;
                butoaneJentiVW[i].Visible = false;
            }
            Draw();
        }


        /// <summary>
        /// Buton selectare VW
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VwButton_Click(object sender, EventArgs e)
        {
            firma = "Vw";
            for (int i = 0; i < 4; i++)//vom face vizibile DOAR controalele necesare brand-ului Vw
            {
                butoaneCuloriAudi[i].Enabled = false;
                butoaneCuloriAudi[i].Visible = false;
                butoaneCuloriVW[i].Enabled = true;
                butoaneCuloriVW[i].Visible = true;
            }
            for (int i = 0; i < 3; i++)
            {
                butoaneJentiAudi[i].Enabled = false;
                butoaneJentiAudi[i].Visible = false;
            }
            for (int i = 0; i < 2; i++)
            {
                butoaneJentiVW[i].Enabled = true;
                butoaneJentiVW[i].Visible = true;
            }
            Draw();
        }

        /// <summary>
        /// Buton selectare culoare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorSelect(object sender,EventArgs e)
        {
            Button bt = (Button)sender;
            int index = 0;//index-ul de verificare in vector
            if(firma.Equals("Audi"))
            {
                for(int i=0;i<butoaneCuloriAudi.Length;i++)
                {
                    if (bt.Equals(butoaneCuloriAudi[i]))
                        index = i;//vedem care buton din lista se aseamana cu cel apasat
                }
                selectedColorAudi = culoriAudi[index];//si selectam folosind index-ul aflat, partea spre imaginea corpului
                Draw();//si desenam in acelasi timp
            }
            else if(firma.Equals("Vw"))
            {
                for (int i = 0; i < butoaneCuloriVW.Length; i++)
                {
                    if (bt.Equals(butoaneCuloriVW[i]))
                        index = i;
                }
                selectedColorVW = culoriVW[index];
                Draw();
            }
        }

        /// <summary>
        /// Buton selectare jante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WheelSelect(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            int index = 0;//index-ul de verificare in vector
            if (firma.Equals("Audi"))
            {
                for (int i = 0; i < butoaneJentiAudi.Length; i++)
                {
                    if (bt.Equals(butoaneJentiAudi[i]))
                        index = i;//vedem care buton din lista se aseamana cu cel apasat
                }
                selectedWheelAudi = jentiAudi[index];//si selectam folosind index-ul aflat, partea spre imaginea corpului
                Draw();
            }
            else if (firma.Equals("Vw"))
            {
                for (int i = 0; i < butoaneJentiVW.Length; i++)
                {
                    if (bt.Equals(butoaneJentiVW[i]))
                        index = i;
                }
                selectedWheelVW = jentiVW[index];
                Draw();
            }
        }

        /// <summary>
        /// Desenarea Masinii
        /// </summary>
        private void Draw()
        {
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.Clear(Color.Transparent);//se curata imaginea
                if (firma.Equals("Audi"))
                {
                    try
                    {
                        graphics.DrawImage(new Bitmap(selectedColorAudi), new Point(0, 0));//culoarea corpului
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + " Corp lipsa");
                    }
                    try
                    {
                        graphics.DrawImage(new Bitmap(selectedWheelAudi), new Point(0, 0));//janta
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show(e.Message + " Janta lipsa");
                    }
                }
                else if (firma.Equals("Vw"))
                {
                    try {
                        graphics.DrawImage(new Bitmap(selectedColorVW), new Point(0, 0));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + " Corp lipsa");
                    }
                    try
                    {
                        graphics.DrawImage(new Bitmap(selectedWheelVW), new Point(0, 0));
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message + " Janta lipsa");
                    }
                }
            }
            car.SizeMode = PictureBoxSizeMode.AutoSize;
            car.Image = bmp;
        }


        /// <summary>
        /// Buton de Comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Order_Click(object sender, EventArgs e)
        {
            string color="unknown",wheel="unknown";
            Car masina;
            if (firma.Equals("Audi"))
            {
                try{color = selectedColorAudi.Split('\\')[2].Split('_')[1].Split('.')[0]; }//extragem cuvantul care trebuie din numele locatiei imaginii
                catch (IndexOutOfRangeException) { }//daca locatia e gresita, va ramane unknown, si la fereastra noua cand vrem afisarea comenzii
                try { wheel = selectedWheelAudi.Split('\\')[2].Split('_')[1].Split('.')[0]; }
                catch (IndexOutOfRangeException) { }
                List<string> options = new List<string>();//cu aceasta lista de optiuni,fabricam masina
                options.Add(color); options.Add(wheel);
                try { 
                    masina = factory.MakeCar("Audi", options);//fabrica realizeaza masina
                    TextAreaOrderHistory.Text += "S-a plasat comanda pentru un ";
                    List<string> comanda = new List<string>();//lista de specificatii pe care o adaugam la lista de comenzi
                    comanda.Add(masina.GetOrderNumber().ToString());
                    comanda.Add(color);
                    comanda.Add(wheel);
                    comanda.Add(firma);
                    listaComenzi.Add(comanda);
                    TextAreaOrderHistory.Text += "Audi de culoare " + color + " cu jante de " + wheel + " inch și număr de comandă " + masina.GetOrderNumber();//inseram in istoric
                }
                catch(Exception ex) {
                    TextAreaOrderHistory.Text+=ex.Message; 
                }
                
            }
            else if (firma.Equals("Vw"))
            {
                try { color = selectedColorVW.Split('\\')[2].Split('_')[1].Split('.')[0]; }//extragem cuvantul care trebuie din numele locatiei imaginii
                catch (IndexOutOfRangeException) { }//daca locatia e gresita, va ramane unknown, si la fereastra noua cand vrem afisarea comenzii

                try { wheel = selectedWheelVW.Split('\\')[2].Split('_')[1].Split('.')[0]; }
                catch (IndexOutOfRangeException) { }
                List<string> options = new List<string>();//cu aceasta lista de optiuni,fabricam masina
                options.Add(color); options.Add(wheel);
                try
                {
                    masina = factory.MakeCar("Vw", options);//fabrica realizeaza masina
                    TextAreaOrderHistory.Text += "S-a plasat comanda pentru un ";
                    List<string> comanda = new List<string>();//lista de specificatii pe care o adaugam la lista de comenzi
                    comanda.Add(masina.GetOrderNumber().ToString());
                    comanda.Add(color);
                    comanda.Add(wheel);
                    comanda.Add(firma);
                    listaComenzi.Add(comanda);
                    TextAreaOrderHistory.Text += "Volkswagen de culoare " + color + " cu jante de " + wheel + " inch și număr de comandă " + masina.GetOrderNumber();//inseram in istoric
                }
                catch (Exception ex)
                {
                    TextAreaOrderHistory.Text += ex.Message;
                }
            }
            TextAreaOrderHistory.Text += "\r\n";
        }


        /// <summary>
        /// Buton afisare Comanda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowOrder_Click(object sender, EventArgs e)
        {
            if (OnlyNumbers(TextBoxID.Text))
            {
                List<string> masina = null;
                foreach (List<string> com in listaComenzi)
                {
                    if (com[0].Equals(TextBoxID.Text))
                        masina = com;//verificam daca in lista de comenzi se afla comanda ceruta
                }
                if(masina!=null)
                {
                    Form fereastra = new Form();//vom crea o noua fereastra
                    fereastra.Text = "Comanda " + TextBoxID.Text;
                    fereastra.Size = new Size(900, 500);
                    fereastra.Show();
                    PictureBox pb = new PictureBox();//vom crea un PictureBox aferent ferestrei noi
                    fereastra.Controls.Add(pb);//adaugam pictureBox-ul la controalele ferestrei noi
                    using (var graphics = Graphics.FromImage(bmp))
                    {
                        graphics.Clear(Color.Transparent);
                        try {
                            graphics.DrawImage(new Bitmap(Resources + masina[3] + "\\" + masina[3] + "_" + masina[1] + ".png"), new Point(0, 0));//culoare corp
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " Corp lipsa");
                        }
                        try
                        {
                            graphics.DrawImage(new Bitmap(Resources + masina[3] + "\\" + masina[3] + "_" + masina[2] + ".png"), new Point(0, 0));//janta
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message + " Janta lipsa");
                        }
                    }
                    pb.SizeMode = PictureBoxSizeMode.AutoSize;
                    pb.Image = bmp;
                }
                else
                    MessageBox.Show("Numărul de comandă nu există în baza noastră de date.", "ERROR");
            }
            else
                MessageBox.Show("Numărul de comandă trebuie să fie întreg.", "WARNING");
        }

        /// <summary>
        /// Verifica daca stringul este format doar din numere
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool OnlyNumbers(string s)
        {
            if (s.Equals(""))
                return false;
            foreach(char c in s)
            {
                if (c < '0' || c > '9')//sirul de caractere trebuie sa contina cifre
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Buton Meniu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DespreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Configurator Auto - Proiect la disciplina Ingineria Programării\r\n" +
                "Studenți:Cristea Adrian grupa 1310A\r\n"+
                "Dimitriu Emilian grupa 1310A\r\n" +
                "Iliescu Ștefan-Adrian grupa 1310A\r\n" +
                "Rusu Mitică-Eusebiu grupa 1309A","Despre");
        }


        /// <summary>
        /// Buton Help
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AjutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Configurator Auto.chm");     
        }
    }
}
