
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Actinium231 : RadioactiveSubstance
    {
        public override string name { get; } = "Actinium231";
        public override double halfLife { get; } = 450.0d;
        public override double atomicWeight { get; } = 231.03839d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thorium231() } },

        };
    }
}
    
    