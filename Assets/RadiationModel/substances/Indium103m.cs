using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium103m : RadioactiveSubstance
    {
        public override string name { get; } = "Indium103m";
        public override double halfLife { get; } = 34.0d;
        public override double atomicWeight { get; } = 102.92056d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.67d, new List<RadioactiveSubstance> { new BetaParticle(1, 6651600.0), new Cadmium103() } },
            { 0.33d, new List<RadioactiveSubstance> { new GammaParticle(0.00196, 632000.0), new Indium103() } },

        };
    }
}
    
    