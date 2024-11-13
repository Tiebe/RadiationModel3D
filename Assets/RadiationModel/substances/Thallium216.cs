
using System;
using System.Collections.Generic;
using RadiationModel.constants;

namespace RadiationModel.substances
{
    public class Thallium216 : RadioactiveSubstance
    {
        public override string name { get; } = "Thallium216";
        public override double halfLife { get; } = 5.9d;
        public override double atomicWeight { get; } = 216.01596d;

        public override Dictionary<double, List<RadioactiveSubstance>> decayProducts { get; } = new()
        {

            { 1.0d, new List<RadioactiveSubstance> { new BetaParticle(), new Lead216() } },

        };
    }
}
    
    