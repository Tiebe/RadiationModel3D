using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Terbium142 : RadioactiveSubstance
    {
        public override string name { get; } = "Terbium142";
        public override double halfLife { get; } = 0.597d;
        public override double atomicWeight { get; } = 141.93928d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10400000.0), new Gadolinium142() } },
            { 0.968d, new List<RadioactiveSubstance> { new BetaParticle(1, 10400000.0), new Gadolinium142() } },
            { 0.032d, new List<RadioactiveSubstance> { new Gadolinium142() } },

        };
    }
}
    
    