using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Xenon112 : RadioactiveSubstance
    {
        public override string name { get; } = "Xenon112";
        public override double halfLife { get; } = 2.7d;
        public override double atomicWeight { get; } = 111.93556d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.988d, new List<RadioactiveSubstance> { new BetaParticle(1, 7037000.0), new Iodine112() } },
            { 0.012d, new List<RadioactiveSubstance> { new AlphaParticle(4351047.4), new Tellurium108() } },

        };
    }
}
    
    