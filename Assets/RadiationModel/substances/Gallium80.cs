using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gallium80 : RadioactiveSubstance
    {
        public override string name { get; } = "Gallium80";
        public override double halfLife { get; } = 1.9d;
        public override double atomicWeight { get; } = 79.93642d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10311600.0), new Germanium80() } },

        };
    }
}
    
    