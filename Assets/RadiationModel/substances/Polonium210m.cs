using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium210m : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium210m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 209.98455d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((1557000.0, 0.0008)), new Polonium210() } },

        };
    }
}
    
    