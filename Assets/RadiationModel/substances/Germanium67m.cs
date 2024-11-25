using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium67m : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium67m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 66.93274d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    