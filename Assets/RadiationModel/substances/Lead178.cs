using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead178 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead178";
        public override double halfLife { get; } = 0.00025d;
        public override double atomicWeight { get; } = 178.00384d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8811002.09), new Mercury174() } },

        };
    }
}
    
    