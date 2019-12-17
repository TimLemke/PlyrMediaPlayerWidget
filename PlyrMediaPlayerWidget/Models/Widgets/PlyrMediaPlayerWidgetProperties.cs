using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Forms.Web.Mvc;
using Kentico.Components.Web.Mvc.FormComponents;

namespace SeventyeightDigital.PlyrMediaPlayerWidget
{
    public class PlyrMediaPlayerWidgetProperties : IWidgetProperties
    {
        /// <summary>
        /// Dropdown for selecting type of media.
        /// </summary>
        [EditingComponent(DropDownComponent.IDENTIFIER, ExplanationText = "Select HTML5 Video, HTML5 Audio, YouTube or Vimeo", Label = "Media type Selection", Order = 0)]
        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "Audio;HTML5 Audio\r\nVideo;HTML5 Video\r\nYouTube;YouTube\r\nVimeo;Vimeo")]
        public string MediaTypeSelection { get; set; } = "";

        /// <summary>
        /// Selected audio file property.
        /// </summary>
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".mp3;")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 1)]
        [EditingComponent(MediaFilesSelector.IDENTIFIER, ExplanationText = "Select an .mp3 file", Label = "Audio File", Order = 1)]
        public IList<MediaFilesSelectorItem> AudioFile { get; set; }

        /// <summary>
        /// Selected video file property.
        /// </summary>
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.AllowedExtensions), ".mp4;")]
        [EditingComponentProperty(nameof(MediaFilesSelectorProperties.MaxFilesLimit), 2)]
        [EditingComponent(MediaFilesSelector.IDENTIFIER, ExplanationText = "Select an .mp4 file", Label = "Video File", Order = 2)]
        public IList<MediaFilesSelectorItem> VideoFile { get; set; }

        /// <summary>
        /// YouTube video url.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, ExplanationText = "YouTube Video URL.", Label = "YouTube URL", Order = 3)]
        public string YouTubeURL { get; set; } = "";

        /// <summary>
        /// YouTube video url.
        /// </summary>
        [EditingComponent(TextInputComponent.IDENTIFIER, ExplanationText = "Vimeo Video URL.", Label = "Vimeo URL", Order = 4)]
        public string VimeoURL { get; set; } = "";

        public Guid MediaPlayerID { get; set; } = Guid.NewGuid();
    }
}
