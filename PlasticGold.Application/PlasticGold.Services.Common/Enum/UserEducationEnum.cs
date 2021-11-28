using System.ComponentModel;

namespace PlasticGold.Services.Common.Enum
{
    public enum UserEducationEnum
    {
        [Description("Fundamental")]
        Fundamental = 1,
        [Description("Medio")]
        Medium = 2,
        [Description("Graduacao")]
        Graduation = 3,
        [Description("Mestrado")]
        Masters = 4,
        [Description("Doutorado")]
        Doctorate = 5
    }
}
