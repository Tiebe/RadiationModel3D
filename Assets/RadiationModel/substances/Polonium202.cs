
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

            { 0.9808d, new List<RadioactiveSubstance> { new BetaParticle(), new Bismuth202() } },

            { 0.0192d, new List<RadioactiveSubstance> { new AlphaParticle(), new Lead198() } },

        };
    }
}
    
    