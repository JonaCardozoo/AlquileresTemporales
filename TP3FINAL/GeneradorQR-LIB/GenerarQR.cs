using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorQR_LIB
{
    public class GenerarQR
    {
        public byte[] Generar(string data, int sizeModulo = 20)
        {
            #region llamo a la libreria
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data,QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(sizeModulo);
            #endregion

            //convierto la imagen en un array de bytes.
            byte[] imageBytes = new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imageBytes = ms.ToArray();
            }
            return imageBytes;
        }
    }
}
