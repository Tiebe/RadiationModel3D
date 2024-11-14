using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon204 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon204";
        public override double halfLife { get; } = 74.52d;
        public override double atomicWeight { get; } = 203.99144d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.7240000000000001d, new List<RadioactiveSubstance> { new AlphaParticle(7567047.4), new Polonium200() } },

        };
    }
}
    
    