using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Flerovium286 : RadioactiveSubstance
    {
        public override string name { get; } = "Flerovium286";
        public override double halfLife { get; } = 0.13d;
        public override double atomicWeight { get; } = 286.18423d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.59d, new List<RadioactiveSubstance> { new AlphaParticle(11377002.09), new Copernicium282() } },
            { 0.41d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    