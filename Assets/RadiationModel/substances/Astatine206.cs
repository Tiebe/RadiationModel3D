
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine206 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine206";
        public override double halfLife { get; } = 1836.0d;
        public override double atomicWeight { get; } = 205.98665d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.991d, new List<RadioactiveSubstance> { new BetaParticle(), new Polonium206() } },

            { 0.009000000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(), new Bismuth202() } },

        };
    }
}
    
    