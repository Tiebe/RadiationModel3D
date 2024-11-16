using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Germanium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Germanium80";
        public override double halfLife { get; } = 29.5d;
        public override double atomicWeight { get; } = 79.92535d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2679700.0), new Arsenic80() } },

        };
    }
}
    
    