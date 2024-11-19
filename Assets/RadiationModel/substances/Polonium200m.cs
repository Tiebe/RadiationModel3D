using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium200m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium200m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 199.9846d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00048, 2596000.0), new Polonium200() } },

        };
    }
}
    
    