using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine118m : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine118m";
        public override double halfLife { get; } = 510.0d;
        public override double atomicWeight { get; } = 117.91328d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 6909000.0), new Tellurium118() } },

        };
    }
}
    
    