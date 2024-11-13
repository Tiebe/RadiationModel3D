
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Potassium50 : RadioactiveSubstance
    {
        public override string name { get; } = "Potassium50";
        public override double halfLife { get; } = 0.472d;
        public override double atomicWeight { get; } = 49.97238d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Calcium50() } },

        };
    }
}
    
    