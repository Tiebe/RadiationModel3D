
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium206 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium206";
        public override double halfLife { get; } = 760320.0d;
        public override double atomicWeight { get; } = 205.98047d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.9455d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth206() } },

            { 0.0545d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead202() } },

        };
    }
}
    
    