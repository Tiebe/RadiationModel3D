using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Francium223 : RadioactiveSubstance
    {
        public override string name { get; } = "Francium223";
        public override double halfLife { get; } = 1320.0d;
        public override double atomicWeight { get; } = 223.01973d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(-1, 1149100.0), new Radium223() } },
            { 6e-05d, new List<RadioactiveSubstance> { new AlphaParticle(6583302.09), new Astatine219() } },

        };
    }
}
    
    