using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Europium143m : RadioactiveSubstance
    {
        public override string name { get; } = "Europium143m";
        public override double halfLife { get; } = 5e-05d;
        public override double atomicWeight { get; } = 142.92072d;

        public override Dictionary<double, Dictionary<double, RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    