using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium202 : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium202";
        public override double halfLife { get; } = 2676.0d;
        public override double atomicWeight { get; } = 201.98074d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9808d, new List<RadioactiveSubstance> { new BetaParticle(1, 2809000.0), new Bismuth202() } },
            { 0.0192d, new List<RadioactiveSubstance> { new AlphaParticle(6720047.4), new Lead198() } },

        };
    }
}
    
    