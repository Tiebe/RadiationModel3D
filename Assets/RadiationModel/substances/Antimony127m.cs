using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony127m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony127m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 126.90899d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    