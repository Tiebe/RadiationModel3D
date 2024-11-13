
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon116 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon116";
        public override double halfLife { get; } = 59.0d;
        public override double atomicWeight { get; } = 115.92158d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Iodine116() } },

        };
    }
}
    
    