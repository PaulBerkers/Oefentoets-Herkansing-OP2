using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Oefentoets_Herkansing_OP2.Classes
{
    public class MenuItems
    {
        private Type _page;

        public Type Page
        {
            get { return _page; }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
        }

        private Symbol _icon;

        public IconElement Icon
        {
            get { return new SymbolIcon(_icon); }
        }

        public MenuItems(Type page, string text, Symbol icon)
        {
            _page = page;
            _text = text;
            _icon = icon;
        }

    }
}
