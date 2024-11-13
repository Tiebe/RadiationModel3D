
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium113m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium113m";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 112.91035d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Palladium113() } },

        };
    }
}
    
    