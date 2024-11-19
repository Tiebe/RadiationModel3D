using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium235m : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium235m";
        public override double halfLife { get; } = 1542.0d;
        public override double atomicWeight { get; } = 235.04393d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((99.99999, 12.39842)), new Uranium235() } },

        };
    }
}
    
    