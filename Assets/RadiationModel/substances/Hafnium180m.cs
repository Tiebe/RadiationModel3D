using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium180m : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium180m";
        public override double halfLife { get; } = 19908.0d;
        public override double atomicWeight { get; } = 179.94779d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1141599.99999, 0.00109)), new Hafnium180() } },
            { 0.0031d, new List<RadioactiveSubstance> { new BetaParticle(-1, 295700.0), new Tantalum180() } },

        };
    }
}
    
    