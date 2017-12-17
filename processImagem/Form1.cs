using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace processImagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var intencidade = 120;
            Image<Gray, byte> bin = null;
            Bitmap bitmap = new Bitmap(imagemBox.Image);
            Image<Gray, byte> image = new Image<Gray, byte>(bitmap);
            bin = image.ThresholdBinary(new Gray((double)intencidade), new Gray(255));
            imagemBox.Image = bin.Bitmap;
           
            //for (var x = 0; x < bin.Bitmap.Width; x++)
            //{
            //    for (var y = 0; x < bin.Bitmap.Height; y++)
            //    {
            //          bin.Bitmap.SetPixel(x, y, Color.Red);
            //    }
                
            //}
            var count = 0;
            foreach (var b in bin.Data)
            {
                if (b == 255)
                {
                    count++;
                }
            }
            Console.WriteLine(String.Format("Altura: {0}, Largura: {1}", bin.Bitmap.Height, bin.Bitmap.Width));
            var pixelReferencia = 189;
            var cmRefeencia = 125;
            Double area = pixelReferencia / pixelReferencia;
            area = Math.Pow(area, 2);
            var total = area * count;
            
            Console.WriteLine(total);
            Console.WriteLine(count);

        }
    }
}
