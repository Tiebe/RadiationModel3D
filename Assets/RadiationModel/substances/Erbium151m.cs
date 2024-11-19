using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium151m : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium151m";
        public override double halfLife { get; } = 0.58d;
        public override double atomicWeight { get; } = 150.94023d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.953d, new List<RadioactiveSubstance> { new GammaParticle(0.00048, 2586000.0), new Erbium151() } },
            { 0.047d, new List<RadioactiveSubstance> { new BetaParticle(1, 7943000.0), new Holmium151() } },

        };
    }
}
    
    