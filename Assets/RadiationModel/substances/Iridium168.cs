
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iridium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Iridium168";
        public override double halfLife { get; } = 0.23d;
        public override double atomicWeight { get; } = 167.97996d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(), new Rhenium164() } },

        };
    }
}
    
    