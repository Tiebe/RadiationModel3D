
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silver103m : RadioactiveSubstance
    {
        public override string name { get; } = "Silver103m";
        public override double halfLife { get; } = 5.7d;
        public override double atomicWeight { get; } = 102.9091d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Silver103() } },

        };
    }
}
    
    