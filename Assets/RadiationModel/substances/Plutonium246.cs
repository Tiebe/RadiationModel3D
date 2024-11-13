
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium246 : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium246";
        public override double halfLife { get; } = 936576.0d;
        public override double atomicWeight { get; } = 246.0702d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Americium246() } },

        };
    }
}
    
    