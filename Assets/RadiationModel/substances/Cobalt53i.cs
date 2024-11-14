using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt53i : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt53i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 52.95885d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00029), new Cobalt53() } },
            { 0.009000000000000001d, new List<RadioactiveSubstance> { new ProtonParticle(), new Iron52() } },

        };
    }
}
    
    