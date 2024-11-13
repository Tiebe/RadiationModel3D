
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel48 : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel48";
        public override double halfLife { get; } = 0.0028d;
        public override double atomicWeight { get; } = 48.01952d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.7d, new List<RadioactiveSubstance> { new ProtonParticle(), new Iron46() } },

            { 0.3d, new List<RadioactiveSubstance> { new BetaParticle(), new Cobalt48() } },

        };
    }
}
    
    