
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead197 : RadioactiveSubstance
    {
        public override string name { get; } = "Lead197";
        public override double halfLife { get; } = 486.0d;
        public override double atomicWeight { get; } = 196.97344d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium197() } },

        };
    }
}
    
    