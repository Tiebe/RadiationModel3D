using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Plutonium245m : RadioactiveSubstance
    {
        public override string name { get; } = "Plutonium245m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 245.06811d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00468, 265000.0), new Plutonium245() } },

        };
    }
}
    
    