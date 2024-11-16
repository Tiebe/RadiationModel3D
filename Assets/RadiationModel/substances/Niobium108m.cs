using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium108m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium108m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 107.93626d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((167000.0, 0.00742)), new Niobium108() } },

        };
    }
}
    
    