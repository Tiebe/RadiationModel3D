using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium203m : RadioactiveSubstance
    {
        public override string name { get; } = "Francium203m";
        public override double halfLife { get; } = 0.043d;
        public override double atomicWeight { get; } = 203.00133d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.8d, new List<RadioactiveSubstance> { new GammaParticle((361000.0, 0.00343)), new Francium203() } },
            { 0.2d, new List<RadioactiveSubstance> { new AlphaParticle(8657002.09), new Astatine199() } },

        };
    }
}
    
    