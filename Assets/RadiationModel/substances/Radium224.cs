using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Radium224 : RadioactiveSubstance
    {
        public override string name { get; } = "Radium224";
        public override double halfLife { get; } = 313770.24d;
        public override double atomicWeight { get; } = 224.02021d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6810802.09), new Radon220() } },
            { 4.0000000000000004e-11d, new List<RadioactiveSubstance> { new Carbon14(), new Lead210() } },

        };
    }
}
    
    