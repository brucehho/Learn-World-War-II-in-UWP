using System;

namespace Learn_World_War_II_in_UWP.Core.Models
{
    // TODO WTS: Remove this class once your pages/features are using your data.
    // This is used by the SampleDataService.
    // It is the model class we use to display data on pages like Grid, Chart, and Master Detail.
    public class SampleOrder
    {
        public long OrderId { get; set; }

        public string GeneralPic { get; set; }
        public string Lived { get; set; }
        public string Allegiance { get; set; }
        public string Occupation { get; set; }
        public string Company { get; set; }
        public string knownAs { get; set; }
        public string PersonNote1 { get; set; }
        public string PersonNote2 { get; set; }

        public string GeneralPic2 { get; set; }
        public string GeneralPic3 { get; set; }
        public string GeneralPic4 { get; set; }
        public string GeneralPic5 { get; set; }
        public byte Path { get; set; }


        public override string ToString()
        {
            return $"{Company} {Allegiance}";
        }
    }
}
