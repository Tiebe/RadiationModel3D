using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Dubnium263 : RadioactiveSubstance
    {
        public override string name { get; } = "Dubnium263";
        public override double halfLife { get; } = 29.0d;
        public override double atomicWeight { get; } = 263.11499d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.56d, new List<RadioactiveSubstance> {  } },
            { 0.37d, new List<RadioactiveSubstance> { new AlphaParticle(9855047.4), new Lawrencium259() } },
            { 0.069d, new List<RadioactiveSubstance> { new BetaParticle(1, 2350000.0), new Rutherfordium263() } },

        };
    }
}
    
    