using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium189 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium189";
        public override double halfLife { get; } = 138.0d;
        public override double atomicWeight { get; } = 188.97357d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5014000.0), new Mercury189() } },

        };
    }
}
    
    