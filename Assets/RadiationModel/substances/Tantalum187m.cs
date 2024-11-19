using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tantalum187m : RadioactiveSubstance
    {
        public override string name { get; } = "Tantalum187m";
        public override double halfLife { get; } = 7.3d;
        public override double atomicWeight { get; } = 186.96231d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1790000.0, 0.00069)), new Tantalum187() } },

        };
    }
}
    
    