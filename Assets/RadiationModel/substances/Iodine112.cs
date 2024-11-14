using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Iodine112 : RadioactiveSubstance
    {
        public override string name { get; } = "Iodine112";
        public override double halfLife { get; } = 3.34d;
        public override double atomicWeight { get; } = 111.928d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(1, 10505000.0), new Tellurium112() } },
            { 1.1999999999999999e-05d, new List<RadioactiveSubstance> { new AlphaParticle(3977047.4), new Antimony108() } },

        };
    }
}
    
    