using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium285 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium285";
        public override double halfLife { get; } = 0.21d;
        public override double atomicWeight { get; } = 285.1835d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(11575047.4), new Copernicium281() } },
            { 0.2d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    