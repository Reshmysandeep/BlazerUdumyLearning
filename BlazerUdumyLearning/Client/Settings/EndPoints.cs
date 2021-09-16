using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerUdumyLearning.Client.Settings
{
    public class EndPoints
    {
        public static string prifix = "api";
        public static string BrandEndPoints = $"{ prifix }/Brands";
        public static string VehicleModelsEndPoints = $"{ prifix }/VehicleModels";
        public static string VehicleEndpoint = $"{ prifix }/Vehicles";
        public static string VehicleColorEndPoint = $"{ prifix }/VehicleColors";
        public static string BookingEndpoint = $"{ prifix }/Bookings";
        public static string CustomerEndPoint = $"{ prifix }/Customers";

    }
}
