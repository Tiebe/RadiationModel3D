
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nobelium253n : RadioactiveSubstance
    {
        public override string name { get; } = "Nobelium253n";
        public override double halfLife { get; } = 0.00071d;
        public override double atomicWeight { get; } = 253.09185d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Nobelium253() } },

        };
    }
}
    
    