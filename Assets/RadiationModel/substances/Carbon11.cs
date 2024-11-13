
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Carbon11 : RadioactiveSubstance
    {
        public override string name { get; } = "Carbon11";
        public override double halfLife { get; } = 1220.412d;
        public override double atomicWeight { get; } = 11.01143d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Boron11() } },

        };
    }
}
    
    