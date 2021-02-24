using System;
using System.Collections.Generic;
using System.Text;

namespace W3Projects.Model
{
    class Music
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Url { get; set; }
        public string CoverImage { get; set; } = "https://github.com/billy-hoang-phu-vinh/xamarin-musicplayer/blob/main/sourcefiles/Music_player_logo.png";
        public bool IsRecent { get; set; }
    }
}
