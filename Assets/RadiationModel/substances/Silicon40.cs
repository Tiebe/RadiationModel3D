
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Silicon40 : RadioactiveSubstance
    {
        public override string name { get; } = "Silicon40";
        public override double halfLife { get; } = 0.0312d;
        public override double atomicWeight { get; } = 40.00609d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Phosphorus40() } },

        };
    }
}
    
    