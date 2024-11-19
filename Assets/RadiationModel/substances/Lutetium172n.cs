using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lutetium172n : RadioactiveSubstance
    {
        public override string name { get; } = "Lutetium172n";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 171.93916d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.01884, 65800.0), new Lutetium172() } },

        };
    }
}
    
    