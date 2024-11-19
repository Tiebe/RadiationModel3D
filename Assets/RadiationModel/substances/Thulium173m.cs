using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thulium173m : RadioactiveSubstance
    {
        public override string name { get; } = "Thulium173m";
        public override double halfLife { get; } = 1e-05d;
        public override double atomicWeight { get; } = 172.93995d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new GammaParticle(0.0039, 318000.0), new Thulium173() } },

        };
    }
}
    
    