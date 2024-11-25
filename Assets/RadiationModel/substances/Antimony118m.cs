using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Antimony118m : RadioactiveSubstance
    {
        public override string name { get; } = "Antimony118m";
        public override double halfLife { get; } = 2e-05d;
        public override double atomicWeight { get; } = 117.90559d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    