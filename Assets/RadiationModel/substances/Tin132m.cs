
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tin132m : RadioactiveSubstance
    {
        public override string name { get; } = "Tin132m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 131.92303d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Tin132() } },

        };
    }
}
    
    