using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel65m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel65m";
        public override double halfLife { get; } = 7e-05d;
        public override double atomicWeight { get; } = 64.93015d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    