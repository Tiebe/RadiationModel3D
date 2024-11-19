using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Mercury186m : RadioactiveSubstance
    {
        public override string name { get; } = "Mercury186m";
        public override double halfLife { get; } = 8e-05d;
        public override double atomicWeight { get; } = 185.97174d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.00056, 2217000.0), new Mercury186() } },

        };
    }
}
    
    