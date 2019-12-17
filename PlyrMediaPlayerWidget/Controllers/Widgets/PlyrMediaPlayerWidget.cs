using CMS.MediaLibrary;
using CMS.SiteProvider;
using Kentico.PageBuilder.Web.Mvc;
using SeventyeightDigital.PlyrMediaPlayerWidget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

[assembly: RegisterWidget("Kentico.PlyrMediaPlayerWidget", typeof(PlyrMediaPlayerWidgetController), "Plyr Media Player Widget", IconClass = "icon-triangle-right")]

namespace SeventyeightDigital.PlyrMediaPlayerWidget
{
    public class PlyrMediaPlayerWidgetController : WidgetController<PlyrMediaPlayerWidgetProperties>
    {
        /// <summary>
        /// Creates an instance of <see cref="PlyrMediaPlayerWidgetController"/> class.
        /// </summary>
        public PlyrMediaPlayerWidgetController()
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="PlyrMediaPlayerWidgetController"/> class.
        /// </summary>
        /// <param name="propertiesRetriever">Retriever for widget properties.</param>
        /// <param name="currentPageRetriever">Retriever for current page where is the widget used.</param>
        /// <remarks>Use this constructor for tests to handle dependencies.</remarks>
        public PlyrMediaPlayerWidgetController(IComponentPropertiesRetriever<PlyrMediaPlayerWidgetProperties> propertiesRetriever,
                                        ICurrentPageRetriever currentPageRetriever) : base(propertiesRetriever, currentPageRetriever)
        {
        }
        public ActionResult Index()

        {
            PlyrMediaPlayerWidgetProperties properties = GetProperties();

            var model = new PlyrMediaPlayerViewModel()
            {
                MediaTypeSelection = properties.MediaTypeSelection,
                AudioFile = GetDirectUrlForAudio(),
                VideoFile = GetDirectUrlForVideo(),
                YouTubeURL = properties.YouTubeURL,
                VimeoURL = properties.VimeoURL,
                MediaPlayerID = properties.MediaPlayerID

            };
            return PartialView("Widgets/_PlyrMediaPlayerWidget", model);
        }

        string GetDirectUrlForAudio()
        {

            Guid guid = GetProperties().AudioFile?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            MediaFileInfo mediaFile = MediaFileInfoProvider.GetMediaFileInfo(guid, SiteContext.CurrentSiteName);
            string url;
            if (mediaFile != null)
            {
                url = MediaLibraryHelper.GetDirectUrl(mediaFile);
            }
            else
            {
                url = "";
            }
            return url;
        }

        string GetDirectUrlForVideo()
        {
            Guid guid = GetProperties().VideoFile?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            MediaFileInfo mediaFile = MediaFileInfoProvider.GetMediaFileInfo(guid, SiteContext.CurrentSiteName);
            string url;
            if (mediaFile != null)
            {
                url = MediaLibraryHelper.GetDirectUrl(mediaFile);
            }
            else
            {
                url = "";
            }
            return url;
        }
    }

}
