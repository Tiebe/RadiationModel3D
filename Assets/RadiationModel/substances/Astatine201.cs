using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine201 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine201";
        public override double halfLife { get; } = 85.2d;
        public override double atomicWeight { get; } = 200.98842d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.71d, new List<RadioactiveSubstance> { new AlphaParticle(7495002.09), new Bismuth197() } },
            { 0.29d, new List<RadioactiveSubstance> { new BetaParticle(1, 5732000.0), new Polonium201() } },

        };
    }
}
    
    