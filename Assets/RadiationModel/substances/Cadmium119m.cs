using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cadmium119m : RadioactiveSubstance
    {
        public override string name { get; } = "Cadmium119m";
        public override double halfLife { get; } = 132.0d;
        public override double atomicWeight { get; } = 118.91d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 3869000.0), new Indium119() } },

        };
    }
}
    
    