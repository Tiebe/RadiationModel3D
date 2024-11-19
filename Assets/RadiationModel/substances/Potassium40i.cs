using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium40i : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium40i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 39.9687d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4384000.0, 0.00028)), new Potassium40() } },

        };
    }
}
    
    