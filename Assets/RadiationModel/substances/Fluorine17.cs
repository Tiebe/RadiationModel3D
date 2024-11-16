using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine17 : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine17";
        public override double halfLife { get; } = 64.37d;
        public override double atomicWeight { get; } = 17.0021d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 2760464.1999999997), new Oxygen17() } },

        };
    }
}
    
    