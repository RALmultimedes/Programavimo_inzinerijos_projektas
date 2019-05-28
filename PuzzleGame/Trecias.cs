using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PuzzleGame
{
    public partial class Trecias : UserControl
    { 
       
        public Trecias()
        {
            InitializeComponent();
        }

        private void Trecias_Load(object sender, EventArgs e)
        {

            int miestas = Globals.getTOWN();

            infoLabel.Text = miestas.ToString();
            if (miestas == 1)
            {
                pavadinimasLabel.Text = "NIUJORKAS";
                infoLabel.Text = "Niujorkas  – didžiausias JAV miestas, " +
                    "antrasis pagal dydį \n Šiaurės Amerikos miestas po Meksiko. " +
                    "Šnekamojoje kalboje \n dažnai vadinamas Didžiuoju Obuoliu. " +
                    "Niujorkas yra labiausiai \n apgyvendintas miestas Jungtinėse Amerikos Valstijose.  " +
                    "Niujorke \n gyvena 8,55 mln. gyventojų , o su priemiesčiais – daugiau kaip 22 milijonai, \n" +
                    "ir tai vienas iš didžiausių pasaulio miestų. \n" +
                    "\n" +
                    "ĮDOMŪS FAKTAI: \n" +
                    "Niujorkas yra didžiausią kalbų įvairovę aprėpiantis miestas pasaulyje. \n" +
                    "Skirtingi Niujorko gyventojai kalba daugiau nei 800 skirtingų kalbų. \n" +
                    "\n" +
                    "Vienas žymiausių Niujorko pastatų – Laisvės statula. Statula yra 46,5 m \n" +
                    "aukščio, jos pamatas – 46,9 m aukščio. Kiekvieną darbo dieną \n" +
                    "Niujorko metro naudojasi apie 4,9 mln. žmonių.\n" +
                    "\n" +
                    "Niujorko viešojoje bibliotekoje yra daugiau nei 50 milijonų knygų ir antra \n" +
                    "pagal dydį biblioteka šalyje. Ji taip pat yra trečia pagal dydį biblioteka pasaulyje. \n" +
                    "\n" +
                    "Niujorke gyvena daugiau kinų, nei bet kuriame kitame mieste už Azijos ribų. Čia gyvena \n" +
                    "daugiau žydų, nei bet kuriame kitame mieste, esantis už Izraelio.";
            }
            else 
            if (miestas == 2)
            {
                pavadinimasLabel.Text = "TOKIJAS";
                infoLabel.Text = "Kadaise Tokijas buvo mažas žvejų kaimelis ir vadinosi Edo. Šiandien jis \n" +
                    "yra didžiulis megapolis, neretai vadinamas Rytų pasaulio sostine. Tokijas yra \n" +
                    "Japonijos sostinė ir vienas didžiausių pasaulio miestų, kuriame gyvena daugiau \n" +
                    "nei 12 milijonų gyventojų. Čia gausu visko – nuo avangardo architektūros ir šiuolaikinio \n" +
                    "meno iki tradicinių medinių namelių ir jaukių užeigų. Prie viso to dar galima pridėti \n" +
                    "dangoraižių mišką, minias žmonių, įvairių kalbų mišinį, neoninių reklamų mirkčiojimą – \n" +
                    "visa tai gali bet ką išvesti iš proto. Tačiau neskubėkite spręsti apie Tokiją tik iš šių \n" +
                    "paviršinių detalių. Net ir dangoraižių miške pilna žalių vejų ir jaukių parkelių, kuriuose \n" +
                    "galima rasti tylių kampelių su tradicinėmis pagodomis, tvenkiniais ir žydinčiais sodais.\n" +
                    "\n" +
                    "ĮDOMŪS FAKTAI: \n" +
                    "Pardavimo automatai yra prieinami kas 12 m, ir jūs galite nusipirkti ką tik norite: \n" +
                    " pigių gaiviųjų gėrimų, saldainių, žaislų ar net naudotų apatinių drabužių!\n" +
                    "\n" +
                    "Tokijo geležinkelio sistema naudojasi tiek daug žmonių, kad Tokijo traukinių stotyse \n" +
                    " įdarbinami  žmonės vadinami “stumikais”, kurie tiesiogine ta žodžio prasme \n" +
                    "stumia žmones į traukinius.\n" +
                    "\n" +
                    "Vyšnių žiedai yra nacionalinis Japonijos simbolis. Balandį medžiai žydi \n" +
                    "dvi savaites, šis laikotarpis yra žinomas kaip Hanami.\n" +
                    "\n" +
                    "„Shibuya“ perėja  yra tarsi milžiniška, Tokijo sumišimą atvaizduojanti, širdis. \n" +
                    "Niekas kitas negali pasakyti : „Sveiki atvykę į Tokiją“ geriau, nei ši didžiulė \n" +
                    "perėja, kurioje vienu metu per gatvę gali eiti iki 3000 žmonių.\n";
            }
            else 
            if (miestas ==3)
            {
                pavadinimasLabel.Text = "VILNIUS";
                infoLabel.Text = "Vilnius - Lietuvos sostinė ir didžiausias šalies miestas. \n" +
                    "Įsikūręs šalies pietryčiuose, Neries ir Vilnios santakoje. Vilnius \n" +
                    "yra arkivyskupijos centras, nuo 1579 metų - universitetinis miestas. \n" +
                    "Vilniaus senamiestis yra vienas didžiausių Rytų Europoje ir \n" +
                    "1994 metais įtrauktas į UNESCO Pasaulio paveldo sąrašą.\n" +
                    "\n" +
                    "ĮDOMŪS FAKTAI: \n" +
                    "Vilniaus miesto ploto yra užstatyta tik apie 20,2 %, \n" +
                    "likę 43,9 % yra želdiniai ir 2,1% vandenys\n" +
                    "\n" +
                    "Katedros varpinė pastatyta ant vieno iš Žemutinės pilies gynybinio \n" +
                    "bokšto, tik, žinoma, sienų, kurios jungė visą Žemutinės pilies \n" +
                    "gynybinį kompleksą, jau nebeliko. Bokšto, kuris virto varpine, \n" +
                    "požeminė dalis yra dar iš 13 amžiaus, apatinio aukšto sienų \n" +
                    "storis - nuo 4 iki 3 metrų.\n" + 
                    "\n" +
                    "Iki 1941 metų, beveik visa Rytų Lenkijos, dabartinės Baltarusijos \n" +
                    "ir Ukrainos bei Lietuvos teritorija buvo gausiai apgyvendinta žydų \n" +
                    "bendruomenių. Varšuva ir Vilnius buvo didžiausi traukos centrai. \n" +
                    "Vilnius buvo daugiau kultūros sostinė, kur žydai atvykdavo mokytis, \n" +
                    "pažinti religiją. Dėl to, Vilnius gavęs pavadinimą „Šiaurės Jeruzalė“.\n" +
                    "\n" +
                    "Vilniuje moterų gyvena daugiau nei vyrų. Moterų 54 %,  o vyrų tik 46%.";
            }
            else
            if (miestas == 4)
            {
                pavadinimasLabel.Text = "KAUNAS";
                infoLabel.Text = "Kaunas – antrasis pagal dydį Lietuvos miestas šalies \n" +
                    "centrinėje dalyje, Nemuno ir Neries santakoje. \n" +
                     "\n" +
                    "ĮDOMŪS FAKTAI: \n" +
                    "Laisvės alėja Kaune – ilgiausia pėsčiųjų gatvė Rytų Europoje. \n" +
                    "Lygiai 1,6 km (arba vienos mylios) ilgio gatvė jau spėjo tapti miesto \n" +
                    "simboliu. Kaune ji atstoja Barselonos „Las Ramblas“ ar Niujorko „Broadway“.\n" +
                    "\n" +
                    "Paminklas rutinai ir kitos meniškos įdomybės. Kiemo galerija – \n" +
                    "E.Ožeškienės g.21, miesto centre įsikūręs savotiškas muziejus. Čia \n" +
                    "eksponuojami ir meniškai instaliuoti įvairūs daiktai bei objektai \n" +
                    "norint perpasakoti namo gyventojų istorijas.\n" +
                    "\n" +
                    "Kauno Ąžuolynas – didžiausias Europoje. Visų kauniečių pamiltas Ąžuolynas \n" +
                    "turi ypatingą vietą jų širdyse. Pačiame Žaliakalnio centre įsikūręs parkas\n" +
                    " sutraukia visus. Sportuojantys čia gerina sportinę formą bei ugdo ištvermę,\n" +
                    " porelės vaikšto ir gėrisi medžiais bei grynu oru, o vyresni gyventojai \n" +
                    "džiaugiasi nostalgija. Kauno Ąžuolynas taip pat yra didžiausias išskirtinai \n" +
                    "ąžuolų parkas Europoje.\n";
            }
            else
            if (miestas == 5)
            {
                pavadinimasLabel.Text = "SEULAS";
                infoLabel.Text = "Seulas arba oficialiai Seulo ypatingasis miestas – \n" +
                    "Pietų Korėjos didžiausias miestas ir šalies sostinė nuo 1948 m. \n" +
                    "Metropolinėje teritorijoje kartu su Inčono uostu ir aplinkiniais \n" +
                    "miestais gyvena 24,11 mln. gyventojų (2016 m.) 2745 km² plote.\n" +
                    " Seulas laikomas vienu iš didžiausių pasaulio miestų.\n" +
                     "\n" +
                    "ĮDOMŪS FAKTAI: \n" +
                    "Seule yra pastatytas paminklas reperio Psy dainai „Gangnam Style“. \n " +
                    "\n" +
                    "Seule yra nemažai “Antistress cafe”, kurioje laisvai vaikšto gyvūnai.\n" +
                    "\n" +
                    "“Mr. Toilet House” - tualetinės kultūros muziejus Seule. \n" +
                    "Be to mieste yra ir tos pačios tematikos kavinių.";
            }
            else
            if (miestas == 6)
            {
                pavadinimasLabel.Text = "PARYZIUS";
                infoLabel.Text = "Paryžius - Prancūzijos sostinė, didžiausias miestas ir \n" +
                    "departamentas. Su 2,2 mln. gyventojų (2015 m. duomenimis) yra penktas\n" +
                    "pagal dydį Europos Sąjungos ir devintas pagal dydį Europos žemyno miestas.\n" +
                    "Aire urbaine (su priemiesčiais Versaliu, Sen Deni, Ivri, Dransi, Aržantejumi\n" +
                    " ir kt.) - apie 11 mln. yra didžiausia Eurizinis metropolinė zona.\n" +
                     "\n" +
                    "ĮDOMŪS FAKTAI: \n" +
                    "Viename žymiausių pasaulio meno muziejų, Luvre saugomi tūkstančiai vertingų \n" +
                    "meno kūrinių. Tačiau Antrojo Pasaulinio karo metu buvo baiminamasi, jog naciai \n" +
                    "šias vertybes suniokos, dėl to meno kūriniai buvo išdalinti šalies \n" +
                    "turtuoliams ir taip išslapstyti po Prancūziją.\n" +
                    "\n" +
                    "Paryžiuje taip pat stovi Laisvės statula, kuri yra atgręžta į Niujorko \n" +
                    "Laisvės statulą ir simbolizuoja dviejų šalių draugystę.\n" +
                    "\n" +
                    "Nors Paryžiuje gyvena 2,2 mln. gyventojų, prancūzijos sostinė \n" +
                    "nėra didžiausias pasaulio miestas, kuriame kalbama prancūziškai. \n" +
                    "Ir tai net ne Kanados metropolis Monrealis, o \n" +
                    "Kongo Demokratinės Respublikos sostinė Kinšasa.\n " +
                    "\n" +
                    "Paryžiaus simboliu tapęs Eifelio bokštas 1889 m. buvo pastatytas kaip \n" +
                    "laikinas statinys Revoliucijos šimtmečiui paminėti, tačiau bokštas \n" +
                    "ėmė traukti turistus ir buvo atsisakyta minties jį išmontuoti.";
            }
        }
    }
}
