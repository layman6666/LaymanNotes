      var zpl= Chinese2ZPL("你今天吃饭了么?", new Font("宋体", 25, FontStyle.Bold),50,300);

       //Nuget install PDFtoZPL
        //using PDFtoZPL;
        static string Chinese2ZPL(string ChineseStr ,Font font,Point p)
        {
            using (Bitmap b = new Bitmap(800, 100))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.Clear(Color.White);
                    g.DrawString(ChineseStr, font, new SolidBrush(Color.Black), new PointF(1.0f, 1.0f));               
                }
                
                b.Save("1.png", ImageFormat.Png);
                return $"^FO{p.X},{p.Y}"+ Conversion.ConvertBitmap(bitmapPath:"1.png",graphicFieldOnly:true);
            }
        }
