using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium248m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium248m";
        public override double halfLife { get; } = 284012333.77133d;
        public override double atomicWeight { get; } = 248.07312d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    