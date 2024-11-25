using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Holmium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Holmium167m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 166.93342d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new Dictionary<double, RadioactiveSubstance> { { 1.0d, new Holmium167() } } },

        };
    }
}
    