using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony131m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony131m";
        public override double halfLife { get; } = 9e-05d;
        public override double atomicWeight { get; } = 130.91379d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    