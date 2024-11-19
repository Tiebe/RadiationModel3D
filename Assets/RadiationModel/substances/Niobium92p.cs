using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium92p : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium92p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 91.90955d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((2203300.0, 0.00056)), new Niobium92() } },

        };
    }
}
    
    