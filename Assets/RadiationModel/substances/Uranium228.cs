using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Uranium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Uranium228";
        public override double halfLife { get; } = 546.0d;
        public override double atomicWeight { get; } = 228.03137d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 0.975d, new List<RadioactiveSubstance> { new AlphaParticle(7821002.09), new Thorium224() } },
            { 0.025d, new List<RadioactiveSubstance> { new Protactinium228() } },

        };
    }
}
    
    