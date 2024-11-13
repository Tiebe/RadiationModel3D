
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Copper66m : RadioactiveSubstance
    {
        public override string name { get; } = "Copper66m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 65.93011d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(), new Copper66() } },

        };
    }
}
    
    