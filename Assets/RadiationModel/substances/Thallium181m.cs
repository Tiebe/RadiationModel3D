using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium181m : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium181m";
        public override double halfLife { get; } = 0.0014d;
        public override double atomicWeight { get; } = 180.98716d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.996d, new List<RadioactiveSubstance> { new GammaParticle(0.00148), new Thallium181() } },
            { 0.004d, new List<RadioactiveSubstance> { new AlphaParticle(8178047.4), new Gold177() } },

        };
    }
}
    
    