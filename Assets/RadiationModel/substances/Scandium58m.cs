using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Scandium58m : RadioactiveSubstance
    {
        public override string name { get; } = "Scandium58m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 57.98491d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00087, 1420000.0), new Scandium58() } },

        };
    }
}
    
    