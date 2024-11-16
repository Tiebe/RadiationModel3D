using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Erbium173 : RadioactiveSubstance
    {
        public override string name { get; } = "Erbium173";
        public override double halfLife { get; } = 86.04d;
        public override double atomicWeight { get; } = 172.9424d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 2606000.0), new Thulium173() } },

        };
    }
}
    
    