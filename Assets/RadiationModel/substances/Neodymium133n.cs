using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Neodymium133n : RadioactiveSubstance
    {
        public override string name { get; } = "Neodymium133n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 132.92254d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00689, 180000.0), new Neodymium133() } },

        };
    }
}
    
    