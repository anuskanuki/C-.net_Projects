using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSaleReports.Model;

namespace CarSaleReports.Model
{
    public class LocationContext
    {
        public List<Car> CarsList { get; set; }

        public LocationContext()
        {
            CarsList = new List<Car>();
            CarsList.Add(new Car { IdCar = 01, CarName = " Risus Company                      ", CarPrice = 7200, AmountCar = 18, DateCar = DateTime.Parse(" 29 / 01 / 2019") });
            CarsList.Add(new Car { IdCar = 02, CarName = " Risus Associates                   ", CarPrice = 9961, AmountCar = 04, DateCar = DateTime.Parse(" 10 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 03, CarName = " Et Libero Proin Foundation         ", CarPrice = 8710, AmountCar = 17, DateCar = DateTime.Parse(" 24 / 01 / 2019") });
            CarsList.Add(new Car { IdCar = 04, CarName = " Cursus Et Ltd                      ", CarPrice = 9010, AmountCar = 17, DateCar = DateTime.Parse(" 26 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 05, CarName = " Odio Etiam Ligula Company          ", CarPrice = 5245, AmountCar = 08, DateCar = DateTime.Parse(" 16 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 06, CarName = " Eu Nibh Inc.                       ", CarPrice = 7922, AmountCar = 09, DateCar = DateTime.Parse(" 27 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 07, CarName = " Tellus Limited                     ", CarPrice = 7294, AmountCar = 07, DateCar = DateTime.Parse(" 26 / 01 / 2019") });
            CarsList.Add(new Car { IdCar = 08, CarName = " Imperdiet PC                       ", CarPrice = 8305, AmountCar = 05, DateCar = DateTime.Parse(" 06 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 09, CarName = " Elit Inc.	                      ", CarPrice = 5398, AmountCar = 18, DateCar = DateTime.Parse(" 09 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 10, CarName = "Quam A Limited                     ", CarPrice = 5398, AmountCar = 14, DateCar = DateTime.Parse(" 09 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 11, CarName = "Adipiscing Institute               ", CarPrice = 8133, AmountCar = 04, DateCar = DateTime.Parse(" 24 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 12, CarName = "Posuere At Velit Ltd               ", CarPrice = 5121, AmountCar = 15, DateCar = DateTime.Parse(" 19 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 13, CarName = "Nunc In Industries                 ", CarPrice = 8902, AmountCar = 02, DateCar = DateTime.Parse(" 21 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 14, CarName = "Integer Vitae Nibh Corporation     ", CarPrice = 6313, AmountCar = 20, DateCar = DateTime.Parse(" 02 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 15, CarName = "Tellus Nunc Lectus Company         ", CarPrice = 9650, AmountCar = 02, DateCar = DateTime.Parse(" 20 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 16, CarName = "Suspendisse LLC                    ", CarPrice = 5319, AmountCar = 12, DateCar = DateTime.Parse(" 24 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 17, CarName = "Mauris Vestibulum Corporation      ", CarPrice = 5790, AmountCar = 05, DateCar = DateTime.Parse(" 14 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 18, CarName = "Sed Nec Corp.                      ", CarPrice = 8421, AmountCar = 02, DateCar = DateTime.Parse(" 05 / 05 / 2019") });
            CarsList.Add(new Car { IdCar = 19, CarName = "Enim Nisl Elementum Inc.	          ", CarPrice = 5904, AmountCar = 06, DateCar = DateTime.Parse(" 26 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 20, CarName = "Ac Mattis Semper Corporation       ", CarPrice = 5110, AmountCar = 04, DateCar = DateTime.Parse(" 14 / 01 / 2019") });
            CarsList.Add(new Car { IdCar = 21, CarName = "Donec Tempus Lorem LLC             ", CarPrice = 8576, AmountCar = 16, DateCar = DateTime.Parse(" 29 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 22, CarName = "Tempor Augue Ac Ltd                ", CarPrice = 9072, AmountCar = 16, DateCar = DateTime.Parse(" 09 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 23, CarName = "Diam Duis Mi LLC                   ", CarPrice = 8472, AmountCar = 04, DateCar = DateTime.Parse(" 23 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 24, CarName = "Aliquam Corp.	                  ", CarPrice = 6607, AmountCar = 04, DateCar = DateTime.Parse(" 28 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 25, CarName = "Montes Institute                   ", CarPrice = 6176, AmountCar = 08, DateCar = DateTime.Parse(" 19 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 26, CarName = "Hendrerit Institute                ", CarPrice = 8387, AmountCar = 11, DateCar = DateTime.Parse(" 17 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 27, CarName = "Erat Etiam Vestibulum Corporation  ", CarPrice = 7584, AmountCar = 09, DateCar = DateTime.Parse(" 02 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 28, CarName = "Adipiscing Ltd                     ", CarPrice = 7887, AmountCar = 09, DateCar = DateTime.Parse(" 19 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 29, CarName = "In Tempus Eu Inc.	              ", CarPrice = 5233, AmountCar = 16, DateCar = DateTime.Parse(" 20 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 30, CarName = "Elit Institute                     ", CarPrice = 7359, AmountCar = 11, DateCar = DateTime.Parse(" 12 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 31, CarName = "Aliquam Erat LLC                   ", CarPrice = 8842, AmountCar = 04, DateCar = DateTime.Parse(" 14 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 32, CarName = "A Feugiat Tellus PC                ", CarPrice = 9176, AmountCar = 04, DateCar = DateTime.Parse(" 10 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 33, CarName = "Aliquet Incorporated               ", CarPrice = 9057, AmountCar = 08, DateCar = DateTime.Parse(" 26 / 04 / 2019") });
            CarsList.Add(new Car { IdCar = 34, CarName = "Dolor Dolor Tempus Institute       ", CarPrice = 8433, AmountCar = 15, DateCar = DateTime.Parse(" 31 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 35, CarName = "Risus Odio Auctor PC               ", CarPrice = 8286, AmountCar = 11, DateCar = DateTime.Parse(" 29 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 36, CarName = "Aliquet Molestie Tellus Corp.	  ", CarPrice = 8779, AmountCar = 01, DateCar = DateTime.Parse(" 05 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 37, CarName = "Ipsum Corp.	                      ", CarPrice = 5568, AmountCar = 15, DateCar = DateTime.Parse(" 10 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 38, CarName = "Mi Lacinia Foundation              ", CarPrice = 7442, AmountCar = 20, DateCar = DateTime.Parse(" 09 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 39, CarName = "Cubilia Curae; Corp.               ", CarPrice = 8421, AmountCar = 07, DateCar = DateTime.Parse(" 26 / 05 / 2019") });
            CarsList.Add(new Car { IdCar = 40, CarName = "Velit Sed Malesuada Associates     ", CarPrice = 9841, AmountCar = 06, DateCar = DateTime.Parse(" 07 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 41, CarName = "Duis Foundation                    ", CarPrice = 9849, AmountCar = 06, DateCar = DateTime.Parse(" 08 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 42, CarName = "Erat Semper Consulting             ", CarPrice = 6168, AmountCar = 10, DateCar = DateTime.Parse(" 10 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 43, CarName = "Turpis Inc.	                      ", CarPrice = 7758, AmountCar = 07, DateCar = DateTime.Parse(" 12 / 08 / 2019") });
            CarsList.Add(new Car { IdCar = 44, CarName = "Aenean Industries                  ", CarPrice = 8770, AmountCar = 12, DateCar = DateTime.Parse(" 10 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 45, CarName = "Nulla Industries                   ", CarPrice = 8884, AmountCar = 08, DateCar = DateTime.Parse(" 10 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 46, CarName = "Semper Egestas Urna Inc.	          ", CarPrice = 9428, AmountCar = 11, DateCar = DateTime.Parse(" 26 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 47, CarName = "Donec Luctus Aliquet Industries    ", CarPrice = 5928, AmountCar = 08, DateCar = DateTime.Parse(" 11 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 48, CarName = "Cum Sociis Natoque Foundation      ", CarPrice = 7506, AmountCar = 02, DateCar = DateTime.Parse(" 21 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 49, CarName = "Vitae Sodales Limited              ", CarPrice = 8912, AmountCar = 08, DateCar = DateTime.Parse(" 22 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 50, CarName = "Tellus Sem Mollis Ltd              ", CarPrice = 9615, AmountCar = 20, DateCar = DateTime.Parse(" 30 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 51, CarName = "Nulla Tincidunt LLC                ", CarPrice = 5562, AmountCar = 19, DateCar = DateTime.Parse(" 22 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 52, CarName = "Sed Dictum Institute               ", CarPrice = 9243, AmountCar = 14, DateCar = DateTime.Parse(" 26 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 53, CarName = "Sed Turpis Company                 ", CarPrice = 7243, AmountCar = 14, DateCar = DateTime.Parse(" 20 / 08 / 2019") });
            CarsList.Add(new Car { IdCar = 54, CarName = "Vitae Diam Proin Associates        ", CarPrice = 6631, AmountCar = 02, DateCar = DateTime.Parse(" 10 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 55, CarName = "Curabitur Inc.	                  ", CarPrice = 8090, AmountCar = 03, DateCar = DateTime.Parse(" 09 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 56, CarName = "Suscipit Est Ac LLC                ", CarPrice = 8567, AmountCar = 15, DateCar = DateTime.Parse(" 08 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 57, CarName = "Neque Morbi Industries             ", CarPrice = 5171, AmountCar = 01, DateCar = DateTime.Parse(" 03 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 58, CarName = "Non Ltd                            ", CarPrice = 5102, AmountCar = 19, DateCar = DateTime.Parse(" 14 / 08 / 2019") });
            CarsList.Add(new Car { IdCar = 59, CarName = "Arcu Vestibulum Ante Institute     ", CarPrice = 6128, AmountCar = 01, DateCar = DateTime.Parse(" 08 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 60, CarName = "Nulla Foundation                   ", CarPrice = 7636, AmountCar = 06, DateCar = DateTime.Parse(" 14 / 04 / 2019") });
            CarsList.Add(new Car { IdCar = 61, CarName = "Quis Massa Mauris LLP              ", CarPrice = 5053, AmountCar = 03, DateCar = DateTime.Parse(" 09 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 62, CarName = "Ut Incorporated                    ", CarPrice = 6922, AmountCar = 17, DateCar = DateTime.Parse(" 16 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 63, CarName = "Aenean Egestas Corp.               ", CarPrice = 8142, AmountCar = 19, DateCar = DateTime.Parse(" 17 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 64, CarName = "Fusce Mi Lorem Consulting          ", CarPrice = 8312, AmountCar = 20, DateCar = DateTime.Parse(" 19 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 65, CarName = "A Sollicitudin Orci PC             ", CarPrice = 5864, AmountCar = 01, DateCar = DateTime.Parse(" 20 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 66, CarName = "Sociosqu Limited                   ", CarPrice = 5985, AmountCar = 12, DateCar = DateTime.Parse(" 28 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 67, CarName = "Ullamcorper Duis Cursus LLC        ", CarPrice = 5164, AmountCar = 07, DateCar = DateTime.Parse(" 22 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 68, CarName = "Nibh Lacinia LLC                   ", CarPrice = 7760, AmountCar = 10, DateCar = DateTime.Parse(" 13 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 69, CarName = "Eu Dui Institute                   ", CarPrice = 7695, AmountCar = 08, DateCar = DateTime.Parse(" 12 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 70, CarName = "Fringilla Purus Mauris Consulting  ", CarPrice = 5845, AmountCar = 06, DateCar = DateTime.Parse(" 01 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 71, CarName = "Donec Tempus Lorem Industries      ", CarPrice = 8472, AmountCar = 19, DateCar = DateTime.Parse(" 09 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 72, CarName = "Auctor Incorporated                ", CarPrice = 6795, AmountCar = 01, DateCar = DateTime.Parse(" 04 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 73, CarName = "Enim Etiam Imperdiet Corporation   ", CarPrice = 6532, AmountCar = 13, DateCar = DateTime.Parse(" 14 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 74, CarName = "Non Cursus Non Industries          ", CarPrice = 9569, AmountCar = 16, DateCar = DateTime.Parse(" 25 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 75, CarName = "Ut Semper Incorporated             ", CarPrice = 5760, AmountCar = 18, DateCar = DateTime.Parse(" 14 / 01 / 2019") });
            CarsList.Add(new Car { IdCar = 76, CarName = "Sed Malesuada Corporation          ", CarPrice = 6561, AmountCar = 04, DateCar = DateTime.Parse(" 06 / 03 / 2019") });
            CarsList.Add(new Car { IdCar = 77, CarName = "Sed Neque Consulting               ", CarPrice = 7308, AmountCar = 02, DateCar = DateTime.Parse(" 31 / 08 / 2019") });
            CarsList.Add(new Car { IdCar = 78, CarName = "Nisl Arcu PC                       ", CarPrice = 7260, AmountCar = 08, DateCar = DateTime.Parse(" 19 / 06 / 2019") });
            CarsList.Add(new Car { IdCar = 79, CarName = "Euismod Est Consulting             ", CarPrice = 6020, AmountCar = 11, DateCar = DateTime.Parse(" 27 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 80, CarName = "Leo Vivamus Ltd                    ", CarPrice = 5055, AmountCar = 08, DateCar = DateTime.Parse(" 22 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 81, CarName = "Tristique Neque Inc.               ", CarPrice = 9268, AmountCar = 13, DateCar = DateTime.Parse(" 25 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 82, CarName = "In Lobortis PC                     ", CarPrice = 5539, AmountCar = 04, DateCar = DateTime.Parse(" 18 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 83, CarName = "Nunc Ltd                           ", CarPrice = 6846, AmountCar = 02, DateCar = DateTime.Parse(" 09 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 84, CarName = "Dictum Proin Limited               ", CarPrice = 5543, AmountCar = 12, DateCar = DateTime.Parse(" 05 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 85, CarName = "Erat Vitae LLP                     ", CarPrice = 5060, AmountCar = 07, DateCar = DateTime.Parse(" 12 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 86, CarName = "Pellentesque Ultricies Dignissim PC", CarPrice = 7971, AmountCar = 15, DateCar = DateTime.Parse(" 25 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 87, CarName = "Phasellus Elit Company             ", CarPrice = 5350, AmountCar = 15, DateCar = DateTime.Parse(" 31 / 10 / 2019") });
            CarsList.Add(new Car { IdCar = 88, CarName = "Luctus Felis Ltd                   ", CarPrice = 9872, AmountCar = 13, DateCar = DateTime.Parse(" 06 / 01 / 2019") });
            CarsList.Add(new Car { IdCar = 89, CarName = "Dui Suspendisse PC                 ", CarPrice = 6878, AmountCar = 07, DateCar = DateTime.Parse(" 06 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 90, CarName = "Odio Associates                    ", CarPrice = 7636, AmountCar = 18, DateCar = DateTime.Parse(" 24 / 07 / 2019") });
            CarsList.Add(new Car { IdCar = 91, CarName = "Vel Company                        ", CarPrice = 7410, AmountCar = 05, DateCar = DateTime.Parse(" 16 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 92, CarName = "Lobortis Institute                 ", CarPrice = 5110, AmountCar = 08, DateCar = DateTime.Parse(" 27 / 05 / 2019") });
            CarsList.Add(new Car { IdCar = 93, CarName = "Scelerisque Company                ", CarPrice = 7983, AmountCar = 19, DateCar = DateTime.Parse(" 03 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 94, CarName = "Posuere Enim Company               ", CarPrice = 6968, AmountCar = 19, DateCar = DateTime.Parse(" 22 / 04 / 2019") });
            CarsList.Add(new Car { IdCar = 95, CarName = "Sem Ut Corp.                       ", CarPrice = 6504, AmountCar = 11, DateCar = DateTime.Parse(" 02 / 02 / 2019") });
            CarsList.Add(new Car { IdCar = 96, CarName = "Dui Fusce Aliquam PC               ", CarPrice = 7837, AmountCar = 02, DateCar = DateTime.Parse(" 08 / 12 / 2019") });
            CarsList.Add(new Car { IdCar = 97, CarName = "Nisl Sem Industries                ", CarPrice = 6835, AmountCar = 05, DateCar = DateTime.Parse(" 14 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 98, CarName = "Vitae Corp.	                      ", CarPrice = 7669, AmountCar = 07, DateCar = DateTime.Parse(" 09 / 11 / 2019") });
            CarsList.Add(new Car { IdCar = 99, CarName = "Malesuada Incorporated             ", CarPrice = 5960, AmountCar = 04, DateCar = DateTime.Parse(" 26 / 09 / 2019") });
            CarsList.Add(new Car { IdCar = 100, CarName = " Mauris Ltd                         ", CarPrice = 8974, AmountCar = 18, DateCar = DateTime.Parse(" 16 / 05 / 2019") });










        }



    }
}
