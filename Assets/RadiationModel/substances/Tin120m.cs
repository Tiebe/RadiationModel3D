
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin120m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin120m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 119.90487d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tin120() } },

        };
    }
}
    
    