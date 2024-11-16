using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Curium234 : RadioactiveSubstance
    {
        public override string name { get; } = "Curium234";
        public override double halfLife { get; } = 52.0d;
        public override double atomicWeight { get; } = 234.05016d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.71d, new List<RadioactiveSubstance> { new BetaParticle(1, 2262000.0), new Americium234() } },
            { 0.27d, new List<RadioactiveSubstance> { new AlphaParticle(8387002.09), new Plutonium230() } },
            { 0.02d, new List<RadioactiveSubstance> {  } },

        };
    }
}
    
    