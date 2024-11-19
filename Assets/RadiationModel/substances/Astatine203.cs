using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine203 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine203";
        public override double halfLife { get; } = 444.0d;
        public override double atomicWeight { get; } = 202.98694d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.69d, new List<RadioactiveSubstance> { new BetaParticle(1, 5148000.0), new Polonium203() } },
            { 0.31d, new List<RadioactiveSubstance> { new AlphaParticle(7232002.09), new Bismuth199() } },

        };
    }
}
    
    