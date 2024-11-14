using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine193n : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine193n";
        public override double halfLife { get; } = 0.028d;
        public override double atomicWeight { get; } = 192.99997d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.76d, new List<RadioactiveSubstance> { new GammaParticle(0.02952), new Astatine193() } },
            { 0.24d, new List<RadioactiveSubstance> { new AlphaParticle(8635047.4), new Bismuth189() } },

        };
    }
}
    
    