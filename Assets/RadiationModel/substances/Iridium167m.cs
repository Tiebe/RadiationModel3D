
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium167m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium167m";
        public override double halfLife { get; } = 0.0285d;
        public override double atomicWeight { get; } = 166.98186d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.89d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium163() } },

            { 0.0040999999999999995d, new List<RadioactiveSubstance> { new ProtonParticle(), new Osmium166() } },

        };
    }
}
    
    