using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radon210 : RadioactiveSubstance
    {
        public override string name { get; } = "Radon210";
        public override double halfLife { get; } = 8640.0d;
        public override double atomicWeight { get; } = 209.98969d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.96d, new List<RadioactiveSubstance> { new AlphaParticle(7179047.4), new Polonium206() } },

        };
    }
}
    
    