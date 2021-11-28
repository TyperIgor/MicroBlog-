using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace PlasticGold.Services.Common.Enum
{
    public enum UserStatusEnum
    {
        [Description("Completed successfull")]
        SuccessfullResponse = 1,

        [Description("Not Found User")]
        NotFoundUser = 2,

        [Description("An erro ocurred")]
        ErrorOcurred = 3,
    }
}
