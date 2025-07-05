// See https://aka.ms/new-console-template for more information

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

string inputImagePath = @"C:\ICI\STScI-01F8QS8JR44C2H9VMCBNZE6XNQ.png";
string outputImagePath = @"C:\ICI\output.jpg";

// Redimensionar e salvar a imagem com compressão
ResizeImage(inputImagePath, outputImagePath, 800, 600, 50);

static void ResizeImage(string inputImagePath, string outputImagePath, int newWidth, int newHeight, long compressionQuality)
{
    // Carregar a imagem original
    using (var originalImage = Image.FromFile(inputImagePath))
    {
        // Criar um novo bitmap com as dimensões desejadas
        using (var bitmap = new Bitmap(newWidth, newHeight))
        {
            // Desenhar a imagem original no novo bitmap
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }

            // Configurar parâmetros de qualidade para JPEG
            var encoderParams = new EncoderParameters(1);
            encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, compressionQuality);

            // Obter o codec de imagem para JPEG
            var jpegCodec = GetEncoderInfo(ImageFormat.Jpeg);

            // Salvar a imagem JPEG
            bitmap.Save(outputImagePath, jpegCodec, encoderParams);
        }
    }
}

// Método para obter informações do codec de imagem para um formato de imagem específico
static ImageCodecInfo GetEncoderInfo(ImageFormat format)
{
    ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

    foreach (ImageCodecInfo codec in codecs)
    {
        if (codec.FormatID == format.Guid)
        {
            return codec;
        }
    }
    return null;
}