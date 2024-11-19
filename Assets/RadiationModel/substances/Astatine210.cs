using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine210 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine210";
        public override double halfLife { get; } = 29160.0d;
        public override double atomicWeight { get; } = 209.98715d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9982500000000001d, new List<RadioactiveSubstance> { new BetaParticle(1, 3981100.0), new Polonium210() } },
            { 0.0017499999999999998d, new List<RadioactiveSubstance> { new AlphaParticle(6653002.09), new Bismuth206() } },

        };
    }
}
    
    