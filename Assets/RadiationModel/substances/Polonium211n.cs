using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium211n : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium211n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 210.98894d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00058, 2134500.0), new Polonium211() } },

        };
    }
}
    
    