using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium221 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium221";
        public override double halfLife { get; } = 25.0d;
        public override double atomicWeight { get; } = 221.01392d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(7902002.09), new Radon217() } },
            { 1.2e-12d, new List<RadioactiveSubstance> { new Carbon14(), new Lead207() } },

        };
    }
}
    
    