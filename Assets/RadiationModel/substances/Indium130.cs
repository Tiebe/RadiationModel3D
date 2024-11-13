
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Indium130 : RadioactiveSubstance
    {
        public override string name { get; } = "Indium130";
        public override double halfLife { get; } = 0.273d;
        public override double atomicWeight { get; } = 129.92495d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Tin130() } },

        };
    }
}
    
    