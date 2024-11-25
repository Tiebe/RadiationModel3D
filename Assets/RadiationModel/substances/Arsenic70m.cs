using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Arsenic70m : RadioactiveSubstance
    {
        public override string name { get; } = "Arsenic70m";
        public override double halfLife { get; } = 0.0001d;
        public override double atomicWeight { get; } = 69.93097d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    