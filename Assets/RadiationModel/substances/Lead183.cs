using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead183 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead183";
        public override double halfLife { get; } = 0.535d;
        public override double atomicWeight { get; } = 182.99186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7948047.4), new Mercury179() } },

        };
    }
}
    
    