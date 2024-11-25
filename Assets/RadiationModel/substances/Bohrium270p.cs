using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bohrium270p : RadioactiveSubstance
    {
        public override string name { get; } = "Bohrium270p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 270.13411d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    