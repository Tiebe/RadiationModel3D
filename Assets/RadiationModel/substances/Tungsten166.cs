
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten166 : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten166";
        public override double halfLife { get; } = 19.2d;
        public override double atomicWeight { get; } = 165.95503d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 0.99965d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum166() } },

            { 0.00035000000000000005d, new List<RadioactiveSubstance> { new AlphaParticle(), new Hafnium162() } },

        };
    }
}
    
    