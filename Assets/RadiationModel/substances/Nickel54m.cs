using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Nickel54m : RadioactiveSubstance
    {
        public override string name { get; } = "Nickel54m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 53.96477d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.64d, new List<RadioactiveSubstance> { new GammaParticle(0.00019), new Nickel54() } },
            { 0.36d, new List<RadioactiveSubstance> { new ProtonParticle(), new Cobalt53() } },

        };
    }
}
    
    