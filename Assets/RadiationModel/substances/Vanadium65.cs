
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Vanadium65 : RadioactiveSubstance
    {
        public override string name { get; } = "Vanadium65";
        public override double halfLife { get; } = 0.014d;
        public override double atomicWeight { get; } = 64.987d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

        };
    }
}
    
    