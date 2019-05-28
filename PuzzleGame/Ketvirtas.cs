using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Ketvirtas : UserControl
    {
        string miestas = Globals.TOWN;

        public Ketvirtas()
        {
            InitializeComponent();
        }

        private void Ketvirtas_Load(object sender, EventArgs e)
        {
            int miestas = Globals.getTOWN();
            button1pirmo.Enabled = true;

            if (miestas == 1)
            {
                miestasLabel.Text = "NIUJORKAS";
                klausimoPirmoLabel.Text = "Kokios tautybės gyventojų Niujorke gyvena daugiau nei " +
                    "bet kuriame kitame mieste už Azijos ribų?";
                button1pirmo.Text = "A) Japonų ";
                button2pirmo.Text = "B) Kinų ";
                button3pirmo.Text = "C) Lietuvių ";
                button4pirmo.Text = "D) Vietnamiečių ";

                klausimoAntroLabel.Text = "Kiek skirtingų kalbų kalba skirtingi Niujorko gyventojai?";
                button1antro.Text = "A) 700 ";
                button2antro.Text = "B) 750 ";
                button3antro.Text = "C) 800 ";
                button4antro.Text = "D) 850 ";

                klausimoTrecioLabel.Text = "Kelinta pagal dydį pasaulyje yra Niujorko viešoji biblioteka?";
                button1trecio.Text = "D) Ketvirta ";
                button2trecio.Text = "C) Trečia ";
                button3trecio.Text = "B) Antra ";
                button4trecio.Text = "A) Pirma ";
            }

            if (miestas == 2)
            {
                miestasLabel.Text = "TOKIJAS";
                klausimoPirmoLabel.Text = "Koks yra nacionalinis Japonijos simbolis?";
                button1pirmo.Text = "A) Obelis ";
                button2pirmo.Text = "B) Kriaušė ";
                button3pirmo.Text = "C) Vyšnia ";
                button4pirmo.Text = "D) Šilauogė ";

                klausimoAntroLabel.Text = "Kaip Tokijo traukinių stotyse yra vadinami žmonės, kurie stumia žmones į traukinius?";
                button1antro.Text = "A) stumikais ";
                button2antro.Text = "B) padėjėjais ";
                button3antro.Text = "C) prižiūrėtojais ";
                button4antro.Text = "D) pastumdėliais ";

                klausimoTrecioLabel.Text = "Kas Tokijuje yra prienama kas 12 metrų, kur galima nusipirkti bet ko?";
                button1trecio.Text = "A) Restoranai ";
                button2trecio.Text = "B) Bibliotekos ";
                button3trecio.Text = "C) Perėjos ";
                button4trecio.Text = "D) Pardavimo automatai ";
            }

            if (miestas == 3)
            {
                miestasLabel.Text = "VILNIUS";
                klausimoPirmoLabel.Text = "Ko Vilniuje gyvena daugiau?";
                button1pirmo.Text = "A) Vyrų ";
                button2pirmo.Text = "B) Moterų ";
                button3pirmo.Text = "C) Tikrai moterų ";
                button4pirmo.Text = "D) Tikrai vyrų ";

                klausimoAntroLabel.Text = "Kaip Vilnius buvo vadinamas iki XXa. vidurio?";
                button1antro.Text = "A) Šiaurės Jeruzale ";
                button2antro.Text = "B) Pietų Jeruzale ";
                button3antro.Text = "C) Rytų Jeruzale ";
                button4antro.Text = "D) Vakarų Jeruzale ";

                klausimoTrecioLabel.Text = "Kiek procentų Vilniaus ploto yra užstatyta?";
                button1trecio.Text = "A) 50,6 % ";
                button2trecio.Text = "B) 45,3 % ";
                button3trecio.Text = "D) 15,7 % ";
                button4trecio.Text = "C) 20,2 % ";            }
            if (miestas == 4)
            {
                miestasLabel.Text = "KAUNAS";
                klausimoPirmoLabel.Text = "Kas Kaune atstoja Barselonos „Las Ramblas“ ar Niujorko „Broadway“?";
                button1pirmo.Text = "A) Rotušės aikštė ";
                button2pirmo.Text = "B) Laisvės alėja ";
                button3pirmo.Text = "C) Kauno pilisų ";
                button4pirmo.Text = "D) Vyčio statula ";

                klausimoAntroLabel.Text = "Kuris pagal dydį miestas Lietuvoje yra Kaunas?";
                button1antro.Text = "A) Antras ";
                button2antro.Text = "B) Trečias ";
                button3antro.Text = "C) Ketvirtas ";
                button4antro.Text = "D) Šeštas ";

                klausimoTrecioLabel.Text = "Kaip vadinasi paminklas rutinai ir kitos meniškos įdomybės Kaune?";
                button1trecio.Text = "A) Karo muziejus ";
                button2trecio.Text = "B) Laisvės alėja ";
                button3trecio.Text = "C) Kiemo galerija ";
                button4trecio.Text = "D) Kauno pilis ";
            }
            if (miestas == 5)
            {
                miestasLabel.Text = "SEULAS";
                klausimoPirmoLabel.Text = "Nuo kurių metų Seulas yra laikomas sostine?";
                button1pirmo.Text = "A) 1948 m. ";
                button2pirmo.Text = "B) 1949 m. ";
                button3pirmo.Text = "C) 1950 m. ";
                button4pirmo.Text = "D) 1951 m. ";

                klausimoAntroLabel.Text = "Kokios dainos garbei yra pastatytas paminklas Seule?";
                button1antro.Text = "A) „Despacito“ ";
                button2antro.Text = "B) „Gangnam style“ ";
                button3antro.Text = "C) „Du gaideliai“ ";
                button4antro.Text = "D) „Baby“ ";

                klausimoTrecioLabel.Text = "Kuo ypatingos „Antistress“ kavinės Seule?";
                button1trecio.Text = "C) Jose laisvai vaikšto gyvūnai ";
                button2trecio.Text = "A) Jose auga grybai ";
                button3trecio.Text = "B) Stiklinis stogas ";
                button4trecio.Text = "D) Visada groja metalo muzika ";
            }
            if (miestas == 6)
            {
                miestasLabel.Text = "PARYŽIUS";
                klausimoPirmoLabel.Text = "Kada pastatytas Eifelio bokštas?";
                button1pirmo.Text = "A) 1880 m. ";
                button2pirmo.Text = "B) 1889 m. ";
                button3pirmo.Text = "C) 1891 m. ";
                button4pirmo.Text = "D) 1875 m. ";

                klausimoAntroLabel.Text = "Kiek Paryžiuje gyvena gyventojų?";
                button1antro.Text = "A) 2,2 mln. ";
                button2antro.Text = "B) 3,2 mln. ";
                button3antro.Text = "C) 2,7 mln. ";
                button4antro.Text = "D) 1,8 mln. ";

                klausimoTrecioLabel.Text = "Ką simbolizuoja Paryžiuje taip pat stovinti Laisvės \n" +
                    "statula, kuri yra atgręžta į Niujorko Laisvės statulą?";
                button1trecio.Text = "A) Paryžiečiai nukopijavo \n Niujorkiečius ";
                button2trecio.Text = "B) Dviejų šalių konkuravimą ";
                button3trecio.Text = "C) Dviejų šalių draugystę ";
                button4trecio.Text = "D) Meilę laisvei ";
            }
        }
  

        private void button1pirmo_Click(object sender, EventArgs e)
        {
            if (klausimoPirmoLabel.Text == "Kokios tautybės gyventojų Niujorke gyvena daugiau nei " +
                    "bet kuriame kitame mieste už Azijos ribų?" ||
                klausimoPirmoLabel.Text == "Koks yra nacionalinis Japonijos simbolis?" ||
                klausimoPirmoLabel.Text == "Ko Vilniuje gyvena daugiau?" ||
                klausimoPirmoLabel.Text == "Kada pastatytas Eifelio bokštas?" ||
                klausimoPirmoLabel.Text == "Kas Kaune atstoja Barselonos „Las Ramblas“ ar Niujorko „Broadway“?")
            {
                button1pirmo.BackColor = Color.Red;
            }
            if (klausimoPirmoLabel.Text == "Nuo kurių metų Seulas yra laikomas sostine?")
            {
                button1pirmo.BackColor = Color.Green;
            }
        }

        private void button2pirmo_Click(object sender, EventArgs e)
        {
            if (klausimoPirmoLabel.Text == "Koks yra nacionalinis Japonijos simbolis?" ||
                klausimoPirmoLabel.Text == "Nuo kurių metų Seulas yra laikomas sostine?")
            {
                button2pirmo.BackColor = Color.Red;
            }
            if (klausimoPirmoLabel.Text == "Kokios tautybės gyventojų Niujorke gyvena daugiau nei " +
                    "bet kuriame kitame mieste už Azijos ribų?" ||
                klausimoPirmoLabel.Text == "Ko Vilniuje gyvena daugiau?" ||
                klausimoPirmoLabel.Text == "Kada pastatytas Eifelio bokštas?" ||
                klausimoPirmoLabel.Text == "Kas Kaune atstoja Barselonos „Las Ramblas“ ar Niujorko „Broadway“?")
            {
                button2pirmo.BackColor = Color.Green;
            }
        }

        private void button3pirmo_Click(object sender, EventArgs e)
        {
            if (klausimoPirmoLabel.Text == "Kokios tautybės gyventojų Niujorke gyvena daugiau nei " +
                    "bet kuriame kitame mieste už Azijos ribų?" ||
                klausimoPirmoLabel.Text == "Kada pastatytas Eifelio bokštas?" ||
                klausimoPirmoLabel.Text == "Kas Kaune atstoja Barselonos „Las Ramblas“ ar Niujorko „Broadway“?" ||
                klausimoPirmoLabel.Text == "Nuo kurių metų Seulas yra laikomas sostine?")
            {
                button3pirmo.BackColor = Color.Red;
            }
            if (klausimoPirmoLabel.Text == "Koks yra nacionalinis Japonijos simbolis?" ||
                klausimoPirmoLabel.Text == "Ko Vilniuje gyvena daugiau?")
            {
                button3pirmo.BackColor = Color.Green;
            }
        }

        private void button4pirmo_Click(object sender, EventArgs e)
        {
            if (klausimoPirmoLabel.Text == "Kokios tautybės gyventojų Niujorke gyvena daugiau nei " +
                    "bet kuriame kitame mieste už Azijos ribų?" ||
                klausimoPirmoLabel.Text == "Koks yra nacionalinis Japonijos simbolis?" ||
                klausimoPirmoLabel.Text == "Ko Vilniuje gyvena daugiau?" ||
                klausimoPirmoLabel.Text == "Kada pastatytas Eifelio bokštas?" ||
                klausimoPirmoLabel.Text == "Kas Kaune atstoja Barselonos „Las Ramblas“ ar Niujorko „Broadway“?" ||
                klausimoPirmoLabel.Text == "Nuo kurių metų Seulas yra laikomas sostine?")
            {
                button4pirmo.BackColor = Color.Red;
            }
        }

        private void button1antro_Click(object sender, EventArgs e)
        {
            if (klausimoAntroLabel.Text == "Kiek skirtingų kalbų kalba skirtingi Niujorko gyventojai?" ||
                klausimoAntroLabel.Text == "Kokios dainos garbei yra pastatytas paminklas Seule?")
            {
                button1antro.BackColor = Color.Red;
            }
            if (klausimoAntroLabel.Text == "Kaip Tokijo traukinių stotyse yra vadinami žmonės, kurie stumia žmones į traukinius?" ||
                klausimoAntroLabel.Text == "Kaip Vilnius buvo vadinamas iki XXa. vidurio?" ||
                klausimoAntroLabel.Text == "Kiek Paryžiuje gyvena gyventojų?" ||
                klausimoAntroLabel.Text == "Kuris pagal dydį miestas Lietuvoje yra Kaunas?")
            {
                button1antro.BackColor = Color.Green;
            }
        }

        private void button2antro_Click(object sender, EventArgs e)
        {
            if (klausimoAntroLabel.Text == "Kiek skirtingų kalbų kalba skirtingi Niujorko gyventojai?" ||
                klausimoAntroLabel.Text == "Kaip Tokijo traukinių stotyse yra vadinami žmonės, kurie stumia žmones į traukinius?" ||
                klausimoAntroLabel.Text == "Kaip Vilnius buvo vadinamas iki XXa. vidurio?" ||
                klausimoAntroLabel.Text == "Kiek Paryžiuje gyvena gyventojų?" ||
                klausimoAntroLabel.Text == "Kuris pagal dydį miestas Lietuvoje yra Kaunas?")
            {
                button2antro.BackColor = Color.Red;
            }
            if (klausimoAntroLabel.Text == "Kokios dainos garbei yra pastatytas paminklas Seule?")
            {
                button2antro.BackColor = Color.Green;
            }
        }

        private void button3antro_Click(object sender, EventArgs e)
        {
            if (klausimoAntroLabel.Text == "Kaip Tokijo traukinių stotyse yra vadinami žmonės, kurie stumia žmones į traukinius?" ||
                klausimoAntroLabel.Text == "Kaip Vilnius buvo vadinamas iki XXa. vidurio?" ||
                klausimoAntroLabel.Text == "Kiek Paryžiuje gyvena gyventojų?" ||
                klausimoAntroLabel.Text == "Kuris pagal dydį miestas Lietuvoje yra Kaunas?" ||
                klausimoAntroLabel.Text == "Kokios dainos garbei yra pastatytas paminklas Seule?")
            {
                button3antro.BackColor = Color.Red;
            }
            if (klausimoAntroLabel.Text == "Kiek skirtingų kalbų kalba skirtingi Niujorko gyventojai?")
            {
                button3antro.BackColor = Color.Green;
            }
        }

        private void button4antro_Click(object sender, EventArgs e)
        {
            if (klausimoAntroLabel.Text == "Kiek skirtingų kalbų kalba skirtingi Niujorko gyventojai?" ||
                klausimoAntroLabel.Text == "Kaip Tokijo traukinių stotyse yra vadinami žmonės, kurie stumia žmones į traukinius?" ||
                klausimoAntroLabel.Text == "Kaip Vilnius buvo vadinamas iki XXa. vidurio?" ||
                klausimoAntroLabel.Text == "Kiek Paryžiuje gyvena gyventojų?" ||
                klausimoAntroLabel.Text == "Kuris pagal dydį miestas Lietuvoje yra Kaunas?" ||
                klausimoAntroLabel.Text == "Kokios dainos garbei yra pastatytas paminklas Seule?")
            {
                button4antro.BackColor = Color.Red;
            }
        }

        private void button1trecio_Click(object sender, EventArgs e)
        {
            if (klausimoTrecioLabel.Text == "Kelinta pagal dydį pasaulyje yra Niujorko viešoji biblioteka?" ||
                klausimoTrecioLabel.Text == "Kas Tokijuje yra prienama kas 12 metrų, kur galima nusipirkti bet ko?" ||
                klausimoTrecioLabel.Text == "Kiek procentų Vilniaus ploto yra užstatyta?" ||
                klausimoTrecioLabel.Text == "Ką simbolizuoja Paryžiuje taip pat stovinti Laisvės \n" +
                    "statula, kuri yra atgręžta į Niujorko Laisvės statulą?" ||
                klausimoTrecioLabel.Text == "Kaip vadinasi paminklas rutinai ir kitos meniškos įdomybės Kaune?")
            {
                button1trecio.BackColor = Color.Red;
            }
            if (klausimoTrecioLabel.Text == "Kuo ypatingos „Antistress“ kavinės Seule?")
            {
                button1trecio.BackColor = Color.Green;
            }
        }

        private void button2trecio_Click(object sender, EventArgs e)
        {
            if (klausimoTrecioLabel.Text == "Kelinta pagal dydį pasaulyje yra Niujorko viešoji biblioteka?" ||
                klausimoTrecioLabel.Text == "Kas Tokijuje yra prienama kas 12 metrų, kur galima nusipirkti bet ko?" ||
                klausimoTrecioLabel.Text == "Kiek procentų Vilniaus ploto yra užstatyta?" ||
                klausimoTrecioLabel.Text == "Ką simbolizuoja Paryžiuje taip pat stovinti Laisvės \n" +
                    "statula, kuri yra atgręžta į Niujorko Laisvės statulą?" ||
                 klausimoTrecioLabel.Text == "Kaip vadinasi paminklas rutinai ir kitos meniškos įdomybės Kaune?" ||
                 klausimoTrecioLabel.Text == "Kuo ypatingos „Antistress“ kavinės Seule?")
            {
                button2trecio.BackColor = Color.Red;
            }
            if (klausimoTrecioLabel.Text == "Kelinta pagal dydį pasaulyje yra Niujorko viešoji biblioteka?")
            {
                button2trecio.BackColor = Color.Green;
            }
        }

        private void button3trecio_Click(object sender, EventArgs e)
        {
            if (klausimoTrecioLabel.Text == "Kas Tokijuje yra prienama kas 12 metrų, kur galima nusipirkti bet ko?" ||
                klausimoTrecioLabel.Text == "Kiek procentų Vilniaus ploto yra užstatyta?" ||
                klausimoTrecioLabel.Text == "Kuo ypatingos „Antistress“ kavinės Seule?" ||
                klausimoTrecioLabel.Text == "Kelinta pagal dydį pasaulyje yra Niujorko viešoji biblioteka?")
            {
                button3trecio.BackColor = Color.Red;
            }
            if ( klausimoTrecioLabel.Text == "Ką simbolizuoja Paryžiuje taip pat stovinti Laisvės \n" +
                    "statula, kuri yra atgręžta į Niujorko Laisvės statulą?" ||
                 klausimoTrecioLabel.Text == "Kaip vadinasi paminklas rutinai ir kitos meniškos įdomybės Kaune?")
            {
                button3trecio.BackColor = Color.Green;
            }
        }

        private void button4trecio_Click(object sender, EventArgs e)
        {
            if (klausimoTrecioLabel.Text == "Kelinta pagal dydį pasaulyje yra Niujorko viešoji biblioteka?" ||
                klausimoTrecioLabel.Text == "Ką simbolizuoja Paryžiuje taip pat stovinti Laisvės \n" +
                    "statula, kuri yra atgręžta į Niujorko Laisvės statulą?" ||
                klausimoTrecioLabel.Text == "Kaip vadinasi paminklas rutinai ir kitos meniškos įdomybės Kaune?" ||
                klausimoTrecioLabel.Text == "Kuo ypatingos „Antistress“ kavinės Seule?")
            {
                button4trecio.BackColor = Color.Red;
            }
            if (klausimoTrecioLabel.Text == "Kas Tokijuje yra prienama kas 12 metrų, kur galima nusipirkti bet ko?" ||
                klausimoTrecioLabel.Text == "Kiek procentų Vilniaus ploto yra užstatyta?")
            {
                button4trecio.BackColor = Color.Green;
            }
        }
    }
}
