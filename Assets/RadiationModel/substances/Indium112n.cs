using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium112n : RadioactiveSubstance
    {
        public override string name { get; } = "Indium112n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 111.90592d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00353, 351000.0), new Indium112() } },

        };
    }
}
    
    