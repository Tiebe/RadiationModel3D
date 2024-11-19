using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium40j : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium40j";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 39.97546d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0001, 11988002.0), new Calcium40() } },

        };
    }
}
    
    