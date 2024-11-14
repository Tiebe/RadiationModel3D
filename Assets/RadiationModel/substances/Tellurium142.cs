using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tellurium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Tellurium142";
        public override double halfLife { get; } = 0.147d;
        public override double atomicWeight { get; } = 141.95003d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 8253000.0), new Iodine142() } },

        };
    }
}
    
    