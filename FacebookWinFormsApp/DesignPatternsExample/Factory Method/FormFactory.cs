using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicFacebookFeatures.Subforms;

namespace BasicFacebookFeatures
{
    public class FormFactory
    {
        public static Form MakeForm(string i_FormType)
        {
            Form form = null;
            switch (i_FormType)
            {
                case "album_cross_post":
                    form = new FormAlbumCrosspost();
                    break;
                case "album_view":
                    form = new FormAlbumView();
                    break;
                case "group_cross_post":
                    form = new FormGroupCrossPost();
                    break;
                case "group_view":
                    form = new FormGroupView();
                    break;
                case "liked_pages":
                    form = new FormLikedPages();
                    break;
                case "user_details":
                    form = new FormUserDetails();
                    break;
            }
            return form;
        }
    }
}
