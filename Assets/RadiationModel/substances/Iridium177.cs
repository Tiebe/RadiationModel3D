using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium177 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium177";
        public override double halfLife { get; } = 29.8d;
        public override double atomicWeight { get; } = 176.9613d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 5909000.0), new Osmium177() } },
            { 0.0006d, new List<RadioactiveSubstance> { new AlphaParticle(6104002.09), new Rhenium173() } },

        };
    }
}
    
    