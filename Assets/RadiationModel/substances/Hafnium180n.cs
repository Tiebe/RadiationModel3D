
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Hafnium180n : RadioactiveSubstance
    {
        public override string name { get; } = "Hafnium180n";
        public override double halfLife { get; } = 0.00057d;
        public override double atomicWeight { get; } = 179.94803d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Hafnium180() } },

        };
    }
}
    
    