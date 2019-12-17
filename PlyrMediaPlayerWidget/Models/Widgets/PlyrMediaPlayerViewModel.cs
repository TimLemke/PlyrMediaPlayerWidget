using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventyeightDigital.PlyrMediaPlayerWidget
{
    public class PlyrMediaPlayerViewModel
    {
        /// <summary>
        /// Media type selection string.
        /// </summary>
        public string MediaTypeSelection { get; set; }

        /// <summary>
        /// Audio file url string.
        /// </summary>
        public string AudioFile { get; set; }

        /// <summary>
        /// Video file url string.
        /// </summary>
        public string VideoFile { get; set; }

        /// <summary>
        /// YouTube url string.
        /// </summary>
        public string YouTubeURL { get; set; }

        /// <summary>
        /// Vimeo url string.
        /// </summary>
        public string VimeoURL { get; set; }

        public Guid MediaPlayerID { get; set; }
    }
}
