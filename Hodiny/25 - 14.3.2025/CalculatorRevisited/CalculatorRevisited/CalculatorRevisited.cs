using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/*
 * Dnes bude vasim ukolem vytvorit formularovou reprezentaci kalkulacky. Priblizny vzhled si nakreslime na tabuli
 * (Pokud jsem to nenakreslil, pripomente mi to prosim!)
 * Inspirujte se kalkulackou ve Windows.
 * Pozadovane prvky/funkcionality:
 * - Tlacitka pro kazde z cisel 0-9
 * - Tlacitka pro operace +, -, *, a /
 * - Tlacitko pro = (vypsani vysledku)
 * - Textbox, do ktereho se propisou cisla/operace pri stisku jejich tlacitek
 * - Textbox s vysledkem operace (mozne sloucit s predeslym, nechavam na vas)
 * - Tlacitko pro vymazani textu v textboxu s cisly a operaci
 * 
 * Volitelne prvky/funkcionality:
 * - Tlacitko pro mazani cisel a operaci v textboxu zprava vzdy po jednom znaku
 * - Pokud mam vypsany vysledek a hned po tom stisknu tlacitko nejake operace, vysledek se vezme jako prvni cislo a
 *   rovnou mohu po zadani operace zadat druhe cislo
 * - Moznost ulozeni vysledku do nekolika preddefinovanych labelu/neinteraktivnich textboxu (treba kombinaci comboboxu a tlacitka, kde
 *   v comboboxu vyberu do ktereho labelu/textboxu se mi to ulozi a tlacitkem provedu ulozeni)
 *   + pridat tlacitko pro kazdy label/neint. textbox, kterym ulozeny vysledek pouziju jako cislo do vypoctu
 * - Pridani mocnin/odmocnin atd. (napr. pomoci dalsich tlacitek, ktere rovnou misto daneho cisla daji jeho (popr. zaokrouhlenou) odmocninu apod.)
 * - Cokoliv dalsiho vas napadne! :)
 * 
 * Snazte se o to, aby byla kalkulacka v ramci moznosti hezka, a aby bylo jeji ovladani intuitivni a aby mel kazdy prvek v okne dobre vyuziti
 */

namespace CalculatorRevisited
{
    public partial class CalculatorRevisited : Form
    {
        public CalculatorRevisited()
        {
            InitializeComponent();
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Red, 50, 50, 20, 30);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "2";

        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "3";

        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "4";

        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "5";

        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "6";

        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "7";

        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "8";

        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "9";

        }

        private void buttonNull_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "0";

        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "+";

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "-";

        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "*";

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "/";

        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            textBoxText.Text += "=";

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxText.Text = "";

        }

    
    }
}
