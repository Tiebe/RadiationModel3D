
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth188n : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth188n";
        public override double halfLife { get; } = 0.265d;
        public override double atomicWeight { get; } = 187.99244d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Thallium184() } },

        };
    }
}
    
    