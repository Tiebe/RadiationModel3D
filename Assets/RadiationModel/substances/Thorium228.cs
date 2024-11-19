using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium228 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium228";
        public override double halfLife { get; } = 60352670.7d;
        public override double atomicWeight { get; } = 228.02874d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {
            { 1.0d, new List<RadioactiveSubstance> { new AlphaParticle(6542102.09), new Radium224() } },
            { 1.1300000000000001e-13d, new List<RadioactiveSubstance> { new Oxygen20(), new Lead208() } },

        };
    }
}
    
    