using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Fluorine18m : RadioactiveSubstance
    {
        public override string name { get; } = "Fluorine18m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 18.00214d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00111, 1121400.0), new Fluorine18() } },

        };
    }
}
    
    