using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten186n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten186n";
        public override double halfLife { get; } = 7.5d;
        public override double atomicWeight { get; } = 185.95817d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    