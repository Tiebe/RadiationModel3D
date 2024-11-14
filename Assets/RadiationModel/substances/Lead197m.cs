using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead197m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead197m";
        public override double halfLife { get; } = 2574.0d;
        public override double atomicWeight { get; } = 196.97378d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.81d, new List<RadioactiveSubstance> { new BetaParticle(1, 3928000.0), new Thallium197() } },
            { 0.19d, new List<RadioactiveSubstance> { new GammaParticle(0.00389), new Lead197() } },

        };
    }
}
    
    