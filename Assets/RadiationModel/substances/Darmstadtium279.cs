using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Darmstadtium279 : RadioactiveSubstance
    {
        public override string name { get; } = "Darmstadtium279";
        public override double halfLife { get; } = 0.21d;
        public override double atomicWeight { get; } = 279.15998d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.88d, new List<RadioactiveSubstance> {  } },
            { 0.12d, new List<RadioactiveSubstance> { new AlphaParticle(11125047.4), new Hassium275() } },

        };
    }
}
    
    