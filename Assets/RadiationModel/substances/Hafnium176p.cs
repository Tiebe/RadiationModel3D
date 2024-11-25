using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium176p : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium176p";
        public override double halfLife { get; } = 0.0004d;
        public override double atomicWeight { get; } = 175.94449d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    