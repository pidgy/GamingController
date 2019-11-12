using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NolanHodge.GamingController
{
    /// <summary>
    /// Controller represents helper presets/functions for all IGamingController objects
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// TypeString 
        /// </summary>
        /// <param name="VendorID"> A HardwareVendorID value from a Windows.Gaming.Input object</param>
        /// <returns>
        /// TypeString returns a VENDOR_ID values string representation.
        /// </returns>
        public static string TypeString(ushort VendorID)
        {
            switch (VendorID)
            {
                case (ushort)VENDOR_ID.XBOX:
                    return "Xbox";
                case (ushort)VENDOR_ID.PLAYSTATION:
                    return "Playstation";
                default:
                    return "Generic";
            }
        }
    }
}
