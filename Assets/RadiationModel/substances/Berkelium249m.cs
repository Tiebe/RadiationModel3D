using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Berkelium249m : RadioactiveSubstance
    {
        public override string name { get; } = "Berkelium249m";
        public override double halfLife { get; } = 0.0003d;
        public override double atomicWeight { get; } = 249.07499d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    