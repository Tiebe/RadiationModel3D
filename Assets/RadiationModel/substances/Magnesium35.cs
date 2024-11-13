
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Magnesium35 : RadioactiveSubstance
    {
        public override string name { get; } = "Magnesium35";
        public override double halfLife { get; } = 0.0113d;
        public override double atomicWeight { get; } = 35.01679d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Aluminum35() } },

        };
    }
}
    
    