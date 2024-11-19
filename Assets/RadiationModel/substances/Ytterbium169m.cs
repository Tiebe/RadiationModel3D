using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Ytterbium169m : RadioactiveSubstance
    {
        public override string name { get; } = "Ytterbium169m";
        public override double halfLife { get; } = 46.0d;
        public override double atomicWeight { get; } = 168.93521d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.05123, 24200.0), new Ytterbium169() } },

        };
    }
}
    
    