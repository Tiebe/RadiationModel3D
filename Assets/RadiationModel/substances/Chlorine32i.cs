using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Chlorine32i : RadioactiveSubstance
    {
        public override string name { get; } = "Chlorine32i";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 31.9911d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00025), new Chlorine32() } },

        };
    }
}
    
    