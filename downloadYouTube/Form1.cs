using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using YoutubeExtractor;

namespace downloadYouTube
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        String path;
        private void btnBaixar_Click(object sender, EventArgs e){
            if (string.IsNullOrEmpty(path))
            {
                using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Will Soluções - opa amiguinho, você esqueceu de selecionar o caminho né? :)" })
                {
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        path = fbd.SelectedPath;
                    }
                }
            }

            this.Download(txtLinkYoutube.Text, path);
        }

        private async void Download(String link, String path)
        {
            try
            {
                var yt = new YoutubeClient();

                //Aqui o sistema pega a URL e as informações do video
                var video = await yt.Videos.GetAsync(link);
                var source = path;

                //New instance for download video in MP3 format
                var yt2 = new YoutubeClient();

                //Geting the manifest of video
                var streamManifest = await yt2.Videos.Streams.GetManifestAsync(video.Id);

                //Type of (video or audio only) and quality
                var streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate();

                if (streamInfo != null)
                {
                    // Get the actual stream
                    var stream = await yt2.Videos.Streams.GetAsync(streamInfo);

                    // Download the stream to file
                    String nameVideo = video.Title.Replace("/", "");
                    await yt2.Videos.Streams.DownloadAsync(streamInfo, $"{source}\\{nameVideo}.mp3");
                    MessageBox.Show("Música baixada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ocorreu um erro ao baixar o arquivo. Tente novamente!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
