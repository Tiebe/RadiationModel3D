using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Astatine192 : RadioactiveSubstance
    {
        public override string name { get; } = "Astatine192";
        public override double halfLife { get; } = 0.0115d;
        public override double atomicWeight { get; } = 192.00314d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(8716047.4), new Bismuth188() } },

        };
    }
}
    
    