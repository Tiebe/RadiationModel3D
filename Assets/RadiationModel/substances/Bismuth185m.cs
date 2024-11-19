using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Bismuth185m : RadioactiveSubstance
    {
        public override string name { get; } = "Bismuth185m";
        public override double halfLife { get; } = 6e-05d;
        public override double atomicWeight { get; } = 184.99769d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.9d, new List<RadioactiveSubstance> { new ProtonParticle(), new Lead184() } },
            { 0.1d, new List<RadioactiveSubstance> { new AlphaParticle(9240002.09), new Thallium181() } },

        };
    }
}
    
    