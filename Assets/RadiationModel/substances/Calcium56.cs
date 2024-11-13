
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Calcium56 : RadioactiveSubstance
    {
        public override string name { get; } = "Calcium56";
        public override double halfLife { get; } = 0.011d;
        public override double atomicWeight { get; } = 55.9855d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Scandium56() } },

        };
    }
}
    
    