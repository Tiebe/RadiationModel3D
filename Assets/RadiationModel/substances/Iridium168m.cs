
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium168m : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium168m";
        public override double halfLife { get; } = 0.163d;
        public override double atomicWeight { get; } = 167.98001d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.77d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium164() } },

        };
    }
}
    
    