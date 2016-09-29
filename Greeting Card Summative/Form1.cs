using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// header commments go here

namespace Greeting_Card_Summative
{
    public partial class greetingCard : Form
    {
        public greetingCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics FormGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.White, 10);
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            openCard.Hide();
            openLabel.Hide();

            Pen purplePen = new Pen(Color.Purple, 05);

            FormGraphics.Clear(Color.Black);

            FormGraphics.FillEllipse(WhiteBrush, 161, 22, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 163, 56, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 153, 83, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 126, 89, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 89, 78, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 157, 124, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 175, 150, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 149, 192, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 126, 136, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 118, 214, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 102, 157, 07, 07);
            FormGraphics.FillEllipse(WhiteBrush, 77, 196, 07, 07);

            FormGraphics.DrawLine(purplePen, 164, 22, 167, 58);
            FormGraphics.DrawLine(purplePen, 167, 56, 157, 85);
            FormGraphics.DrawLine(purplePen, 157, 85, 130, 89);
            FormGraphics.DrawLine(purplePen, 130, 89, 92, 78);
            FormGraphics.DrawLine(purplePen, 161, 124, 179, 150);
            FormGraphics.DrawLine(purplePen, 179, 150, 153, 192);

            //FormGraphics.DrawLine(purplePen, 130, 136, 122, 214);
            //FormGraphics.DrawLine(purplePen, 122, 214, 106, 157);
            FormGraphics.DrawLine(purplePen, 106, 157, 81, 196);

            FormGraphics.DrawLine(purplePen, 157, 85, 161, 124);
           // FormGraphics.DrawLine(purplePen, 130, 89, 122, 214);
          
            FormGraphics.DrawLine(purplePen, 179, 150, 130, 136);
            FormGraphics.DrawLine(purplePen, 122, 214, 153, 192);
            FormGraphics.DrawLine(purplePen, 81, 196, 106, 157);
            FormGraphics.DrawLine(purplePen, 130, 136, 130, 89);
            FormGraphics.DrawLine(purplePen, 130, 136, 81, 196);






           








        }
    }
}
