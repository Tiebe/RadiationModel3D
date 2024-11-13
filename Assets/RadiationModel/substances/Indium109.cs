
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium109 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium109";
        public override double halfLife { get; } = 14972.4d;
        public override double atomicWeight { get; } = 108.90715d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Cadmium109() } },

        };
    }
}
    
    