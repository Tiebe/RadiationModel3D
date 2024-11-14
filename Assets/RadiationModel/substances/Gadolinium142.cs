using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Gadolinium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Gadolinium142";
        public override double halfLife { get; } = 70.2d;
        public override double atomicWeight { get; } = 141.92812d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 4350000.0), new Europium142() } },
            { 0.52d, new List<RadioactiveSubstance> { new Europium142() } },
            { 0.48d, new List<RadioactiveSubstance> { new BetaParticle(1, 4350000.0), new Europium142() } },

        };
    }
}
    
    