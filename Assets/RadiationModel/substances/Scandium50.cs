using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium50";
        public override double halfLife { get; } = 102.5d;
        public override double atomicWeight { get; } = 49.95219d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 6894770.0), new Titanium50() } },

        };
    }
}
    
    