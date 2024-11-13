
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Rhenium168 : RadioactiveSubstance
    {
        public override string name { get; } = "Rhenium168";
        public override double halfLife { get; } = 4.4d;
        public override double atomicWeight { get; } = 167.96158d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tungsten168() } },

            { 5e-05d, new List<RadioactiveSubstance> { new AlphaParticle(), new Tantalum164() } },

        };
    }
}
    
    