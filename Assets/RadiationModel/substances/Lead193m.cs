
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Lead193m : RadioactiveSubstance
    {
        public override string name { get; } = "Lead193m";
        public override double halfLife { get; } = 348.0d;
        public override double atomicWeight { get; } = 192.97623d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Thallium193() } },

        };
    }
}
    
    