
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead206m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead206m";
        public override double halfLife { get; } = 0.00013d;
        public override double atomicWeight { get; } = 205.97683d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Lead206() } },

        };
    }
}
    
    