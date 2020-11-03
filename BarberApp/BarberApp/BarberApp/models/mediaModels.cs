using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BarberApp.models
{
    public class mediaModels
    {
        public Guid MediaId { get; set; }
        public string Path { get; set; }
        public DateTime LocalDateTime { get; set; }

        private FileImageSource sourse = null;

        public FileImageSource Source => sourse ?? (sourse = new FileImageSource() { File = Path });
    }
}
