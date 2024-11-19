using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Tungsten181n : RadioactiveSubstance
    {
        public override string name { get; } = "Tungsten181n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 180.94999d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00075, 1653000.0), new Tungsten181() } },

        };
    }
}
    
    