using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ControlzEx;

namespace IconPack.Crypto
{
    /// <summary>
    ///     Icons from Crypto Coins -
    ///     <see>
    ///         <cref>https://github.com/allienworks/cryptocoins</cref>
    ///     </see>
    ///     .
    /// </summary>
    public class PackIcon : PackIconBase<PackIconKind>
    {
        static PackIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PackIcon), new FrameworkPropertyMetadata(typeof(PackIcon)));
        }

        public PackIcon() : base(PackIconDataFactory.Create)
        {
        }
    }
}
