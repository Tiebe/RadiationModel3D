
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

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Hafnium180() } },

            { 0.0031d, new List<RadioactiveSubstance> { new BetaParticle(), new Tantalum180() } },

        };
    }
}
    
    