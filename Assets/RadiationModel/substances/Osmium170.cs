using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Osmium170 : RadioactiveSubstance
    {
        public override string name { get; } = "Osmium170";
        public override double halfLife { get; } = 7.37d;
        public override double atomicWeight { get; } = 169.96358d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.905d, new List<RadioactiveSubstance> { new BetaParticle(1, 4978000.0), new Rhenium170() } },
            { 0.095d, new List<RadioactiveSubstance> { new AlphaParticle(6556047.4), new Tungsten166() } },

        };
    }
}
    
    