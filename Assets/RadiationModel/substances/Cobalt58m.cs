using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Cobalt58m : RadioactiveSubstance
    {
        public override string name { get; } = "Cobalt58m";
        public override double halfLife { get; } = 31870.8d;
        public override double atomicWeight { get; } = 57.93578d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.999988d, new List<RadioactiveSubstance> { new GammaParticle(0.04979, 24900.0), new Cobalt58() } },
            { 1.1999999999999999e-05d, new List<RadioactiveSubstance> { new Iron58() } },

        };
    }
}
    
    