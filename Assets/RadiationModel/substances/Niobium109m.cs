using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Niobium109m : RadioactiveSubstance
    {
        public override string name { get; } = "Niobium109m";
        public override double halfLife { get; } = double.PositiveInfinity;
        public override double atomicWeight { get; } = 108.93947d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle((310000.0, 0.004)), new Niobium109() } },

        };
    }
}
    
    