using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Krypton95m : RadioactiveSubstance
    {
        public override string name { get; } = "Krypton95m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 94.93992d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00636, 195000.0), new Krypton95() } },

        };
    }
}
    
    