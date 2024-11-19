using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Polonium211p : RadioactiveSubstance
    {
        public override string name { get; } = "Polonium211p";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 210.99188d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((4871500.0, 0.00025)), new Polonium211() } },

        };
    }
}
    
    