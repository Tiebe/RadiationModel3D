
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thorium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Thorium231";
        public override double halfLife { get; } = 91872.0d;
        public override double atomicWeight { get; } = 231.0363d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Protactinium231() } },

        };
    }
}
    
    