
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine116 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine116";
        public override double halfLife { get; } = 2.91d;
        public override double atomicWeight { get; } = 115.91689d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tellurium116() } },

        };
    }
}
    
    