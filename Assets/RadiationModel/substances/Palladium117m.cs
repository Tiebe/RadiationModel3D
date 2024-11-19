using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Palladium117m : RadioactiveSubstance
    {
        public override string name { get; } = "Palladium117m";
        public override double halfLife { get; } = 0.0191d;
        public override double atomicWeight { get; } = 116.91817d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((203000.0, 0.00611)), new Palladium117() } },

        };
    }
}
    
    