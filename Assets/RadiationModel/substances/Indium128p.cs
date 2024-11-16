using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium128p : RadioactiveSubstance
    {
        public override string name { get; } = "Indium128p";
        public override double halfLife { get; } = 0.3d;
        public override double atomicWeight { get; } = 127.92228d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 10968500.0), new Tin128() } },

        };
    }
}
    
    